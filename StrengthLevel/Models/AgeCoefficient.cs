using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrengthLevel.Models
{
    public class AgeCoefficient
    {
        static (int age, double coefficient)[] ageCoefficients = {

            //Foster Age Coefficients:
            //http://www.usapl-sd.com/Formulas/Foster.htm
            
            (age: 14, coefficient: 1.23),
            (age: 15, coefficient: 1.18),
            (age: 16, coefficient: 1.13),
            (age: 17, coefficient: 1.08),
            (age: 18, coefficient: 1.06),
            (age: 19, coefficient: 1.04),
            (age: 20, coefficient: 1.03),
            (age: 21, coefficient: 1.02),
            (age: 22, coefficient: 1.01),
            (age: 23, coefficient: 1.0),
            
            //McCulloch Coefficients:
            //http://globalpowerliftingalliance.com/master%20age%20formula.html
            
            (age: 24, coefficient: 1.0),
            (age: 25, coefficient: 1.0),
            (age: 26, coefficient: 1.0),
            (age: 27, coefficient: 1.0),
            (age: 28, coefficient: 1.0),
            (age: 29, coefficient: 1.0),
            (age: 30, coefficient: 1.0),
            (age: 31, coefficient: 1.0),
            (age: 32, coefficient: 1.0),
            (age: 33, coefficient: 1.0),
            (age: 34, coefficient: 1.0),
            (age: 35, coefficient: 1.0),
            (age: 36, coefficient: 1.0),
            (age: 37, coefficient: 1.0),
            (age: 38, coefficient: 1.0),
            (age: 39, coefficient: 1.0),
            (age: 40, coefficient: 1.0),

            (age: 41, coefficient: 1.010),
            (age: 42, coefficient: 1.020),
            (age: 43, coefficient: 1.031),
            (age: 44, coefficient: 1.043),
            (age: 45, coefficient: 1.055),
            (age: 46, coefficient: 1.068),
            (age: 47, coefficient: 1.082),
            (age: 48, coefficient: 1.097),
            (age: 49, coefficient: 1.113),
            (age: 50, coefficient: 1.130),

            (age: 51, coefficient: 1.147),
            (age: 52, coefficient: 1.165),
            (age: 53, coefficient: 1.184),
            (age: 54, coefficient: 1.204),
            (age: 55, coefficient: 1.225),
            (age: 56, coefficient: 1.246),
            (age: 57, coefficient: 1.268),
            (age: 58, coefficient: 1.291),
            (age: 59, coefficient: 1.313),
            (age: 60, coefficient: 1.340),

            (age: 61, coefficient: 1.366),
            (age: 62, coefficient: 1.393),
            (age: 63, coefficient: 1.421),
            (age: 64, coefficient: 1.450),
            (age: 65, coefficient: 1.480),
            (age: 66, coefficient: 1.511),
            (age: 67, coefficient: 1.543),
            (age: 68, coefficient: 1.576),
            (age: 69, coefficient: 1.610),
            (age: 70, coefficient: 1.645),

            (age: 71, coefficient: 1.681),
            (age: 72, coefficient: 1.718),
            (age: 73, coefficient: 1.756),
            (age: 74, coefficient: 1.795),
            (age: 75, coefficient: 1.835),
            (age: 76, coefficient: 1.876),
            (age: 77, coefficient: 1.918),
            (age: 78, coefficient: 1.961),
            (age: 79, coefficient: 2.005),
            (age: 80, coefficient: 2.050),

            (age: 81, coefficient: 2.096),
            (age: 82, coefficient: 2.143),
            (age: 83, coefficient: 2.190),
            (age: 84, coefficient: 2.238),
            (age: 85, coefficient: 2.287),
            (age: 86, coefficient: 2.337),
            (age: 87, coefficient: 2.388),
            (age: 88, coefficient: 2.440),
            (age: 89, coefficient: 2.492),
            (age: 90, coefficient: 2.549)
        };

        /// <summary>
        /// Returns the coefficient for the specified age or 1 if age is out of range.
        /// </summary>
        /// <param name="age">The age of the user.</param>
        /// <returns></returns>
        static double coefficient(int age)
        {

            //check if age is within valid range:
            if (age < GlobalVariables.minAge || age > GlobalVariables.maxAge)
            {
                return 1.00;
            }

            foreach((int age, double coefficient) row in ageCoefficients)
            {
                if (row.age == age) {
                    return row.coefficient;
                }
            }

            return 1.00; //no value was found
        }
    }
}