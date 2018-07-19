using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StrengthLevel.Enums;

namespace StrengthLevel.Models
{
    public class StrengthRecord
    {
        DateTime Date { get; set; }
        Gender Gender { get; set; }
        int Age { get; set; }
        double WeightKg { get; set; }
        Exercise Exercise { get; set; }
        double LiftKg { get; set; }
        int Reps { get; set; }
        double AgeCoefficient { get; set; }
        double OneRepMaxKg { get; set; }
        OneRepMaxFormula OneRepMaxFormula { get; set; }
        Enums.StrengthLevel StrengthLevel { get; set; }
        double StrengthLevelPercentage { get; set; }

        public bool OneRepMaxIsEstimated()
        {
            return Reps > 0;
        }

        public double OneRepMaxPlateWeight(Units units)
        {
            throw new NotImplementedException();
        }

        public double OneRepMaxToBodyWeightPercentage()
        {
            throw new NotImplementedException();
        }

        public double OneRepMaxPlateWeightToBodyWeightPercentage()
        {
            throw new NotImplementedException();
        }

    }
}