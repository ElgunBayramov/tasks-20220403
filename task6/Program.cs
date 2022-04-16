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
            int newEded = 0;
            int qaliq;
            int counter = 0;
            while (eded > 0)
            {
                qaliq = eded % 10;
                if (qaliq != 5 && qaliq != 7)
                {
                    newEded = newEded + (int)(eded % 10 * Math.Pow(10, counter));
                    counter++;
                }
                eded /= 10;
            }
            int first = (int)(newEded / Math.Pow(10, counter - 1));
            int last = newEded % 10;

            eded = last * (int)Math.Pow(10, counter - 1) + first + (((int)(newEded % Math.Pow(10, counter - 1)) / 10) * 10);
            Console.WriteLine(eded);



        }
    }
}
