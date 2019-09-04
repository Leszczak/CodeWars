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
        Dictionary<IWarrior, int> warriorsPoints = new Dictionary<IWarrior, int>();
        foreach (IWarrior w in warriors)
            warriorsPoints.Add(w, 0);
        for(int i=0;i<5;i++)
        {
            if (warriors[i].IsBetter(warriors[i + 1 % 5]))
                warriorsPoints[warriors[i]]++;
            else
                warriorsPoints[warriors[i + 1 % 5]]++;
        }
        if (warriorsPoints.Count(p => p.Value == 2) == 1)
            return warriorsPoints.First(p => p.Value == 2).Key;
        return warriorsPoints.Where(p => p.Value == 2)
                        .Aggregate((a, b) => a.Key.IsBetter(b.Key) ? a : b).Key;

        // Here be code
        throw new NotImplementedException();
    }
}
