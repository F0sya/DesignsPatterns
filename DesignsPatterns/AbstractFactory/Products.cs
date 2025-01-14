using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.AbstractFactory
{
    public interface IChair
    {
        string Sit();
        string GetDescription();
    }

    public abstract class Chair : IChair
    {
        public abstract string Sit();
        public abstract string GetDescription();
    }

    public class ModernChair : Chair
    {
        public override string Sit()
        {
            return "You sit on new modern chair";
        }
        public override string GetDescription()
        {
            return "Modern chair for modern designs. Cheap.";
        }
    }
    public class VictorianChair : Chair
    {
        public override string Sit()
        {
            return "You sit on old victorian chair";
        }
        public override string GetDescription()
        {
            return "Victorian chair for old victorian-like designs. Expensive.";
        }
    }

    public interface ISofa
    {
        string Sit();
        string Lay();
        string GetDescription();
    }

    public abstract class Sofa : ISofa
    {
        public abstract string Sit();
        public abstract string Lay();
        public abstract string GetDescription();
    }

    public class ModernSofa : Sofa
    {
        public override string Sit()
        {
            return "You sit on new modern Sofa";
        }
        public override string Lay()
        {
            return "You lay on new modern Sofa";
        }

        public override string GetDescription()
        {
            return "Modern Sofa for modern designs. Cheap.";
        }
    }
    public class VictorianSofa : Sofa
    {
        public override string Sit()
        {
            return "You sit on old victorian Sofa";
        }
        public override string Lay()
        {
            return "You lay on old victorian Sofa";
        }
        public override string GetDescription()
        {
            return "Victorian Sofa for old victorian-like designs. Expensive.";
        }
    }

    public interface ICoffeeTable
    {
        string Sit();
        string Eat();
        string GetDescription();
    }

    public abstract class CoffeeTable : ICoffeeTable
    {
        public abstract string Sit();
        public abstract string Eat();
        public abstract string GetDescription();
    }

    public class ModernCoffeeTable : CoffeeTable
    {
        public override string Sit()
        {
            return "You sit on new modern Coffee Table";
        }
        public override string Eat()
        {
            return "You eat on new modern Coffee Table";
        }

        public override string GetDescription()
        {
            return "Modern Coffee Table for modern designs. Cheap.";
        }
    }
    public class VictorianCoffeeTable : CoffeeTable
    {
        public override string Sit()
        {
            return "You sit on old victorian Coffee Table";
        }
        public override string Eat()
        {
            return "You eat on old victorian Coffee Table";
        }
        public override string GetDescription()
        {
            return "Victorian Coffee Table for old victorian-like designs. Expensive.";
        }
    }
}
