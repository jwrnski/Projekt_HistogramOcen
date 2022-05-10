namespace ProjektHistogram
{
    partial class Wykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wykres));
            this.WykresOcen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fileNameText = new System.Windows.Forms.Label();
            this.selectFileChart = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WykresOcen)).BeginInit();
            this.SuspendLayout();
            // 
            // WykresOcen
            // 
            this.WykresOcen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.WykresOcen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WykresOcen.Legends.Add(legend1);
            this.WykresOcen.Location = new System.Drawing.Point(12, 12);
            this.WykresOcen.MaximumSize = new System.Drawing.Size(968, 596);
            this.WykresOcen.Name = "WykresOcen";
            this.WykresOcen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Grades";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ToolTip = "Histogram ocen.";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.WykresOcen.Series.Add(series1);
            this.WykresOcen.Size = new System.Drawing.Size(872, 596);
            this.WykresOcen.TabIndex = 0;
            this.WykresOcen.Text = "chart";
            this.WykresOcen.Click += new System.EventHandler(this.chart1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(993, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 52);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButtonTip.SetToolTip(this.saveButton, "Kliknij aby zapisać dane do pliku tekstowego.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveButtonTip
            // 
            this.saveButtonTip.Popup += new System.Windows.Forms.PopupEventHandler(this.saveButtonTip_Popup);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameText.Location = new System.Drawing.Point(890, 232);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(98, 18);
            this.fileNameText.TabIndex = 7;
            this.fileNameText.Text = "Wybrano plik:";
            this.fileNameText.Click += new System.EventHandler(this.fileNameText_Click);
            // 
            // selectFileChart
            // 
            this.selectFileChart.Location = new System.Drawing.Point(993, 305);
            this.selectFileChart.Name = "selectFileChart";
            this.selectFileChart.Size = new System.Drawing.Size(153, 48);
            this.selectFileChart.TabIndex = 8;
            this.selectFileChart.Text = "Zatwierdź";
            this.selectFileChart.UseVisualStyleBackColor = true;
            this.selectFileChart.Click += new System.EventHandler(this.selectFileChart_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(993, 156);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(153, 55);
            this.fileButton.TabIndex = 9;
            this.fileButton.Text = "Dodaj nowy plik";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 625);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.selectFileChart);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.WykresOcen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wykres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Wykres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WykresOcen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WykresOcen;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolTip saveButtonTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label fileNameText;
        private System.Windows.Forms.Button selectFileChart;
        private System.Windows.Forms.Button fileButton;
    }
}