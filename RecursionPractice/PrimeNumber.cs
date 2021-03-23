using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPractice
{
    class PrimeNumber
    {
        public Boolean FindPrimeNumber(int number, int count)
        {

            if (number == 1)
            {
                
                return true; //is prime
            }

            if (count == 1)
            {
                
                return true; //is prime

            }else if (number % count == 0) {

                
                return false; //no is prime
            }
            
            return FindPrimeNumber(number, count-1);
          
        }

       

    }
}
