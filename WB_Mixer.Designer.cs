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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.TabsContainer.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabUno.SuspendLayout();
            this.tabMertz.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenOrderFileBtn
            // 
            this.OpenOrderFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenOrderFileBtn.Location = new System.Drawing.Point(3, 24);
            this.OpenOrderFileBtn.Name = "OpenOrderFileBtn";
            this.OpenOrderFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenOrderFileBtn.TabIndex = 2;
            this.OpenOrderFileBtn.Text = "Открыть файл";
            this.OpenOrderFileBtn.UseVisualStyleBackColor = true;
            this.OpenOrderFileBtn.Click += new System.EventHandler(this.OpenOrderFileBtn_Click);
            // 
            // OrderFileLabel
            // 
            this.OrderFileLabel.AutoSize = true;
            this.OrderFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderFileLabel.Location = new System.Drawing.Point(84, 28);
            this.OrderFileLabel.Name = "OrderFileLabel";
            this.OrderFileLabel.Size = new System.Drawing.Size(102, 15);
            this.OrderFileLabel.TabIndex = 1;
            this.OrderFileLabel.Text = "Выберите файл...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл Заказа с WB";
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(0, 27);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(445, 311);
            this.tbLog.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(0, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(445, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.OrderFileLabel);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.OpenOrderFileBtn);
            this.splitContainer.Panel1.Controls.Add(this.TabsContainer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pbProgress);
            this.splitContainer.Panel2.Controls.Add(this.tbLog);
            this.splitContainer.Size = new System.Drawing.Size(1041, 339);
            this.splitContainer.SplitterDistance = 592;
            this.splitContainer.TabIndex = 2;
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
            this.TabsContainer.Location = new System.Drawing.Point(0, 54);
            this.TabsContainer.Name = "TabsContainer";
            this.TabsContainer.SelectedIndex = 0;
            this.TabsContainer.Size = new System.Drawing.Size(593, 285);
            this.TabsContainer.TabIndex = 1;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.label3);
            this.MainTab.Controls.Add(this.SrcFileLabel);
            this.MainTab.Controls.Add(this.OpenSrcFileBtn);
            this.MainTab.Controls.Add(this.StartMainBtn);
            this.MainTab.Location = new System.Drawing.Point(4, 24);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(585, 257);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Все посьавщики";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите файл поставщиков";
            // 
            // SrcFileLabel
            // 
            this.SrcFileLabel.AutoSize = true;
            this.SrcFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SrcFileLabel.Location = new System.Drawing.Point(89, 31);
            this.SrcFileLabel.Name = "SrcFileLabel";
            this.SrcFileLabel.Size = new System.Drawing.Size(102, 15);
            this.SrcFileLabel.TabIndex = 4;
            this.SrcFileLabel.Text = "Выберите файл...";
            // 
            // OpenSrcFileBtn
            // 
            this.OpenSrcFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenSrcFileBtn.Location = new System.Drawing.Point(8, 27);
            this.OpenSrcFileBtn.Name = "OpenSrcFileBtn";
            this.OpenSrcFileBtn.Size = new System.Drawing.Size(75, 23);
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
            this.StartMainBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartMainBtn.Location = new System.Drawing.Point(6, 97);
            this.StartMainBtn.Name = "StartMainBtn";
            this.StartMainBtn.Size = new System.Drawing.Size(573, 35);
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
            this.tabUno.Location = new System.Drawing.Point(4, 24);
            this.tabUno.Name = "tabUno";
            this.tabUno.Padding = new System.Windows.Forms.Padding(3);
            this.tabUno.Size = new System.Drawing.Size(585, 257);
            this.tabUno.TabIndex = 1;
            this.tabUno.Text = "Uno";
            this.tabUno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "* В итоговом файле колонка \"Артикулы WB\"  будет просто скрыта, а не удалена.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите бланк Uno";
            // 
            // UnoFileLabel
            // 
            this.UnoFileLabel.AutoSize = true;
            this.UnoFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnoFileLabel.Location = new System.Drawing.Point(89, 31);
            this.UnoFileLabel.Name = "UnoFileLabel";
            this.UnoFileLabel.Size = new System.Drawing.Size(102, 15);
            this.UnoFileLabel.TabIndex = 4;
            this.UnoFileLabel.Text = "Выберите файл...";
            // 
            // OpenUnoFileBtn
            // 
            this.OpenUnoFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenUnoFileBtn.Location = new System.Drawing.Point(8, 27);
            this.OpenUnoFileBtn.Name = "OpenUnoFileBtn";
            this.OpenUnoFileBtn.Size = new System.Drawing.Size(75, 23);
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
            this.StartUnoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartUnoBtn.Location = new System.Drawing.Point(6, 97);
            this.StartUnoBtn.Name = "StartUnoBtn";
            this.StartUnoBtn.Size = new System.Drawing.Size(573, 35);
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
            this.tabMertz.Location = new System.Drawing.Point(4, 24);
            this.tabMertz.Name = "tabMertz";
            this.tabMertz.Padding = new System.Windows.Forms.Padding(3);
            this.tabMertz.Size = new System.Drawing.Size(585, 257);
            this.tabMertz.TabIndex = 2;
            this.tabMertz.Text = "Mertz";
            this.tabMertz.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(8, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(571, 54);
            this.label6.TabIndex = 8;
            this.label6.Text = "* В итоговом файле колонка \"Артикулы WB\"  будет просто скрыта, а не удалена.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выберите бланк Mertz";
            // 
            // MertzFileLabel
            // 
            this.MertzFileLabel.AutoSize = true;
            this.MertzFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MertzFileLabel.Location = new System.Drawing.Point(89, 31);
            this.MertzFileLabel.Name = "MertzFileLabel";
            this.MertzFileLabel.Size = new System.Drawing.Size(102, 15);
            this.MertzFileLabel.TabIndex = 4;
            this.MertzFileLabel.Text = "Выберите файл...";
            // 
            // OpenMertzFileBtn
            // 
            this.OpenMertzFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenMertzFileBtn.Location = new System.Drawing.Point(8, 27);
            this.OpenMertzFileBtn.Name = "OpenMertzFileBtn";
            this.OpenMertzFileBtn.Size = new System.Drawing.Size(75, 23);
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
            this.StartMertzBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartMertzBtn.Location = new System.Drawing.Point(6, 97);
            this.StartMertzBtn.Name = "StartMertzBtn";
            this.StartMertzBtn.Size = new System.Drawing.Size(573, 35);
            this.StartMertzBtn.TabIndex = 6;
            this.StartMertzBtn.Text = "Начать";
            this.StartMertzBtn.UseVisualStyleBackColor = true;
            this.StartMertzBtn.Click += new System.EventHandler(this.StartMertzBtn_Click);
            // 
            // WB_Mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 363);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "WB_Mixer";
            this.Text = "WB Миксер v2";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.TabsContainer.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.tabUno.ResumeLayout(false);
            this.tabUno.PerformLayout();
            this.tabMertz.ResumeLayout(false);
            this.tabMertz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button OpenOrderFileBtn;
        private Label OrderFileLabel;
        private Label label1;
        private SplitContainer splitContainer;
        private TextBox tbLog;
        private ProgressBar pbProgress;
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
    }
}