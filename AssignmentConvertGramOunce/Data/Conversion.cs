using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentConvertGramOunce.Data
{
    class Conversion
    {
        public double ConvertToOunces(double a)
        {
            
           return a/28.34952;
        }

        public double ConvertToGram(double a)
        {
            return a * 28.34952;
        }



    }
}
