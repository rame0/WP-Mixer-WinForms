using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Packaging;
using System;
using System.Text.RegularExpressions;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;


namespace WP_Mixer_WinForms
{
    public partial class WB_Mixer : Form
    {
        private Settings settings = new Settings();

        public WB_Mixer()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }



        private void OpenOrderFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.orderFileName) == true)
            {
                CheckEnableStartButton();
                OrderFileLabel.Text = settings.orderFileName;
            }
        }

        private void OpenSrcFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.srcFileName) == true)
            {
                CheckEnableStartButton();
                SrcFileLabel.Text = settings.srcFileName;
            }
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.outDirectory = folderBrowserDialog.SelectedPath;
            }

            EnableDisableButtons(false);


            Thread _t = new Thread(WorkThread);
            _t.Start(settings);

            //WorkThread(settings);

        }

        private void WorkThread(object? _settings)
        {
            ClearLog();
            LogMessage("Поехали!...");
            if (_settings == null)
            {
                MessageBox.Show("Не указанны настройки!");
                return;
            }

            Settings wSettings = (Settings)_settings;
            FileInfo fs1 = new FileInfo(settings.orderFileName);
            FileInfo fs2 = new FileInfo(settings.srcFileName);


            var orderPackage = new ExcelPackage(fs1);
            var srcPackage = new ExcelPackage(fs2);



            var orderWorkbook = orderPackage.Workbook;
            var srcWorkbook = srcPackage.Workbook;

            ExcelWorksheet orderSheet = orderWorkbook.Worksheets.ElementAt(0);


            // Артикулы в колонке 4
            int artCol = 4;
            // Кол-во в колонке 6
            int qtyCol = 6;
            List<string> articuls = new List<string>();
            List<string> qtys = new List<string>();

            int rows = orderSheet.Dimension.End.Row;

            for (int i = 2; i <= rows; i++)
            {
                if (orderSheet.Cells[i, artCol].Value == null && orderSheet.Cells[i, qtyCol].Value == null)
                    continue;

                string articul = orderSheet.Cells[i, artCol].Value.ToString();
                string qty = orderSheet.Cells[i, qtyCol].Value.ToString();

                if (!string.IsNullOrEmpty(articul) && !string.IsNullOrWhiteSpace(articul))
                {
                    articuls.Add(articul);
                    qtys.Add(qty);
                }

            }

            LogMessage("В заказе " + articuls.Count.ToString() + " артикулов для поиска");

            int srcSheetsCount = srcWorkbook.Worksheets.Count;

            LogMessage("Всего производителей " + srcSheetsCount.ToString());

            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Maximum = srcSheetsCount * articuls.Count));

            //var pictures = srcWorkbook.GetAllPictures();

            string dateString = DateTime.Now.ToString("yyyy-MM-dd");



            foreach (ExcelWorksheet sheet in srcWorkbook.Worksheets)
            {
                var drawings = sheet.Drawings;
                LogMessage("Обработка производителя " + sheet.Name);


                int foundRows = 0;

                using (var newPackage = new ExcelPackage())
                {
                    var newWorksheet = newPackage.Workbook.Worksheets.Add(sheet.Name);

                    for (int col = 1; col <= sheet.Dimension.End.Column; col++)
                    {
                        newWorksheet.Cells[1, col].Value = sheet.Cells[1, col].Value;
                        newWorksheet.Column(col).Width = sheet.Column(col).Width;
                    }

                    for (int articulIndex = 0; articulIndex < articuls.Count; articulIndex++)
                    {
                        string articul = prepareCellValue(articuls[articulIndex]);
                        for (int row = 1; row <= sheet.Dimension.End.Row; row++)
                        {
                            var cell = sheet.Cells[row, 5];
                            if (cell == null || cell.Value == null) continue;

                            if (prepareCellValue(cell.Value.ToString()) == articul)
                            {
                                foundRows++;

                                for (int col = 1; col <= sheet.Dimension.End.Column; col++)
                                {
                                    newWorksheet.Cells[foundRows + 1, col].Value = sheet.Cells[row, col].Value;
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
                        pbProgress.Invoke((MethodInvoker)(() => pbProgress.Value++));
                    }
                    LogMessage("Нашлось совпадений артикулов: " + foundRows.ToString());

                    if (foundRows > 0)
                    {
                        string resultFileName = settings.outDirectory + "\\" + dateString + "_" + sheet.Name + ".xlsx";
                        newPackage.SaveAs(resultFileName);
                        LogMessage("Файл сохранен в:\r\n" + resultFileName);
                    }
                    else
                    {
                        LogMessage("Нечего сохранять.");
                    }
                    LogMessage("---");
                }
            }

            LogMessage("Готово!");
            EnableDisableButtons(true); 

        }


        private void ClearLog()
        {
            tbLog.Invoke((MethodInvoker)(() => tbLog.Text = ""));
        }

        private void LogMessage(string message)
        {
            tbLog.Invoke((MethodInvoker)(() => tbLog.AppendText(message + "\r\n")));
        }


        private void EnableDisableButtons(bool isEnabled)
        {
            OpenSrcFileBtn.Invoke((MethodInvoker)(() => OpenSrcFileBtn.Enabled = isEnabled));
            OpenOrderFileBtn.Invoke((MethodInvoker)(() => OpenOrderFileBtn.Enabled = isEnabled));
            StartBtn.Invoke((MethodInvoker)(() => StartBtn.Enabled = isEnabled));
        }


        private void CheckEnableStartButton()
        {
            if (settings.isReady())
            {
                StartBtn.Enabled = true;
            }
            else
            {
                StartBtn.Enabled = false;

            }
        }


        private bool ShowOpenDialog(out string fileName)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "XLSX (*.xlsx)|*.xlsx";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                return true;

            }
            else
            {
                fileName = "Выберите файл...";
                return false;
            }

        }


        // Given a cell name, parses the specified cell to get the column name.
        private static string prepareCellValue(string cellText)
        {
            // Create a regular expression to match the column name portion of the cell name.
            Regex regex = new Regex("[A-Za-z0-9]+");
            Match match = regex.Match(cellText);

            return match.Value;
        }

        // Given a cell name, parses the specified cell to get the row index.
        private static uint GetRowIndex(string cellName)
        {
            // Create a regular expression to match the row index portion the cell name.
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(cellName);

            return uint.Parse(match.Value);
        }
    }
}