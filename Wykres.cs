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
using System.IO;
namespace ProjektHistogram
{
    public partial class Wykres : Form
    {
        public static Wykres instance;
        public Chart wykres;       
        public string filePath, paths, grades, text;
        string[] path;
        Boolean isThere = false, noGrade = true;
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
            //this.WykresOcen.
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
            //Zatwierdzenie pliku tekstowego
            //Sprawdzenie czy wybrano plik
            if (filePath == "")
            {
                MessageBox.Show("Nie wybrano żadnego pliku.");
                return;
            }
            //Sprawdzenie czy wybrany plik nie został już dodany
            if (paths != null)
            {
                path = paths.Split(' ');
                for (int i = 0; i < path.Length; i++)
                    if (path[i] == filePath)
                    {
                        MessageBox.Show("Podany plik został już dodany!");
                        isThere = true;
                        filePath = "";
                        return;
                    }
            }
            //Znajodawnie oceny z pliku tekstowego
            if (filePath != "")
            {
                StreamReader sr = new StreamReader(filePath);
                text = sr.ReadLine();
                bool containsInt = text.Any(char.IsDigit);
                if (containsInt)
                {
                    for (int i = 0; i < text.Length; i++)
                        if (char.IsDigit(text[i])) // && (int)text[i] > 5)
                            grades += text[i].ToString();
                    noGrade = false;
                }
                else
                {
                    MessageBox.Show("Nie wykryto oceny!");
                    filePath = "";
                    noGrade = true;
                    return;
                }
            }
            else MessageBox.Show("Należy dodać plik z oceną!");
            if (!isThere && !noGrade) paths += filePath + " ";
            fileNameText.ResetText();
            filePath = "";

        }

        private void fileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
