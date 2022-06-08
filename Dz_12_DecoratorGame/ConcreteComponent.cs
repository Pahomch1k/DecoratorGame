using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class SimplePeople : Component
    {  
        public override string Move()
        {
            return $"SimplePeople\n" +
                $"Damage - {Damage}\n" +
                $"Speed - {Speed}\n" +
                $"Healthy - {Healthy}\n" +
                $"Dafance - {Dafance}\n";
        }
    }
}
