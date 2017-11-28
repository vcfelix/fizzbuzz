using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    public class FizBuzz
    {

        public string output = "";

        public FizBuzz(int num1, int num2)
        {
            if (num2 < num1) {
                int temp = num1;
                num1 = num2; num2 = temp;
            }

            for (int f= num1; f<= num2; f++)
            {
                if (f%3 == 0)
                {
                    if (f % 5 == 0) output += "fizzbuzz"; else output += "fizz";
                } else
                {
                    if (f % 5 == 0) output += "buzz"; else output += f;
                }
                output += " ";
            } 
            
        }
        
    }
}
