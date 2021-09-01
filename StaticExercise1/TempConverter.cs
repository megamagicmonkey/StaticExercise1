using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise1
{
    static class TempConverter
    {


        public static double FtoC(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * .5556;
            

            return celsius;
        }

        public static double CtoF(double celsius)
        {
           

            double fahrenheit = (celsius * 1.8) + 32;

            return fahrenheit;
        }
    }
}
