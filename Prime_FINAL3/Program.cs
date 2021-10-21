using System;

namespace FirstNPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Witaj w programie z liczbami pierwszymi! \nOkreśl ile liczb pierwszych chcesz uzyskać: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oto Twoje liczb pierwsze:");
            int PrimeCount = 0, count, num = 2;

            while (PrimeCount < n)
            {
                count = 0;
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                    if (count >= 2)
                    {
                        break;
                    }
                }
                if (count < 2)
                {
                    PrimeCount++;
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.WriteLine("Naciśnij jakikolwiek klawisz by zakończyć działanie programu");
            Console.ReadKey();
        }
    }
}