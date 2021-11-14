using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Packaging;
using System;
using System.Text.RegularExpressions;
using OfficeOpenXml;
//using NPOI;
//using NPOI.XSSF.UserModel;
//using NPOI.SS.UserModel;

namespace WP_Mixer_WinForms
{
    public partial class Form1 : Form
    {
        private Settings settings = new Settings();

        public Form1()
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


            //Thread _t = new Thread(WorkThread);
            //_t.Start(settings);

            WorkThread(settings);

        }

        //private void WorkThread(object? _settings)
        //{
        //    ClearLog();
        //    LogMessage("Поехали!...");
        //    if (_settings == null)
        //    {
        //        MessageBox.Show("Не указанны настройки!");
        //        return;
        //    }

        //    Settings wSettings = (Settings)_settings;
        //    FileStream? fs1 = null;
        //    FileStream? fs2 = null;
        //    try
        //    {
        //        fs1 = new FileStream(settings.orderFileName, FileMode.Open);
        //        fs1.Position = 0;

        //        fs2 = new FileStream(settings.srcFileName, FileMode.Open);
        //        fs2.Position = 0;
        //    }
        //    catch
        //    {
        //        if (fs1 != null)
        //        {
        //            fs1.Close();
        //        }
        //        if (fs2 != null)
        //        {
        //            fs2.Close();
        //        }
        //        EnableDisableButtons(true);
        //        MessageBox.Show("Невозможно открыть файл.\r\nПроверьте, возможно он уже открыт в другой программе.", "Невозможно открыть файл");
        //        return;
        //    }

        //    XSSFWorkbook orderWorkbook = new XSSFWorkbook(fs1);
        //    XSSFWorkbook srcWorkbook = new XSSFWorkbook(fs2);

        //    ISheet orderSheet = orderWorkbook.GetSheetAt(0);
        //    IRow headerRow = orderSheet.GetRow(0);
        //    int cellCount = headerRow.LastCellNum;

        //    // Артикулы в колонке 4
        //    List<string> articuls = new List<string>();
        //    // Кол-во в колонке 6
        //    List<string> qty = new List<string>();

        //    for (int i = (orderSheet.FirstRowNum + 1); i <= orderSheet.LastRowNum; i++)
        //    {
        //        IRow row = orderSheet.GetRow(i);
        //        if (row == null) continue;
        //        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;

        //        if (row.GetCell(3) != null)
        //        {
        //            if (!string.IsNullOrEmpty(row.GetCell(3).ToString()) && !string.IsNullOrWhiteSpace(row.GetCell(3).ToString()))
        //            {
        //                articuls.Add(row.GetCell(3).ToString());
        //                qty.Add(row.GetCell(5).ToString());
        //            }
        //        }
        //    }

        //    LogMessage("В заказе " + articuls.Count.ToString() + " артикулов для поиска");

        //    int srcSheetsCount = srcWorkbook.Count;

        //    LogMessage("Всего производителей " + srcSheetsCount.ToString());

        //    pbProgress.Invoke((MethodInvoker)(() => pbProgress.Maximum = srcSheetsCount * articuls.Count));

        //    var pictures = srcWorkbook.GetAllPictures();




        //    foreach (ISheet sheet in srcWorkbook)
        //    {
        //        LogMessage("Обработка производителя " + sheet.SheetName);
        //        List<IRow> foundRows = new List<IRow>();

        //        for (int articulIndex = 0; articulIndex < articuls.Count; articulIndex++)
        //        {
        //            string articul = prepareCellValue(articuls[articulIndex]);
        //            foreach (IRow row in sheet)
        //            {
        //                if (row == null) continue;
        //                if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;

        //                // В файле производителей артикул в 5й колонке
        //                ICell cell = row.GetCell(4);
        //                if (cell != null && prepareCellValue(cell.ToString()) == articul)
        //                {
        //                    foundRows.Add(row);
        //                }

        //            }
        //            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Value++));
        //        }
        //    }
        //    fs1.Close();
        //    fs2.Close();
        //}


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




            foreach (ExcelWorksheet sheet in srcWorkbook.Worksheets)
            {
                //var drawnings = sheet.Drawings.;
                LogMessage("Обработка производителя " + sheet.Name);
                List<int> foundRows = new List<int>();

                for (int articulIndex = 0; articulIndex < articuls.Count; articulIndex++)
                {
                    string articul = prepareCellValue(articuls[articulIndex]);
                    for (int row = 1; row <= sheet.Dimension.End.Row; row++)
                    {
                        var cell = sheet.Cells[row, 5];
                        if (cell == null || cell.Value == null) continue;
                    
                        if (prepareCellValue(cell.Value.ToString()) == articul)
                        {
                            foundRows.Add(row);
                        }

                    }
                    pbProgress.Invoke((MethodInvoker)(() => pbProgress.Value++));
                }
            }

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