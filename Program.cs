using System;

namespace degreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int strterNumber = 2;
            int finalnumber = strterNumber;
            int degree = 1;
            int value = random.Next(2, 100);
            bool isOpen = true;

            Console.WriteLine("Случайное число " + value);

            while (isOpen)
            {
                if (value < finalnumber)
                {
                    isOpen = false;
                }
                else
                {
                    finalnumber *= strterNumber;
                    degree++;
                }
            }

            Console.WriteLine($"Для числа {value} будет {strterNumber} в степени {degree}, то есть {finalnumber}. {value} < {finalnumber}");
            Console.ReadKey();
        }
    }
}
