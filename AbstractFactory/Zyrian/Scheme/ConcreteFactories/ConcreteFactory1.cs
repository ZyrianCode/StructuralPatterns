using AbstractFactory.Zyrian.Scheme.Abstract;
using AbstractFactory.Zyrian.Scheme.AbstractProducts;
using AbstractFactory.Zyrian.Scheme.Products;

namespace AbstractFactory.Zyrian.Scheme.ConcreteFactories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ProductA1();

        public IAbstractProductB CreateProductB() => new ProductB1();
    }
}
