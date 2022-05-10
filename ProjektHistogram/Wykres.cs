using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektHistogram
{
    public partial class Wykres : Form
    {
        public static Wykres instance;
        public Chart wykres;
        public string filePath;
        public Wykres()
        {
            InitializeComponent();
            instance = this;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            filePath = "";           
        }
        private void chart1_Click(object sender, EventArgs e)
        {

            //Program.gradeCount(Histogram.instance.grades);
        }
        private void Wykres_Load(object sender, EventArgs e)
        {
            //Dodawanie ocen do wykresu
            int[] chart = Program.gradeCount(Histogram.instance.grades);
            for(int i = 0; i < chart.Length; i++)                          
                WykresOcen.Series["Grades"].Points.AddXY(i, chart[i]);                
        }

        private void saveButtonTip_Popup(object sender, PopupEventArgs e)
        {
            saveButtonTip = new ToolTip();
            saveButtonTip.SetToolTip(saveButton, "Kliknij aby zapisać dane do pliku tekstowego.");
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            giveName fileNamePopUp = new giveName();
            fileNamePopUp.ShowDialog();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {         
            //Dodawanie nowego pliku tekstowego z oceną do wykresu
            DialogResult dr = openFileDialog2.ShowDialog();
            if (dr == DialogResult.OK) filePath = openFileDialog2.FileName;
            else filePath = "";
            Histogram.instance.paths += filePath;
            fileNameText.Text = filePath;
        }
        private void fileNameText2_Click(object sender, EventArgs e)
        {

        }

        private void fileNameText_Click(object sender, EventArgs e)
        {

        }

        private void selectFileChart_Click(object sender, EventArgs e)
        {
            //Funkcja selectFile z histogramu
            //Musi sprawdzić czy dany plik nie został już dodany i czy zawiera ocenę i jaką.
            //Może dodać jedną funkcę do klasy Program i się do niej odwoływać?
        }
    }
}
