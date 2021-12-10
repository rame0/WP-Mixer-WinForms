using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WP_Mixer_WinForms
{
    partial class MainFileWorker : Workers
    {

        public static void Run(object? _settings)
        {
            if (_settings == null)
            {
                MessageBox.Show("Не указанны настройки!");
                return;
            }

            Settings wSettings = (Settings)_settings;

            wSettings.enableDisableControlls.Report(false);
            wSettings.setLogMessage.Report("");
            wSettings.logMessage.Report("Поехали!...");

            FileInfo fs1 = new FileInfo(wSettings.orderFileName);
            FileInfo fs2 = new FileInfo(wSettings.mainFileName);


            var orderPackage = new ExcelPackage(fs1);
            var srcPackage = new ExcelPackage(fs2);



            var orderWorkbook = orderPackage.Workbook;
            var srcWorkbook = srcPackage.Workbook;

            ExcelWorksheet orderSheet = orderWorkbook.Worksheets[0];


            // Артикулы в колонке 4
            int artCol = 4;
            // Кол-во в колонке 6
            int qtyCol = 6;
            List<string> articuls = new List<string>();
            List<int> qtys = new List<int>();

            int rows = orderSheet.Dimension.End.Row;

            for (int i = 2; i <= rows; i++)
            {
                if (orderSheet.Cells[i, artCol].Value == null && orderSheet.Cells[i, qtyCol].Value == null)
                    continue;

                string? articul = orderSheet.Cells[i, artCol].Value.ToString();
                string? qty_str = orderSheet.Cells[i, qtyCol].Value.ToString();

                if (!string.IsNullOrEmpty(articul)
                    && !string.IsNullOrWhiteSpace(articul)
                    && !string.IsNullOrEmpty(qty_str))
                {
                    if (int.TryParse(qty_str, out int qty))
                    {
                        articuls.Add(articul);
                        qtys.Add(qty);
                    }
                }

            }

            wSettings.logMessage.Report("В заказе " + articuls.Count.ToString() + " артикулов для поиска");

            int srcSheetsCount = srcWorkbook.Worksheets.Count;

            wSettings.logMessage.Report("Всего производителей " + srcSheetsCount.ToString());
            
            wSettings.setMaxProgress.Report(srcSheetsCount * articuls.Count);
            wSettings.setProgress.Report(0);
        

            //var pictures = srcWorkbook.GetAllPictures();

            string dateString = DateTime.Now.ToString("yyyy-MM-dd");



            foreach (ExcelWorksheet sheet in srcWorkbook.Worksheets)
            {
                var drawings = sheet.Drawings;
                wSettings.logMessage.Report("Обработка производителя " + sheet.Name);


                int foundRows = 0;

                using (var newPackage = new ExcelPackage())
                {
                    var newWorksheet = newPackage.Workbook.Worksheets.Add(sheet.Name);

                    for (int col = 1; col <= sheet.Dimension.End.Column; col++)
                    {
                        newWorksheet.Cells[1, col].Value = sheet.Cells[1, col].Value; if (col == 6)
                        {
                            newWorksheet.Cells[1, col].Value = "Кол-во";
                        }
                        newWorksheet.Column(col).Width = sheet.Column(col).Width;
                    }

                    for (int articulIndex = 0; articulIndex < articuls.Count; articulIndex++)
                    {
                        string articul = PrepareCellValue(articuls[articulIndex]);
                        for (int row = 1; row <= sheet.Dimension.End.Row; row++)
                        {
                            var cell = sheet.Cells[row, 5];
                            if (cell == null || cell.Value == null) continue;

                            if (PrepareCellValue(cell.Value.ToString()) == articul)
                            {
                                foundRows++;

                                for (int col = 1; col <= sheet.Dimension.End.Column; col++)
                                {
                                    newWorksheet.Cells[foundRows + 1, col].Value = sheet.Cells[row, col].Value;
                                    if (col == 6)
                                    {
                                        newWorksheet.Cells[foundRows + 1, col].Value = qtys[articulIndex];
                                    }
                                    newWorksheet.Row(foundRows + 1).Height = sheet.Row(row).Height;
                                }

                                ExcelPicture? d = (ExcelPicture?)drawings.Where(d => d.From.Column == 3 && d.From.Row == row - 1).FirstOrDefault();
                                if (d != null)
                                {
                                    var pic = newWorksheet.Drawings.AddPicture(d.Name, d.Image);
                                    pic.From.Column = d.From.Column;
                                    pic.From.Row = foundRows;
                                    pic.Size.Width = d.Size.Width;
                                    pic.Size.Height = d.Size.Height;
                                    //pic.ImageFormat = d.ImageFormat;
                                }

                                break;
                            }

                        }
                        wSettings.addProgress.Report(1);

                    }
                    wSettings.logMessage.Report("Нашлось совпадений артикулов: " + foundRows.ToString());

                    if (foundRows > 0)
                    {
                        string resultFileName = wSettings.outDirectory + "\\" + dateString + "_" + sheet.Name + ".xlsx";
                        newPackage.SaveAs(resultFileName);
                        wSettings.logMessage.Report("Файл сохранен в:\r\n" + resultFileName);
                    }
                    else
                    {
                        wSettings.logMessage.Report("Нечего сохранять.");
                    }
                    wSettings.logMessage.Report("---");
                }
            }

            wSettings.logMessage.Report("Готово!");

            wSettings.enableDisableControlls.Report(true);

        }
    }
}
