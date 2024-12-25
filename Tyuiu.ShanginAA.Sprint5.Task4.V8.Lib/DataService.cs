﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShanginAA.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx.Replace(".", ","));
            double res = Math.Round((Math.Pow(x, 2) / Math.Sin(x)) + 3, 3);
            return res;
        }
    }
}
