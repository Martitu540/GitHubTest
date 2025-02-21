using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassC
    {


        public double BabyLoonSqrt(double number)
        {
            double guess = number / 2;
            while(Math.Abs(guess*guess - number ) < 0.01){
                double other = number / guess;
                guess = (guess + other) / 2;
            }
            return guess;
        }

    }
}
