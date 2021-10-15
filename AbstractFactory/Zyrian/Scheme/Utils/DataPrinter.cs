using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Types;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public class DataPrinter : IDataPrinter
    {
        private List<IAbstractFactoryBaseType> _objectsToPrint;

        private IPrintMethod _printMethod;


        public void SetObjectToPrint(List<IAbstractFactoryBaseType> objectsToPrint) => _objectsToPrint = objectsToPrint;

        public void SetPrintMethod(IPrintMethod newPrintMethod) => _printMethod = newPrintMethod;

        public void PrintData() => _printMethod.Print(_objectsToPrint);
    }
}
