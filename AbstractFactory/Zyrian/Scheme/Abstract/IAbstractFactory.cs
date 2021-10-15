using AbstractFactory.Zyrian.Scheme.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Zyrian.Scheme.Abstract
{
    public interface IAbstractFactory
    {
        public abstract IAbstractProductA CreateProductA();
        public abstract IAbstractProductB CreateProductB();
    }
}
