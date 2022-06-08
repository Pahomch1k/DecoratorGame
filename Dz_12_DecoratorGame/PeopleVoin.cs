using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class PeopleVoin : DecoratorPeople
    {  
        public PeopleVoin(Component comp) : base(comp) 
        { 
        }
         
        public override string Move()
        {
            return $"{base.Move()} -> PeopleVoin\n" +
                $"Damage - {Damage += 20}\n" +
                $"Speed - {Speed += 10}\n" +
                $"Healthy - {Healthy += 50}\n" +
                $"Dafance - {Dafance += 20}\n";
        }
    }
}
