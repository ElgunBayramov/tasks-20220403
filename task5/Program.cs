﻿using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Her hansi bir eded daxil et.
            // Eger eded polindromdursa o zaman bu ededin evveline ve axirin 1 reqemini artir ve cap et.
            // Eks halda ededin ozunu cap et.   polindrom eded:  123321; 12321--guzgu effekti
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hər hansı bir ədəd daxil edin: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp, r;
            int a = 1;
            double newnum;
            int sum = 0;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
            {
                newnum = double.Parse(a.ToString() + temp.ToString() + a.ToString());
                Console.Write($"ədədin axırına və sonuna 1 rəqəmi artırdıqda alınan ədəd: {newnum}");
            }
            else
                Console.Write(temp);
        }
    }
}
