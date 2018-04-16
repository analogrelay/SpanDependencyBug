using System;

namespace SpanDependencyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            // Span something
            var str = "Hello, World!";
            var chars = str.AsSpan();
            Console.WriteLine(chars.IndexOf('W'));
        }
    }
}
