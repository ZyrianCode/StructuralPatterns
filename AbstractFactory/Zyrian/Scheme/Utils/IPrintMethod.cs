using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Types;

namespace AbstractFactory.Zyrian.Scheme.Utils
{
    public interface IPrintMethod
    {
        public void Print(List<IAbstractFactoryBaseType> objectsToPrint);
    }
}
