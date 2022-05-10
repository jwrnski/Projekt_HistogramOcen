namespace ProjektHistogram
{
    partial class giveName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giveName));
            this.fileName = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.fileCreatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(12, 38);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(395, 22);
            this.fileName.TabIndex = 0;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(144, 80);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(112, 34);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Utwórz plik";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // fileCreatedLabel
            // 
            this.fileCreatedLabel.AutoSize = true;
            this.fileCreatedLabel.Location = new System.Drawing.Point(12, 134);
            this.fileCreatedLabel.Name = "fileCreatedLabel";
            this.fileCreatedLabel.Size = new System.Drawing.Size(215, 16);
            this.fileCreatedLabel.TabIndex = 2;
            this.fileCreatedLabel.Text = "Plik zostanie utworzony na pulpicie.";
            // 
            // giveName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 162);
            this.Controls.Add(this.fileCreatedLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.fileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giveName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaj nazwę pliku";
            this.Load += new System.EventHandler(this.giveName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label fileCreatedLabel;
    }
}