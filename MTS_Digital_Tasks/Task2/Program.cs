using System;
using System.Globalization;
using System.Linq.Expressions;

class Program
{
    static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

    class Number
    {
        readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public static String operator +(Number a, string b) 
            => new String((a.Parsed(a) + Convert.ToInt32(b)).ToString());

        public override string ToString()
        {
            return _number.ToString(_ifp);
        }

        private int Parsed(Number a)
        {
            var isParsed = int.TryParse(a.ToString(), out var c);
            if (isParsed)
            {
                return c;
            }
            else
            {
                throw new Exception("Невозможно конвертировать!");
            }
        }
        
    }
    

    static void Main(string[] args)
    {
        int someValue1 = 10;
        int someValue2 = 5;

        string result = new Number(someValue1) + someValue2.ToString(_ifp);
        
        Console.WriteLine(result);
        Console.ReadKey();
    }
}