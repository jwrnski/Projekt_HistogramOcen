using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjektHistogram
{
    
    public partial class Histogram : Form
    {
        public static Histogram instance;
        public string filePath, paths, grades, text;
        string[] path;
        Boolean isThere = false, noGrade = true;
        public RichTextBox rtb;
        public Histogram()
        {
            InitializeComponent();
            filePath = "";
            paths = "";
            instance = this;
            rtb = richTextBox1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void fileButton_Click(object sender, EventArgs e)
        {
            //Otwarcie okna z wyborem pliku
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK) filePath = openFileDialog.FileName;
            else filePath = "";
            fileNameLabel.Text = filePath;
        }
        private void chart_button_Click(object sender, EventArgs e)
        {
            //Otwarcie okna z wykresem
            //Tylko jeśli załadowane są oceny
            if (grades != null)
            {
                //Program.gradeCount(grades);
                Wykres chartPopUp = new Wykres();
                chartPopUp.ShowDialog();  
                Close();
            }
            else MessageBox.Show("Brak ocen. Załaduj plik z ocenami.");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Histogram_Load(object sender, EventArgs e)
        {

        }

        public void selectFile_Click(object sender, EventArgs e)
        {
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
            fileNameLabel.ResetText();
            filePath = "";
        }
        private void fileNameText_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Wybrano plik:");
        }

        private void selectTip_Popup(object sender, PopupEventArgs e)
        {
            ToolTip selectTip = new ToolTip();
            selectTip.SetToolTip(selectFile, "Kliknij aby zatwierdzić dany plik.");
        }
        private void selectTip_MouseHover(object sender, EventArgs e)
        {
            ToolTip selectTip = new ToolTip();
            selectTip.SetToolTip(selectFile, "Kliknij aby zatwierdzić dany plik.");
        }
        private void fileTip_Popup(object sender, PopupEventArgs e)
        {
            ToolTip FileTip = new ToolTip();
            FileTip.SetToolTip(fileButton, "Kliknij aby wybrać plik z komputera.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutAppLabel_Click(object sender, EventArgs e)
        {
            aboutApp aboutApp = new aboutApp();
            aboutApp.ShowDialog();  
        }

        private void fileNameText_Click(object sender, EventArgs e)
        {

        }

        private void printFiles_Click(object sender, EventArgs e)
        {
            
        }

        private void fileTip_MouseHover(object sender, EventArgs e)
        {
            ToolTip FileTip = new ToolTip();
            FileTip.SetToolTip(fileButton, "Kliknij aby wybrać plik z komputera.");
        }
        private void chartTip_Popup(object sender, PopupEventArgs e)
        {
            ToolTip chartTip = new ToolTip();
            chartTip.SetToolTip(chartButton, "Kliknij aby wyświetlić wykres.");
        }
        private void chartTip_MouseHover(object sender, EventArgs e)
        {
            ToolTip chartTip = new ToolTip();
            chartTip.SetToolTip(chartButton, "Kliknij aby wyświetlić wykres.");
        }

    
    }
}
