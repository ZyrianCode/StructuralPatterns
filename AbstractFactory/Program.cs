using AbstractFactory.Zyrian.Scheme;
using AbstractFactory.Zyrian.Scheme.Abstract;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchemeFacade schemeFactory = new();
            schemeFactory.Start();
        }
    }
}
