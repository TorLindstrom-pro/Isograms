using System.Linq;

namespace Isograms;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        return str.Distinct().Count() == str.Length;
    }
}