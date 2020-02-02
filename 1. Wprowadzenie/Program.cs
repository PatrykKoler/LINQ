using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wprowadzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sciezka = @"C:\windows";
            PokazPlikiBezLinqu(sciezka);
        }

        private static void PokazPlikiBezLinqu(string sciezka)
        {
            DirectoryInfo katalog = new DirectoryInfo(sciezka);
            FileInfo[] pliki = katalog.GetFiles();

            Array.Sort(pliki, new FileInfoComparer());
            for (int i = 0; i < 5; i++ )
            {
                FileInfo plik = pliki[i];
                Console.WriteLine($"{plik.Name, -20} : {plik.Length, 15:N0}");
            }
        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }

}
