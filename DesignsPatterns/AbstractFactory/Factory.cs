using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    public abstract class AbstractFactory : IAbstractFactory
    {
        public abstract IChair CreateChair();
        public abstract ISofa CreateSofa();
        public abstract ICoffeeTable CreateCoffeeTable();
    }

    class VictorianFactory : AbstractFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }
        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

    }

    class ModernFactory : AbstractFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }
        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

    }
}
