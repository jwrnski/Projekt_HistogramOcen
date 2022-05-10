namespace ProjektHistogram
{
    partial class Histogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip fileTip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histogram));
            this.chartButton = new System.Windows.Forms.Button();
            this.chartTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFile = new System.Windows.Forms.Button();
            this.fileNameText = new System.Windows.Forms.Label();
            this.selectTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printFiles = new System.Windows.Forms.Button();
            this.aboutAppLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            fileTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // fileTip
            // 
            fileTip.AutoPopDelay = 5000;
            fileTip.InitialDelay = 50;
            fileTip.ReshowDelay = 50;
            fileTip.ShowAlways = true;
            fileTip.Popup += new System.Windows.Forms.PopupEventHandler(this.fileTip_Popup);
            // 
            // chartButton
            // 
            this.chartButton.Image = ((System.Drawing.Image)(resources.GetObject("chartButton.Image")));
            this.chartButton.Location = new System.Drawing.Point(307, 12);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(374, 331);
            this.chartButton.TabIndex = 1;
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chart_button_Click);
            this.chartButton.MouseHover += new System.EventHandler(this.chartTip_MouseHover);
            // 
            // chartTip
            // 
            this.chartTip.AutoPopDelay = 5000;
            this.chartTip.InitialDelay = 50;
            this.chartTip.ReshowDelay = 50;
            this.chartTip.ShowAlways = true;
            this.chartTip.Popup += new System.Windows.Forms.PopupEventHandler(this.chartTip_Popup);
            // 
            // fileButton
            // 
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.Location = new System.Drawing.Point(12, 12);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(277, 327);
            this.fileButton.TabIndex = 2;
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            this.fileButton.MouseHover += new System.EventHandler(this.fileTip_MouseHover);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(26, 395);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 16);
            this.fileName.TabIndex = 3;
            this.fileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(12, 417);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(94, 32);
            this.selectFile.TabIndex = 4;
            this.selectFile.Text = "Zatwierdź";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            this.selectFile.MouseHover += new System.EventHandler(this.selectTip_MouseHover);
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameText.Location = new System.Drawing.Point(12, 354);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(98, 18);
            this.fileNameText.TabIndex = 6;
            this.fileNameText.Text = "Wybrano plik:";
            this.fileNameText.Click += new System.EventHandler(this.fileNameText_Click);
            // 
            // selectTip
            // 
            this.selectTip.AutoPopDelay = 5000;
            this.selectTip.InitialDelay = 50;
            this.selectTip.ReshowDelay = 50;
            this.selectTip.Popup += new System.Windows.Forms.PopupEventHandler(this.selectTip_Popup);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameLabel.Location = new System.Drawing.Point(12, 379);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 24);
            this.fileNameLabel.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 455);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 115);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printFiles
            // 
            this.printFiles.Location = new System.Drawing.Point(163, 417);
            this.printFiles.Name = "printFiles";
            this.printFiles.Size = new System.Drawing.Size(126, 32);
            this.printFiles.TabIndex = 9;
            this.printFiles.Text = "Drukuj";
            this.printFiles.UseVisualStyleBackColor = true;
            this.printFiles.Click += new System.EventHandler(this.printFiles_Click);
            // 
            // aboutAppLabel
            // 
            this.aboutAppLabel.AutoSize = true;
            this.aboutAppLabel.Location = new System.Drawing.Point(591, 610);
            this.aboutAppLabel.Name = "aboutAppLabel";
            this.aboutAppLabel.Size = new System.Drawing.Size(70, 16);
            this.aboutAppLabel.TabIndex = 10;
            this.aboutAppLabel.Text = "O aplikacji";
            this.aboutAppLabel.Click += new System.EventHandler(this.aboutAppLabel_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 645);
            this.Controls.Add(this.aboutAppLabel);
            this.Controls.Add(this.printFiles);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.chartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Histogram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Histogram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.ToolTip chartTip;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Label fileNameText;
        private System.Windows.Forms.ToolTip selectTip;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printFiles;
        private System.Windows.Forms.Label aboutAppLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

