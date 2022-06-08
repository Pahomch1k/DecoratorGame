using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    public abstract class Component
    {
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Healthy { get; set; }
        public int Dafance { get; set; }

        public Component()
        {
            Damage = 20;
            Speed = 20;
            Healthy = 150;
            Dafance = 0;
        }

        public abstract string Move(); 
    }
}
