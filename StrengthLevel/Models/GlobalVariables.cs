using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrengthLevel.Models
{
    public class GlobalVariables
    {
        public static int minAge = 14;
        public static int maxAge = 90;

        public static int minReps = 1;
        public static int maxReps = 10;

        public static Double minPlateSizeKg = 1.25;
        public static Double minPlateSizeLb = 2.5;

        public static Double minLiftKg = 20.0; //empty olympic bar
        public static Double minLiftLb = 45.0; //empty olympic bar

        public static Double maxLiftKg = 452.50;
        public static Double maxLiftLb = 1000.0;
    }
}