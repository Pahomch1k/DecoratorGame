using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class Vsadnik: DecoratorPeople
    {
        public Vsadnik(Component comp) : base(comp)
        {
        }

        public override string Move()
        {
            return $"{base.Move()} -> PeopleMech\n" +
                $"Damage - {Damage -= 10}\n" +
                $"Speed - {Speed += 40}\n" +
                $"Healthy - {Healthy += 200}\n" +
                $"Dafance - {Dafance += 100}\n";
        }
    }
}
