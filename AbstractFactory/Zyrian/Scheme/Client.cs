using AbstractFactory.Zyrian.Scheme.Abstract;
using AbstractFactory.Zyrian.Scheme.AbstractProducts;
using AbstractFactory.Zyrian.Scheme.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Types;

namespace AbstractFactory.Zyrian.Scheme
{
    public class Client
    {
        private IAbstractProductA _abstractProductA;
        private IAbstractProductB _abstractProductB;

        private readonly List<IAbstractFactoryBaseType> _objects = new();

        public void Run(IAbstractFactory abstractFactory)
        {
            _abstractProductA = abstractFactory.CreateProductA();
            _abstractProductB = abstractFactory.CreateProductB();
        }

        public void Print()
        {
            IDataPrinter dataPrinter = new DataPrinter();
            FillObjectsList();

            dataPrinter.SetObjectToPrint(_objects);
            dataPrinter.SetPrintMethod(new ConsolePrintMethod());
            dataPrinter.PrintData();
        }

        private void FillObjectsList()
        {
            _objects.Add(_abstractProductA);
            _objects.Add(_abstractProductB);
        }
    }
}
