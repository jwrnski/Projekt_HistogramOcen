namespace ProjektHistogram
{
    partial class aboutApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutApp));
            this.aboutAppLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutAppLabel
            // 
            this.aboutAppLabel.AutoSize = true;
            this.aboutAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutAppLabel.Location = new System.Drawing.Point(12, 9);
            this.aboutAppLabel.Name = "aboutAppLabel";
            this.aboutAppLabel.Size = new System.Drawing.Size(512, 220);
            this.aboutAppLabel.TabIndex = 0;
            this.aboutAppLabel.Text = resources.GetString("aboutAppLabel.Text");
            // 
            // aboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 251);
            this.Controls.Add(this.aboutAppLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutApp";
            this.Text = "O aplikacji";
            this.Load += new System.EventHandler(this.aboutApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutAppLabel;
    }
}