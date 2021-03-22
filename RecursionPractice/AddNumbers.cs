using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPractice
{
    class AddNumbers
    {

        public int addNum(int numMax)
        {

            if(numMax == 0)
            {
                return 0;

            } else
            {
                int suma = numMax + addNum(numMax -1);
                return suma;
              
            }

        }


    }
}
