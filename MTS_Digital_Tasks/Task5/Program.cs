using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task5;


class Program
{
    public static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");
        //... custom application code
    }

    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        NewStreamWriter nSW = new NewStreamWriter("sw.txt");
        Console.SetOut(nSW);
    }
}
