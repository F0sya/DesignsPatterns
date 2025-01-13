using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.FabricMethod
{

    public interface IEnemy
    {
        static int Health { get; set; }
        static int Damage { get; set; }
        string Attack();
    }
    
    public abstract class Enemy : IEnemy
    {
        public int Health = IEnemy.Health;

        public int Damage = IEnemy.Damage;

        public abstract string Attack();
    }

    class Zombie : Enemy
    {
        public Zombie(string difficulty)
        {
            switch (difficulty)
            {
                case "Easy":
                    Health = 100;
                    Damage = 20;
                    break;
                case "Normal":
                    Health = 200;
                    Damage = 40;
                    break;
                case "Hard":
                    Health = 300;
                    Damage = 60;
                    break;
                default:
                    throw new ArgumentException($"{difficulty} isn't exist");
            }
        }
        public override string Attack()
        {
            return $"Zombie attacked Player! Player took {Damage} damage!";
        }
    }
    
    class Skeleton : Enemy
    {
        public Skeleton(string difficulty)
        {
            switch (difficulty)
            {
                case "Easy":
                    Health = 100;
                    Damage = 20;
                    break;
                case "Normal":
                    Health = 200;
                    Damage = 40;
                    break;
                case "Hard":
                    Health = 300;
                    Damage = 60;
                    break;
                default:
                    throw new ArgumentException($"{difficulty} isn't exist");
            }
        }
        public override string Attack()
        {
            return $"Skeleton attacked Player! Player took {Damage} damage!";
        }
    }
}
