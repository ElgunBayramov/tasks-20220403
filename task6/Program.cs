using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Her hansi bir eded daxil et.
            //Bu ededin daxilinden 5 ve 7 reqemlerini legv et.
            //Neticenin I ve Sonuncu reqemlerini deyishib cap et.
            //Alinan cavabin icerisinde nece dene tek reqem oldugunu yaz.

            Console.Write("Eded daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());
            int eded1 = 0;
            int qaliq;
            int counter = 0;
            while (eded > 0)
            {
                qaliq = eded % 10;
                if (qaliq != 5 && qaliq != 7)
                {
                    eded1 = eded1 + (int)(eded % 10 * Math.Pow(10, counter));
                    counter++;
                }
                eded /= 10;
         
            }
            Console.WriteLine($"ededin daxilinden butun 5 ve 7 reqemlerini sildikde alinan eded: {eded1}");
            int first = (int)(eded1 / Math.Pow(10, counter - 1));
            int last = eded1 % 10;

            eded = last * (int)Math.Pow(10, counter - 1) + first + (((int)(eded1 % Math.Pow(10, counter - 1)) / 10) * 10);
            Console.WriteLine($"{eded1} ededinin birinci ve sonuncu reqemlerinin yerini deyishdikde alinan eded: {eded}");
            int countOdd = 0;
            string eded2 = Convert.ToString(eded1);
            for (int i = 0; i < eded2.Length; i++)
            {
                if ((int.Parse(eded2[i].ToString()) % 2) != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine($"{eded} ededinde tek reqemlerin sayi: {countOdd}");
        }
    }
}
