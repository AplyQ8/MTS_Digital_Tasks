using System;

class Program
{
    static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
    {
        var values = new int[maxValue + 1];
        int min = 0;
 
        foreach (int x in inputStream)
        {
            ++values[x];
 
            int max = x - sortFactor;
            while (min < max)
            {
                while (values[min] --> 0)
                    yield return min;
                ++min;
            }
        }
 
        while (min < values.Length)
        {
            while (values[min] --> 0)
                yield return min;
            ++min;
        }
    }
    public static void Main(string[] args)
    {
    }
}