using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace Lib10
{
    public class Massiv
    {
        public static void Radikal(int[] mas, out string s1)
        {
            int i;
            double rez = 0;
            s1 = " ";
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    rez = Math.Sqrt(mas[i]);
                    s1 = s1 + rez.ToString() + ";\n";// заполняем строку для вывода результатов вычислений
                }
            }
        }

    }
}

    

