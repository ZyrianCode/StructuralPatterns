using AbstractFactory.Zyrian.Scheme;
using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SchemeFacade schemeFactory = new();
            schemeFactory.Start();
        }
    }
}
