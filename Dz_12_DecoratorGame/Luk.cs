using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class Luk : DecoratorPeople
    {
        public Luk(Component comp) : base(comp) { }

        public override string Move()
        {
            return $"{base.Move()} -> PeopleLuk\n" +
                $"Damage - {Damage += 20}\n" +
                $"Speed - {Speed += 20}\n" +
                $"Healthy - {Healthy += 50}\n" +
                $"Dafance - {Dafance += 10}\n";
        }
    }
}
