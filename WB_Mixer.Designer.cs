using System.Windows.Forms;

namespace WP_Mixer_WinForms
{
    partial class WB_Mixer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenOrderFileBtn = new System.Windows.Forms.Button();
            this.OrderFileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabsContainer = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.SrcFileLabel = new System.Windows.Forms.Label();
            this.OpenSrcFileBtn = new System.Windows.Forms.Button();
            this.StartMainBtn = new System.Windows.Forms.Button();
            this.tabUno = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnoFileLabel = new System.Windows.Forms.Label();
            this.OpenUnoFileBtn = new System.Windows.Forms.Button();
            this.StartUnoBtn = new System.Windows.Forms.Button();
            this.tabMertz = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MertzFileLabel = new System.Windows.Forms.Label();
            this.OpenMertzFileBtn = new System.Windows.Forms.Button();
            this.StartMertzBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.TabsContainer.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabUno.SuspendLayout();
            this.tabMertz.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenOrderFileBtn
            // 
            this.OpenOrderFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenOrderFileBtn.Location = new System.Drawing.Point(3, 25);
            this.OpenOrderFileBtn.Name = "OpenOrderFileBtn";
            this.OpenOrderFileBtn.Size = new System.Drawing.Size(98, 25);
            this.OpenOrderFileBtn.TabIndex = 2;
            this.OpenOrderFileBtn.Text = "Открыть файл";
            this.OpenOrderFileBtn.UseVisualStyleBackColor = true;
            this.OpenOrderFileBtn.Click += new System.EventHandler(this.OpenOrderFileBtn_Click);
            // 
            // OrderFileLabel
            // 
            this.OrderFileLabel.AutoSize = true;
            this.OrderFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderFileLabel.Location = new System.Drawing.Point(107, 31);
            this.OrderFileLabel.Name = "OrderFileLabel";
            this.OrderFileLabel.Size = new System.Drawing.Size(95, 13);
            this.OrderFileLabel.TabIndex = 1;
            this.OrderFileLabel.Text = "Выберите файл...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл Заказа с WB";
            // 
            // TabsContainer
            // 
            this.TabsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsContainer.Controls.Add(this.MainTab);
            this.TabsContainer.Controls.Add(this.tabUno);
            this.TabsContainer.Controls.Add(this.tabMertz);
            this.TabsContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabsContainer.Location = new System.Drawing.Point(3, 56);
            this.TabsContainer.Name = "TabsContainer";
            this.TabsContainer.SelectedIndex = 0;
            this.TabsContainer.Size = new System.Drawing.Size(400, 214);
            this.TabsContainer.TabIndex = 1;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.label3);
            this.MainTab.Controls.Add(this.SrcFileLabel);
            this.MainTab.Controls.Add(this.OpenSrcFileBtn);
            this.MainTab.Controls.Add(this.StartMainBtn);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(392, 188);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Все посьавщики";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите файл поставщиков";
            // 
            // SrcFileLabel
            // 
            this.SrcFileLabel.AutoSize = true;
            this.SrcFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SrcFileLabel.Location = new System.Drawing.Point(111, 33);
            this.SrcFileLabel.Name = "SrcFileLabel";
            this.SrcFileLabel.Size = new System.Drawing.Size(95, 13);
            this.SrcFileLabel.TabIndex = 4;
            this.SrcFileLabel.Text = "Выберите файл...";
            // 
            // OpenSrcFileBtn
            // 
            this.OpenSrcFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenSrcFileBtn.Location = new System.Drawing.Point(6, 27);
            this.OpenSrcFileBtn.Name = "OpenSrcFileBtn";
            this.OpenSrcFileBtn.Size = new System.Drawing.Size(98, 26);
            this.OpenSrcFileBtn.TabIndex = 5;
            this.OpenSrcFileBtn.Text = "Открыть файл";
            this.OpenSrcFileBtn.UseVisualStyleBackColor = true;
            this.OpenSrcFileBtn.Click += new System.EventHandler(this.OpenSrcFileBtn_Click);
            // 
            // StartMainBtn
            // 
            this.StartMainBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartMainBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartMainBtn.Enabled = false;
            this.StartMainBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StartMainBtn.Location = new System.Drawing.Point(6, 58);
            this.StartMainBtn.Name = "StartMainBtn";
            this.StartMainBtn.Size = new System.Drawing.Size(380, 31);
            this.StartMainBtn.TabIndex = 6;
            this.StartMainBtn.Text = "Начать";
            this.StartMainBtn.UseVisualStyleBackColor = true;
            this.StartMainBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // tabUno
            // 
            this.tabUno.Controls.Add(this.label2);
            this.tabUno.Controls.Add(this.label4);
            this.tabUno.Controls.Add(this.UnoFileLabel);
            this.tabUno.Controls.Add(this.OpenUnoFileBtn);
            this.tabUno.Controls.Add(this.StartUnoBtn);
            this.tabUno.Location = new System.Drawing.Point(4, 22);
            this.tabUno.Name = "tabUno";
            this.tabUno.Padding = new System.Windows.Forms.Padding(3);
            this.tabUno.Size = new System.Drawing.Size(392, 188);
            this.tabUno.TabIndex = 1;
            this.tabUno.Text = "Uno";
            this.tabUno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 93);
            this.label2.TabIndex = 7;
            this.label2.Text = "* В итоговом файле колонка \"Артикулы WB\"  будет просто скрыта, а не удалена.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите бланк Uno";
            // 
            // UnoFileLabel
            // 
            this.UnoFileLabel.AutoSize = true;
            this.UnoFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnoFileLabel.Location = new System.Drawing.Point(111, 34);
            this.UnoFileLabel.Name = "UnoFileLabel";
            this.UnoFileLabel.Size = new System.Drawing.Size(95, 13);
            this.UnoFileLabel.TabIndex = 4;
            this.UnoFileLabel.Text = "Выберите файл...";
            // 
            // OpenUnoFileBtn
            // 
            this.OpenUnoFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenUnoFileBtn.Location = new System.Drawing.Point(6, 28);
            this.OpenUnoFileBtn.Name = "OpenUnoFileBtn";
            this.OpenUnoFileBtn.Size = new System.Drawing.Size(98, 25);
            this.OpenUnoFileBtn.TabIndex = 5;
            this.OpenUnoFileBtn.Text = "Открыть файл";
            this.OpenUnoFileBtn.UseVisualStyleBackColor = true;
            this.OpenUnoFileBtn.Click += new System.EventHandler(this.OpenUnoFileBtn_Click);
            // 
            // StartUnoBtn
            // 
            this.StartUnoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartUnoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartUnoBtn.Enabled = false;
            this.StartUnoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StartUnoBtn.Location = new System.Drawing.Point(6, 59);
            this.StartUnoBtn.Name = "StartUnoBtn";
            this.StartUnoBtn.Size = new System.Drawing.Size(380, 30);
            this.StartUnoBtn.TabIndex = 6;
            this.StartUnoBtn.Text = "Начать";
            this.StartUnoBtn.UseVisualStyleBackColor = true;
            this.StartUnoBtn.Click += new System.EventHandler(this.StartUnoBtn_Click);
            // 
            // tabMertz
            // 
            this.tabMertz.Controls.Add(this.label6);
            this.tabMertz.Controls.Add(this.label5);
            this.tabMertz.Controls.Add(this.MertzFileLabel);
            this.tabMertz.Controls.Add(this.OpenMertzFileBtn);
            this.tabMertz.Controls.Add(this.StartMertzBtn);
            this.tabMertz.Location = new System.Drawing.Point(4, 22);
            this.tabMertz.Name = "tabMertz";
            this.tabMertz.Padding = new System.Windows.Forms.Padding(3);
            this.tabMertz.Size = new System.Drawing.Size(392, 188);
            this.tabMertz.TabIndex = 2;
            this.tabMertz.Text = "Mertz";
            this.tabMertz.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 93);
            this.label6.TabIndex = 8;
            this.label6.Text = "* В итоговом файле колонка \"Артикулы WB\"  будет просто скрыта, а не удалена.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выберите бланк Mertz";
            // 
            // MertzFileLabel
            // 
            this.MertzFileLabel.AutoSize = true;
            this.MertzFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MertzFileLabel.Location = new System.Drawing.Point(111, 34);
            this.MertzFileLabel.Name = "MertzFileLabel";
            this.MertzFileLabel.Size = new System.Drawing.Size(95, 13);
            this.MertzFileLabel.TabIndex = 4;
            this.MertzFileLabel.Text = "Выберите файл...";
            // 
            // OpenMertzFileBtn
            // 
            this.OpenMertzFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenMertzFileBtn.Location = new System.Drawing.Point(6, 28);
            this.OpenMertzFileBtn.Name = "OpenMertzFileBtn";
            this.OpenMertzFileBtn.Size = new System.Drawing.Size(98, 25);
            this.OpenMertzFileBtn.TabIndex = 5;
            this.OpenMertzFileBtn.Text = "Открыть файл";
            this.OpenMertzFileBtn.UseVisualStyleBackColor = true;
            this.OpenMertzFileBtn.Click += new System.EventHandler(this.OpenMertzFileBtn_Click);
            // 
            // StartMertzBtn
            // 
            this.StartMertzBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartMertzBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartMertzBtn.Enabled = false;
            this.StartMertzBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StartMertzBtn.Location = new System.Drawing.Point(6, 59);
            this.StartMertzBtn.Name = "StartMertzBtn";
            this.StartMertzBtn.Size = new System.Drawing.Size(380, 30);
            this.StartMertzBtn.TabIndex = 6;
            this.StartMertzBtn.Text = "Начать";
            this.StartMertzBtn.UseVisualStyleBackColor = true;
            this.StartMertzBtn.Click += new System.EventHandler(this.StartMertzBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 279);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.TabsContainer);
            this.panelLeft.Controls.Add(this.OpenOrderFileBtn);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.OrderFileLabel);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(406, 273);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tbLog);
            this.panelRight.Controls.Add(this.pbProgress);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(415, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(407, 273);
            this.panelRight.TabIndex = 1;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(3, 25);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(401, 245);
            this.tbLog.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(3, 3);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(401, 20);
            this.pbProgress.TabIndex = 0;
            // 
            // WB_Mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 303);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "WB_Mixer";
            this.Text = "WB Миксер v2.1";
            this.TabsContainer.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.tabUno.ResumeLayout(false);
            this.tabUno.PerformLayout();
            this.tabMertz.ResumeLayout(false);
            this.tabMertz.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button OpenOrderFileBtn;
        private Label OrderFileLabel;
        private Label label1;
        private TabControl TabsContainer;

        // Main Tab
        private TabPage MainTab;
        private Label label3;
        private Button OpenSrcFileBtn;
        private Label SrcFileLabel;
        private Button StartMainBtn;

        // Tab Uno
        private TabPage tabUno;
        private Label label4;
        private Button OpenUnoFileBtn;
        private Label UnoFileLabel;
        private Button StartUnoBtn;

        // Tab Mertz
        private TabPage tabMertz;
        private Label label5;
        private Button OpenMertzFileBtn;
        private Label MertzFileLabel;
        private Button StartMertzBtn;
        private Label label2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLeft;
        private Panel panelRight;
        private TextBox tbLog;
        private ProgressBar pbProgress;
    }
}