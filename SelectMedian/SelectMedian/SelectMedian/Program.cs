using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public interface IWarrior
{
    // a.IsBetter(b) returns true if and only if
    // warrior a is no worse than warrior b, i.e. a>=b
    bool IsBetter(IWarrior other);
}

public static class Kata
{
    // warriors is IWarrior[5]
    public static IWarrior SelectMedian(IWarrior[] warriors)
    {
        Dictionary<IWarrior, List<IWarrior>> betterWarriors 
            = new Dictionary<IWarrior, List<IWarrior>>();
        foreach (IWarrior w in warriors)
            betterWarriors.Add(w, new List<IWarrior>());
        for (int i=0; i<4;i++) //4 compares
        {
            if (warriors[i].IsBetter(warriors[i + 1]))
                betterWarriors[warriors[i + 1]].Add(warriors[i]);
            else
                betterWarriors[warriors[i]].Add(warriors[i + 1]);
        }
        

        return null;
    }
}
