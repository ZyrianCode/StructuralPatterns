using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public class ConsolePrintMethod : IPrintMethod
    {
        public void StartMethod(List<object> objectsToPrint)
        {
            foreach (var objectToPrint in objectsToPrint)
            {
                Console.WriteLine(objectToPrint.ToString());
            }
        }
    }
}
