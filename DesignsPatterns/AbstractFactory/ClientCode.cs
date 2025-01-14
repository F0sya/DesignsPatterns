using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.AbstractFactory
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("Victorian shop: ");
            ClientMethod(new VictorianFactory());
            Console.WriteLine();
            Console.WriteLine("Modern shop: ");
            ClientMethod(new ModernFactory());
        }
        public void ClientMethod(IAbstractFactory abstractFactory)
        {
            var chair = abstractFactory.CreateChair();
            var sofa = abstractFactory.CreateSofa();
            var coffeeTable = abstractFactory.CreateCoffeeTable();

            Console.WriteLine(chair.Sit());
            Console.WriteLine(chair.GetDescription());
            Console.WriteLine();
            Console.WriteLine(sofa.Sit());
            Console.WriteLine(sofa.Lay());
            Console.WriteLine(sofa.GetDescription());
            Console.WriteLine();
            Console.WriteLine(coffeeTable.Sit());
            Console.WriteLine(coffeeTable.Eat());
            Console.WriteLine(coffeeTable.GetDescription());
        }
    }
}
