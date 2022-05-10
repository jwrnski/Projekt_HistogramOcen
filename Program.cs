using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace ProjektHistogram
{
    public class Resources
    {
        public int[] gradeInt;
    }
    internal class Program
    {
        //public string filePath, paths, grades, text;
        //public string[] path;
        //Boolean isThere = false, noGrade = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Histogram());
        }
        
        public static int[] gradeCount(string grades)
        {          
            //Liczenie ocen 
            int n=0;
            if (grades != null) n = grades.Length;
            else MessageBox.Show("Brak ocen. Załaduj plik z ocenami.");
            string grade="", gradesNum="";           
            int count, size = 0;  
            int[] gradeInt = new int[n];           
            //Parsowanie łańcucha z ocenami na tablicę int
            for(int i=0; i<n; i++)
            {
                gradeInt[i] = int.Parse(grades[i].ToString());
            }              
            int max = gradeInt.Max();
            //Zliczanie ocen
            while (n > 0)
            {
                count = 0;
                size++;
                for (int i = 0; i < n; i++)
                    if (grades[0] == grades[i]) count++;
                grade += grades[0];
                gradesNum += count;
                grades = grades.Replace(grades[0].ToString(), string.Empty);
                n = grades.Length;
            }
            //Dodawanie zliczonych ocen do tablicy
            //Indeks - ocena
            //Wartość - ilość ocen
            int[] gradeAmount = new int[max + 1];
            int j = grade.Length;
            for (int i = 0; i < j; i++)
            {                
                int val = int.Parse(grade[i].ToString());
                int amt = int.Parse(gradesNum[i].ToString());
                gradeAmount[val] = amt;
            }
            return gradeAmount;                                          
        }   
        //public static string fileCheck(string filePath)
        //{
        //    string paths="", grades="", text="";
        //    string[] path;
        //    Boolean isThere = false, noGrade = true;
        //    //Zatwierdzenie pliku tekstowego
        //    //Sprawdzenie czy wybrano plik
        //    if (filePath == "")
        //    {
        //        MessageBox.Show("Nie wybrano żadnego pliku.");
        //        return null;
        //    }
        //    //Sprawdzenie czy wybrany plik nie został już dodany
        //    if (paths != null)
        //    {
        //        path = paths.Split(' ');
        //        for (int i = 0; i < path.Length; i++)
        //            if (path[i] == filePath)
        //            {
        //                MessageBox.Show("Podany plik został już dodany!");
        //                isThere = true;
        //                filePath = "";
        //                return null;
        //            }
        //    }
        //    //Znajodawnie oceny z pliku tekstowego
        //    if (filePath != "")
        //    {
        //        StreamReader sr = new StreamReader(filePath);
        //        text = sr.ReadLine();
        //        bool containsInt = text.Any(char.IsDigit);
        //        if (containsInt)
        //        {
        //            for (int i = 0; i < text.Length; i++)
        //                if (char.IsDigit(text[i])) // && (int)text[i] > 5)
        //                    grades += text[i].ToString();
        //            noGrade = false;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nie wykryto oceny!");
        //            filePath = "";
        //            noGrade = true;
        //            return null;
        //        }
        //    }
        //    else MessageBox.Show("Należy dodać plik z oceną!");
        //    if (!isThere && !noGrade) paths += filePath + " ";
        //    //Histogram.instance.fileNameLabel.ResetText();
        //    filePath = "";
        //    return grades;
        //}
    }  
}
