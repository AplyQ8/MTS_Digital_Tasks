/// <summary>
/// <para> Отсчитать несколько элементов с конца </para>
/// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
/// </summary> 
/// <typeparam name="T"></typeparam>
/// <param name="enumerable"></param>
/// <param name="tailLength">Сколько элеметнов отсчитать с конца (у последнего элемента tail = 0)</param>
/// <returns></returns>

using System;
using System.Collections;
using System.Collections.Generic;


static class Program
{
    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        List<(T item, int? tail)> items = new List<(T item, int? tail)>();
        
        if (tailLength == null || tailLength <= 0)
            return items;
        
        var count = enumerable.Count();
        if (tailLength >= count)
        {
            foreach (var item in enumerable)
            {
                items.Add((item, --count));
            }
        }
        else
        {
            var i = 0;
            var tailNumb = count - tailLength;
            foreach (var item in enumerable)
            {
                items.Add((item, i >= tailNumb ? --tailLength : null));
                i++;
            }
        }
        return items;
        
    }
    public static void Main(string[] args)
    {
        int[] array = new[] { 1, 2 , 3, 4 };
        array.EnumerateFromTail(2);
        foreach (var tail in array.EnumerateFromTail(2))
        {
            Console.WriteLine($"({tail.item}, {tail.tail})");
        }

    }
}