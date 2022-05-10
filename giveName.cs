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
    public partial class giveName : Form
    {
        public giveName()
        {
            InitializeComponent();
        }

        private void giveName_Load(object sender, EventArgs e)
        {

        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

            //string name = fileName.Text;
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if (!name.EndsWith(".txt")) name += ".txt";
            //String filePath = Path.Combine(path, name);          
            //using (StreamWriter text = File.CreateText(filePath))
            //{
            //    text.WriteLine();
            //}
        }       
        private void createButton_Click(object sender, EventArgs e)
        {
            //Tworzenie pliku tekstowego z ocenami i ich ilością
            bool closeForm = false;
            string date = DateTime.Now.ToString();
            int[] dataToFile = Program.gradeCount(Histogram.instance.grades);
            int L = dataToFile.Length;
            string name = fileName.Text;
            if (name == "") MessageBox.Show("Podaj nazwę pliku!");
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!name.EndsWith(".txt")) name += ".txt";
                String filePath = Path.Combine(path, name);
                using (StreamWriter text = File.CreateText(filePath))
                {
                    text.WriteLine("####################################\n" +
                        $"Histogram ocen   {date}\n" +
                        "####################################");
                    text.WriteLine("\nOcena   Ilość");
                    for (int i = 0; i < L; i++)                    
                        if (dataToFile[i] != 0)
                            text.WriteLine("  " + i.ToString() + "       " + dataToFile[i].ToString());      
                    closeForm = true;
                }
            }
            if(closeForm) this.Close();
            //stan = true;
            //Application.Exit();
            //giveName_FormClosing(true, stan);
        }
        //private void giveName_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = stan;
        //    if(stan) e.Cancel = true;           
        //}
    }
}
