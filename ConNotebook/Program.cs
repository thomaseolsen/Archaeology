using System;
using static System.Console;
using NotebookLibrary;

namespace ConNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(19, 23)}");
        }
    }
}
