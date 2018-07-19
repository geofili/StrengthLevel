using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrengthLevel.Enums
{
    public enum StrengthLevel
    {
        Untrained,
        Beginner,
        Novice,
        Intermediate,
        Advanced,
        Elite
    }

    public enum Exercise
    {
        All,
        BackSquat,
        BenchPress,
        Deadlift,
        OverheadPress,
        PendlayRow,
        PowerClean,
        PowerSnatch
    }

    public enum OneRepMaxFormula
    {
        Epley,
        Brzycki
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Units
    {
        Pounds,
        Kilograms
    }

}