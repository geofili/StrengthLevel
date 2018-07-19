using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StrengthLevel.Enums;

namespace StrengthLevel.Models
{
    public sealed class Utility : IDisposable
    {

        public static double ConvertKilogramsToPounds(double weightKg)
        {
            return weightKg * 2.2046;
        }

        public static double ConvertPoundsToKilograms(double weightLbs)
        {
            return weightLbs / 2.2046;
        }

        public static double DivisibleBy(double weight, double amount)
        {
            return Math.Round(weight / amount) * amount;
        }

        public static double ConvertToPlateWeight(double weight, Units units, double minPlateSize)
        {
            switch (units)
            {
                case Units.Pounds:
                    return ConvertKilogramsToPounds(weight)
                    //return weightKg.convertKilogramsToPounds.divisibleBy(minPlateSizeLb * 2)
                    break;
                case Units.Kilograms:
                    //return weightKg.divisibleBy(minPlateSizeKg * 2)
                    break;
            }


        }

    }

}