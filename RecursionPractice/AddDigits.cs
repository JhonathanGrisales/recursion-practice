using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPractice
{
    class AddDigits
    {

        public int AddDig(int num)
        {

            if (num == num / 10)
            {
                return 0;

            }
            else
            {
                return num % 10 + AddDig(num / 10);
            }
            
            
        }
             
    }
}
