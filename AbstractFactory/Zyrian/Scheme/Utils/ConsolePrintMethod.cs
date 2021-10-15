using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Types;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public class ConsolePrintMethod : IPrintMethod
    {
        public void Print(List<IAbstractFactoryBaseType> objectsToPrint)
        {
            foreach (var objectToPrint in objectsToPrint)
            {
                Console.WriteLine(objectToPrint.ToString());
            }
        }
    }
}
