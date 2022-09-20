using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task5;

public class NewStreamWriter: StreamWriter
{
    private TextWriter _oldOut;
    
    public NewStreamWriter(Stream stream) : base(stream)
    {
    }

    public NewStreamWriter(Stream stream, Encoding encoding) : base(stream, encoding)
    {
    }

    public NewStreamWriter(Stream stream, Encoding encoding, int bufferSize) : base(stream, encoding, bufferSize)
    {
    }

    public NewStreamWriter(Stream stream, Encoding? encoding = null, int bufferSize = -1, bool leaveOpen = false) : base(stream, encoding, bufferSize, leaveOpen)
    {
    }

    public NewStreamWriter(string path) : base(path)
    {
        _oldOut = Console.Out;
    }

    public NewStreamWriter(string path, FileStreamOptions options) : base(path, options)
    {
    }

    public NewStreamWriter(string path, bool append) : base(path, append)
    {
    }

    public NewStreamWriter(string path, bool append, Encoding encoding) : base(path, append, encoding)
    {
    }

    public NewStreamWriter(string path, bool append, Encoding encoding, int bufferSize) : base(path, append, encoding, bufferSize)
    {
    }

    public NewStreamWriter(string path, Encoding encoding, FileStreamOptions options) : base(path, encoding, options)
    {
    }
    

    public override void WriteLine(string? value)
    {
        if (value == "Муха")
        {
            Console.SetOut(_oldOut);
            return;
        }
        base.WriteLine(value);
    }
}