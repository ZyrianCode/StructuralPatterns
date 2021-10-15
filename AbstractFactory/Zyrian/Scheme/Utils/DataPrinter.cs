using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public class DataPrinter : IDataPrinter
    {
        private List<object> _objectsToPrint;
        private IPrintMethod _printMethod;
        public void SetObjectToPrint(List<object> objectsToPrint) => _objectsToPrint = objectsToPrint;
        public void SetPrintMethod(IPrintMethod newPrintMethod) => _printMethod = newPrintMethod;
        public void Print() => _printMethod.StartMethod(_objectsToPrint);
    }
}
