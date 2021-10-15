using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public interface IDataPrinter
    {
        public void SetObjectToPrint(List<object> objectsToPrint);
        public void SetPrintMethod(IPrintMethod printMethod);
        public void Print();
    }
}
