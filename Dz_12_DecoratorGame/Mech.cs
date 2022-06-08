using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class Mech : DecoratorPeople
    {
        public Mech(Component comp) : base(comp) 
        { 
        }

        public override string Move()
        {
            return $"{base.Move()} -> PeopleMech\n" +
                $"Damage - {Damage += 40}\n" +
                $"Speed - {Speed -= 10}\n" +
                $"Healthy - {Healthy += 50}\n" +
                $"Dafance - {Dafance += 40}\n";
        }
    }
}
