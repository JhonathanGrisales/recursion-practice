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


            // CONSECUTIVE SUM
            Console.WriteLine("The total amount: " + add.addNum(9));

            //ADD DIGITS
            Console.WriteLine("The total:  " + addDigits.AddDig(123));

            //SPIDERMAN ALGORITMO 
            Console.WriteLine("The total jumps: " + spidermanAlgoritmo.SpiderAlgo (6));


        }
    }
}
