using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPatterns.FabricMethod
{
    abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy(string difficulty);
    }

    class ZombieFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(string difficulty)
        {
            return new Zombie(difficulty); 
        }
    }

    class SkeletonFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(string difficulty)
        {
            return new Skeleton(difficulty);
        }
    }
}
