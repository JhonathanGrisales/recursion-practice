using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPractice
{
    class SpidermanAlgoritmo
    {

        public int SpiderAlgo(int edifice)
        {

            if (edifice <=2)
            {

                return edifice;
            }
            
            return (SpiderAlgo(edifice - 1) + SpiderAlgo(edifice - 2));



        }


    }
}
