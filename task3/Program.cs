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
            bool state1;
            bool state2;
            for (num = 10; num < 100000; num++)
            {
                state1 = false;
                sum = 0;
                temp = num;
                int last = temp % 10;
                while (temp > 0)
                {
                    if (temp % 10 != last)
                    {
                        state1 = true;
                        break;
                    }
                    temp /= 10;
                   }
                   if (state1 == false)
                   {
                    state2 = false;
                    sum = 0;
                    temp = num;
                    while (temp > 0)
                    {
                        sum = sum + temp % 10;
                        temp /= 10;
                        if (temp % 10 == 5)
                        {
                            state2 = true;
                            break;
                        }
                    }
                    if (state2 == false)
                    {
                        if (sum > 5)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
        }
    }
}
            
        
    




                    