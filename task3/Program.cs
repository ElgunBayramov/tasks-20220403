using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 100000 qeder ederlerin icerisinden ele ededleri cap etki:
            // hem butun reqemleri eyni olsun,
            // hem reqemleri cemi 5 den boyuk olsun
            // hem reqemleri arasinda 5 reqemi olmasin
            int num;
            int temp;
            int sum;
            bool state;
            for (num = 10; num < 100000; num++)
            {
                state = false;
                sum = 0;
                temp = num;
                while (temp > 0)
                {
                    sum = sum + temp % 10;
                    temp /= 10;
                    if (temp % 10 == 5)
                    {
                        state = true;
                        break;
                    }

                }
                if (state == false)
                {
                    if (sum > 5)
                    {
                        if (num % 10 == num / 10)
                        {
                            Console.WriteLine(num);
                        }
                        if (num % 10 == num / 100 && num % 10 == num % 100 / 10)
                        {
                            Console.WriteLine(num);
                        }
                        if (num % 10 == num / 1000 && num % 10 == num / 100 % 10 && num % 10 == num % 100 / 10)
                        {
                            Console.WriteLine(num);
                        }
                        if (num % 10 == num / 10000 && num % 10 == num / 1000 % 10 && num % 10 == num % 1000 / 100 && num % 10 == num % 1000 / 10 % 10)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
        }
    }
}



                    