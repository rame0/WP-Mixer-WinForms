using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;

namespace WP_Mixer_WinForms
{
    partial class MertzFileWorker: Workers
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
            wSettings.logMessage.Report("Обработка Mertz...");


            List<string> articuls = new();
            List<string> qtys = new();

            FileInfo fs1 = new(wSettings.orderFileName);
            using (var orderPackage = new ExcelPackage(fs1))
            {
                var orderWorkbook = orderPackage.Workbook;
                ExcelWorksheet orderSheet = orderWorkbook.Worksheets.ElementAt(0);

                // Артикулы в колонке 4
                int artCol = 4;
                // Кол-во в колонке 6
                int qtyCol = 6;

                int rows = orderSheet.Dimension.End.Row;

                for (int i = 2; i <= rows; i++)
                {
                    if (orderSheet.Cells[i, artCol].Value == null && orderSheet.Cells[i, qtyCol].Value == null)
                        continue;

                    string? articul = orderSheet.Cells[i, artCol].Value.ToString();
                    string? qty = orderSheet.Cells[i, qtyCol].Value.ToString();

                    if (!string.IsNullOrEmpty(articul)
                        && !string.IsNullOrWhiteSpace(articul)
                        && !string.IsNullOrEmpty(qty))
                    {
                        articuls.Add(PrepareCellValue(articul));
                        qtys.Add(PrepareCellValue(qty));
                    }

                }
            }

            wSettings.logMessage.Report("В заказе " + articuls.Count.ToString() + " артикулов для поиска");


            string dateString = DateTime.Now.ToString("yyyy-MM-dd");


            using (FileStream fs2 = File.Open(wSettings.mertzFileName, FileMode.Open, FileAccess.Read))
            {
                HSSFWorkbook MertzWorkbook = new HSSFWorkbook(fs2, true);
                HSSFSheet sheet = (HSSFSheet)MertzWorkbook.GetSheetAt(0);

                int foundRows = 0;


                wSettings.setMaxProgress.Report( sheet.LastRowNum);
                wSettings.setProgress.Report(0);

                for (int i = 8; i <= sheet.LastRowNum; i++)
                {
                    wSettings.addProgress.Report(1);

                    IRow row = sheet.GetRow(i);
                    if (row == null)
                    {
                        continue;
                    }
                    ICell cellArticul = row.GetCell(2);
                    ICell cellQty = row.GetCell(4);
                    if (cellArticul == null || cellQty == null)
                    {
                        continue;
                    }


                    string articulFromMertz = PrepareCellValue(cellArticul.ToString());

                    int art_key = articuls.IndexOf(articulFromMertz);
                    if (art_key != -1)
                    {
                        foundRows++;
                        cellQty.SetCellValue(qtys[art_key]);
                    }
                }


                wSettings.logMessage.Report("Нашлось совпадений артикулов: " + foundRows.ToString());

                if (foundRows > 0)
                {
                    string resultFileName = wSettings.outDirectory + "\\" + dateString + "_Mertz.xls";
                    using (FileStream fsResult = File.Create(resultFileName))
                    {
                        // Прячем колонку с артикулами в итоговом файле, чтобы не мешала
                        sheet.SetColumnHidden(2, true);
                        MertzWorkbook.Write(fsResult);
                        wSettings.logMessage.Report("Файл сохранен в:\r\n" + resultFileName);
                    }
                }
                else
                {
                    wSettings.logMessage.Report("Нечего сохранять.");
                }
            }

            wSettings.logMessage.Report("\r\nГотово!");
            wSettings.enableDisableControlls.Report(true);

        }

    }
}
