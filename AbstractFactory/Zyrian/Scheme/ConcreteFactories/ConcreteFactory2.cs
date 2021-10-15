using AbstractFactory.Zyrian.Scheme.Abstract;
using AbstractFactory.Zyrian.Scheme.AbstractProducts;
using AbstractFactory.Zyrian.Scheme.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Zyrian.Scheme.ConcreteFactories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ProductA2();

        public IAbstractProductB CreateProductB() => new ProductB2();
    }
}
