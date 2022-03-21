using System;
using System.Threading.Channels;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass Example = new FirstClass();
            Example.OnKeyPressed += (_, a) => Console.WriteLine(a);
            Example.Run();
        }
    }
}
