using System;

namespace RecursionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AddNumbers add = new AddNumbers();
            AddDigits addDigits = new AddDigits();
            SpidermanAlgoritmo spidermanAlgoritmo = new SpidermanAlgoritmo();
            PrimeNumber primeNumber = new PrimeNumber();


            // CONSECUTIVE SUM
            Console.WriteLine("The total amount: " + add.addNum(9));
            Console.WriteLine("\n");

            //ADD DIGITS
            Console.WriteLine("The total:  " + addDigits.AddDig(123));
            Console.WriteLine("\n");

            //SPIDERMAN ALGORITMO 
            Console.WriteLine("The total jumps: " + spidermanAlgoritmo.SpiderAlgo (4));
            Console.WriteLine( "\n");

            //PRIME NUMBER

            int number = 60;
            Boolean x = primeNumber.FindPrimeNumber(number, number - 1);

            if (x== true)
            {
                Console.WriteLine(number + " --> Is prime");

            } else Console.WriteLine(number + " --> No is prime");

        }
    }
}
