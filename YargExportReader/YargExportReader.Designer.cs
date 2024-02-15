namespace YargExportReader
{
    partial class YargExportReader
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
            DlgOpenFile = new OpenFileDialog();
            TxtFile = new TextBox();
            label1 = new Label();
            BtnRead = new Button();
            BtnBrowse = new Button();
            GrdSongs = new DataGridView();
            BtnExportText = new Button();
            BtnExportPdf = new Button();
            DlgSaveTxtFile = new SaveFileDialog();
            DlgSavePdfFile = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)GrdSongs).BeginInit();
            SuspendLayout();
            // 
            // DlgOpenFile
            // 
            DlgOpenFile.DefaultExt = "json";
            DlgOpenFile.Filter = "JSON File|*.json";
            DlgOpenFile.FileOk += DlgOpenFile_FileOk;
            // 
            // TxtFile
            // 
            TxtFile.Location = new Point(74, 12);
            TxtFile.Name = "TxtFile";
            TxtFile.Size = new Size(278, 23);
            TxtFile.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "JSON File";
            // 
            // BtnRead
            // 
            BtnRead.Location = new Point(12, 41);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(421, 33);
            BtnRead.TabIndex = 2;
            BtnRead.Text = "Read";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += BtnRead_Click;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(358, 12);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 3;
            BtnBrowse.Text = "Browse...";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // GrdSongs
            // 
            GrdSongs.AllowUserToAddRows = false;
            GrdSongs.AllowUserToDeleteRows = false;
            GrdSongs.AllowUserToOrderColumns = true;
            GrdSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdSongs.Location = new Point(12, 80);
            GrdSongs.Name = "GrdSongs";
            GrdSongs.ReadOnly = true;
            GrdSongs.Size = new Size(421, 218);
            GrdSongs.TabIndex = 4;
            // 
            // BtnExportText
            // 
            BtnExportText.Location = new Point(12, 304);
            BtnExportText.Name = "BtnExportText";
            BtnExportText.Size = new Size(200, 73);
            BtnExportText.TabIndex = 5;
            BtnExportText.Text = "Export TXT List";
            BtnExportText.UseVisualStyleBackColor = true;
            BtnExportText.Click += BtnExportText_Click;
            // 
            // BtnExportPdf
            // 
            BtnExportPdf.Location = new Point(231, 304);
            BtnExportPdf.Name = "BtnExportPdf";
            BtnExportPdf.Size = new Size(202, 73);
            BtnExportPdf.TabIndex = 5;
            BtnExportPdf.Text = "Export Song Book PDF";
            BtnExportPdf.UseVisualStyleBackColor = true;
            BtnExportPdf.Click += BtnExportPdf_Click;
            // 
            // DlgSaveTxtFile
            // 
            DlgSaveTxtFile.DefaultExt = "txt";
            DlgSaveTxtFile.Filter = "Text File|*.txt";
            DlgSaveTxtFile.FileOk += DlgSaveTxtFile_FileOk;
            // 
            // DlgSavePdfFile
            // 
            DlgSavePdfFile.DefaultExt = "pdf";
            DlgSavePdfFile.Filter = "Pdf File|*.pdf";
            DlgSavePdfFile.FileOk += DlgSavePdfFile_FileOk;
            // 
            // YargExportReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 386);
            Controls.Add(BtnExportPdf);
            Controls.Add(BtnExportText);
            Controls.Add(GrdSongs);
            Controls.Add(BtnBrowse);
            Controls.Add(BtnRead);
            Controls.Add(label1);
            Controls.Add(TxtFile);
            Name = "YargExportReader";
            Text = "Form1";
            Load += YargExportReader_Load;
            ((System.ComponentModel.ISupportInitialize)GrdSongs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog DlgOpenFile;
        private TextBox TxtFile;
        private Label label1;
        private Button BtnRead;
        private Button BtnBrowse;
        private DataGridView GrdSongs;
        private Button BtnExportText;
        private Button BtnExportPdf;
        private SaveFileDialog DlgSaveTxtFile;
        private SaveFileDialog DlgSavePdfFile;
    }
}
