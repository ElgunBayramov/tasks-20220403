using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1000 qeder CUT ederlerin icerisinde
            // reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int number=0;
            int sum=0;
            int temp;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 0)
                {                   
                    temp = i;
                    while (temp > 0)
                    {
                        sum = sum + temp % 10;
                        temp /= 10;
                    }

                    if (sum > 5 && sum < 7) 
                    {
                        number = i;
                    }
                }
                sum = 0;
            }
            Console.WriteLine($"1-dən 1000-ə qədər cüt ədədlərin içərisində rəqəmləri cəmi 5 ilə 7 arasında olan ən böyük ədəd: {number}");
        }
    }
}
