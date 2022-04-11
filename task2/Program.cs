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
            int sum1;
            int sum2;
            for (numbers = 10; numbers < 1000; numbers++)
            {
                if (numbers < 100)
                {
                    sum1 = numbers % 10 + numbers / 10;
                    if (numbers % 10 == numbers / 10 && numbers != 33 && sum1>10)
                    {
                        Console.WriteLine(numbers);
                    }
                }
                    if (numbers > 100)
                    {
                    sum2 = numbers % 10 + numbers / 10 % 10 + numbers / 100;
                    if (numbers % 10 == numbers / 100 && numbers%10!=3 && numbers%100!=3 && numbers%100/10!=3 && sum2>10)
                        {
                            Console.WriteLine(numbers);
                        }
                    }
                }
            }
        }
    }

