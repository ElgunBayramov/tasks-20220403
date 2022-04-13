using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            // hem polindrom olsun,
            // hem ededin reqemleri daxilinde 3 olmasin
            // hem ededin reqemleri cemi 10 dan boyuk olsun
            int numbers;
            int sum;
            int temp;
            bool state;
            for (numbers = 10; numbers < 1000; numbers++)
            {
                state = false;
                sum = 0;
                temp = numbers;
                while (temp > 0)
                {
                    sum = sum + (temp % 10);
                    temp = temp / 10;
                    if (temp % 10 == 3)
                    {
                        state = true;
                        break;
                    }
                }
                if (state == false)
                {
                    if (sum > 10)
                    {
                        if (numbers < 100 && numbers % 10 == numbers / 10)
                        {
                            Console.WriteLine(numbers);
                        }
                        if (numbers > 100 && numbers % 10 == numbers / 100)
                        {
                            Console.WriteLine(numbers);
                        }
                    }
                }
            }
        }
    }
}

