using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.FabricMethod
{
    public class Client { 
        static void Main(string[] args)
        {
            EnemyFactory zombieFact = new ZombieFactory();
            EnemyFactory skeletonFact = new SkeletonFactory();

            Enemy Zombie = zombieFact.CreateEnemy("Easy");
            Enemy Skeleton = skeletonFact.CreateEnemy("Normal");
            Enemy ZombieHard = zombieFact.CreateEnemy("Hard");

            Console.WriteLine("First check:");
            Console.WriteLine(Zombie.Attack());
            Console.WriteLine($"Zombie HP: {Zombie.Health}\n");

            Console.WriteLine("Second check:");
            Console.WriteLine(Skeleton.Attack());
            Console.WriteLine($"Skeleton HP: {Skeleton.Health}\n");

            Console.WriteLine("Third check:");
            Console.WriteLine(ZombieHard.Attack());
            Console.WriteLine($"ZombieHard HP: {ZombieHard.Health}");



        }
    }
}
