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
            int numbers;
            int sum;
            int temp;
            for (numbers = 1; numbers <= 1000; numbers++)
            {
                sum = 0;
                temp = numbers;
                if (temp % 2 == 0)
                {
                    while (temp > 0)
                    {   
                        sum = sum + temp % 10;
                        temp /= 10;
                    }
                   
                    if (sum > 5 && sum < 7 && numbers % 100 == 0)
                    {
                        Console.WriteLine($"1-dən 1000-ə qədər cüt ədədlərin içərisində rəqəmləri cəmi 5 ilə 7 arasında olan ən böyük ədəd: {numbers}");
                    }
                }
            }
        }
    }
}
