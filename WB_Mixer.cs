using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Packaging;
using System;
using System.Text.RegularExpressions;
using OfficeOpenXml;


namespace WP_Mixer_WinForms
{
    public partial class WB_Mixer : Form
    {
        private readonly Settings settings = new();

        public WB_Mixer()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            settings.setMaxProgress = new Progress<int>(i => pbProgress.Maximum = i);
            settings.setProgress = new Progress<int>(i => pbProgress.Value = i);
            settings.addProgress = new Progress<int>(i => pbProgress.Value += i);
            settings.setLogMessage = new Progress<string>(s => tbLog.Text = s);
            settings.logMessage = new Progress<string>(s => tbLog.AppendText(s + "\r\n"));
            settings.enableDisableControlls = new Progress<bool>(b => splitContainer.Panel1.Enabled = b);
        }



        private void OpenOrderFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.orderFileName, "XLSX (*.xlsx)|*.xlsx") == true)
            {
                CheckEnableStartButton();
                OrderFileLabel.Text = settings.orderFileName;
            }
        }

        private void OpenSrcFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.mainFileName, "XLSX (*.xlsx)|*.xlsx") == true)
            {
                CheckEnableStartButton();
                SrcFileLabel.Text = settings.mainFileName;
            }
        }


        private void OpenUnoFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.unoFileName, "Excel Workbook 97-2003|*.xls") == true)
            {
                CheckEnableStartButton();
                UnoFileLabel.Text = settings.unoFileName;
            }
        }

        private void OpenMertzFileBtn_Click(object sender, EventArgs e)
        {
            if (ShowOpenDialog(out settings.mertzFileName, "Excel Workbook 97-2003|*.xls") == true)
            {
                CheckEnableStartButton();
                MertzFileLabel.Text = settings.mertzFileName;
            }
        }



        private async void StartBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.outDirectory = folderBrowserDialog.SelectedPath;

                await Task.Factory.StartNew(() => MainFileWorker.Run(settings),
                                            TaskCreationOptions.LongRunning);
            }
        }

        private async void StartUnoBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.outDirectory = folderBrowserDialog.SelectedPath;

                await Task.Factory.StartNew(() => UnoFileWorker.Run(settings),
                                            TaskCreationOptions.LongRunning);
            }
        }

        private async void StartMertzBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.outDirectory = folderBrowserDialog.SelectedPath;

                await Task.Factory.StartNew(() => MertzFileWorker.Run(settings),
                                            TaskCreationOptions.LongRunning);
            }
        }


        private void CheckEnableStartButton()
        {
            if (settings.IsMainReady())
            {
                StartMainBtn.Enabled = true;
            }
            else
            {
                StartMainBtn.Enabled = false;
            }
            if (settings.IsUnoReady())
            {
                StartUnoBtn.Enabled = true;
            }
            else
            {
                StartUnoBtn.Enabled = false;
            }

            if (settings.IsMertzReady())
            {
                StartMertzBtn.Enabled = true;
            }
            else
            {
                StartMertzBtn.Enabled = false;
            }
        }


        private static bool ShowOpenDialog(out string fileName, string filter)
        {
            OpenFileDialog ofd = new();

            ofd.Filter = filter;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                return true;

            }
            else
            {
                fileName = "Âûבונטעו פאיכ...";
                return false;
            }

        }

    }
}