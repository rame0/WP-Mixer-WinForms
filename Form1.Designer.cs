namespace WP_Mixer_WinForms
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.OpenSrcFileBtn = new System.Windows.Forms.Button();
            this.SrcFileLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenOrderFileBtn = new System.Windows.Forms.Button();
            this.OrderFileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.OpenSrcFileBtn);
            this.groupBox1.Controls.Add(this.SrcFileLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OpenOrderFileBtn);
            this.groupBox1.Controls.Add(this.OrderFileLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите файлы";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartBtn.Enabled = false;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(8, 171);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(382, 35);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Начать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // OpenSrcFileBtn
            // 
            this.OpenSrcFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenSrcFileBtn.Location = new System.Drawing.Point(8, 113);
            this.OpenSrcFileBtn.Name = "OpenSrcFileBtn";
            this.OpenSrcFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenSrcFileBtn.TabIndex = 5;
            this.OpenSrcFileBtn.Text = "Открыть файл";
            this.OpenSrcFileBtn.UseVisualStyleBackColor = true;
            this.OpenSrcFileBtn.Click += new System.EventHandler(this.OpenSrcFileBtn_Click);
            // 
            // SrcFileLabel
            // 
            this.SrcFileLabel.AutoSize = true;
            this.SrcFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SrcFileLabel.Location = new System.Drawing.Point(89, 117);
            this.SrcFileLabel.Name = "SrcFileLabel";
            this.SrcFileLabel.Size = new System.Drawing.Size(102, 15);
            this.SrcFileLabel.TabIndex = 4;
            this.SrcFileLabel.Text = "Выберите файл...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите файл поставщиков";
            // 
            // OpenOrderFileBtn
            // 
            this.OpenOrderFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenOrderFileBtn.Location = new System.Drawing.Point(8, 47);
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
            this.OrderFileLabel.Location = new System.Drawing.Point(89, 51);
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
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл Заказа с WB";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbLog);
            this.groupBox2.Controls.Add(this.pbProgress);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(6, 51);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(446, 174);
            this.tbLog.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(6, 21);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(446, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(870, 237);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 261);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button OpenOrderFileBtn;
        private Label OrderFileLabel;
        private Label label1;
        private GroupBox groupBox2;
        private SplitContainer splitContainer1;
        private Button OpenSrcFileBtn;
        private Label SrcFileLabel;
        private Label label3;
        private Button StartBtn;
        private TextBox tbLog;
        private ProgressBar pbProgress;
    }
}