using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1000 qeder CUT ederlerin icerisinde
            // reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int eded = 0;
            int cem = 0;
            for (int i = 2; i <= 1000; i++)
            {
                int eded2 = i;
                if (i % 2 == 0)
                {
                    Console.WriteLine($"1-dən 1000-ə qədər olan cüt ədədlər: {eded2}");
                    while (eded2 != 0)
                    {
                        cem += eded2 % 10;
                        eded2 /= 10;
                    }
                    if (cem == 5 || cem==6 || cem == 7) 
                    {
                        eded = i;
                    }
                }
            cem = 0;
            }
            Console.WriteLine($"rəqəmləri cəmi 5 və 7 arasında olan ən böyük ədəd: {eded}");
        }
    }
}
