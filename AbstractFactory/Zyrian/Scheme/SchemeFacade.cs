using AbstractFactory.Zyrian.Scheme.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Zyrian.Scheme.ConcreteFactories;

namespace AbstractFactory.Zyrian.Scheme
{
    public class SchemeFacade
    {
        private readonly Client _client = new();

        public void Start()
        {
            IAbstractFactory abstractFactory = new ConcreteFactory1();
            ConnectClientToFactory(abstractFactory);
            Print();
        }

        private void ConnectClientToFactory(IAbstractFactory abstractFactory) => _client.Run(abstractFactory);

        private void Print() => _client.Print();
    }
}
