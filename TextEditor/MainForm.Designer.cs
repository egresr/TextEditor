namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFont = new System.Windows.Forms.NumericUpDown();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File auswählen";
            this.label1.UseWaitCursor = true;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(29, 74);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(959, 31);
            this.textBoxFilePath.TabIndex = 1;
            this.textBoxFilePath.UseWaitCursor = true;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFile.Location = new System.Drawing.Point(1005, 74);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(150, 40);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Auswahl";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.UseWaitCursor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(1161, 74);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(150, 40);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Öffnen";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Schriftgröße";
            this.label2.UseWaitCursor = true;
            // 
            // numericUpDownFont
            // 
            this.numericUpDownFont.Location = new System.Drawing.Point(175, 149);
            this.numericUpDownFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDownFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownFont.Name = "numericUpDownFont";
            this.numericUpDownFont.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownFont.TabIndex = 5;
            this.numericUpDownFont.UseWaitCursor = true;
            this.numericUpDownFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Location = new System.Drawing.Point(29, 256);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContent.Size = new System.Drawing.Size(1282, 644);
            this.textBoxContent.TabIndex = 6;
            this.textBoxContent.UseWaitCursor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Location = new System.Drawing.Point(1161, 922);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(150, 40);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Speichern";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.UseWaitCursor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 984);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1339, 37);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(201, 32);
            this.toolStripStatusLabel1.Text = "Zeichenanzahl :";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(45, 32);
            this.toolStripStatusLabelCount.Text = "---";
            // 
            // toolStripStatusLabelSymbolCount
            // 
            this.toolStripStatusLabelSymbolCount.Name = "toolStripStatusLabelSymbolCount";
            this.toolStripStatusLabelSymbolCount.Size = new System.Drawing.Size(0, 32);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(712, 155);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(276, 55);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "TEST";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 1021);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.numericUpDownFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Texteditor";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFont;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSymbolCount;
        private System.Windows.Forms.Button buttonTest;
    }
}

