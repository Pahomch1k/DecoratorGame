using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    class Client
    { 
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Move());
        }
    }
}
