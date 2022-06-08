using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12_DecoratorGame
{
    abstract class DecoratorPeople : Component
    {
        protected Component _component;
         
          
        public DecoratorPeople(Component component)
        {
            _component = component; 
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        // Декоратор делегирует всю работу обёрнутому компоненту.
        public override string Move()
        {
            if (_component != null) return _component.Move(); 
            else return ""; 
        }
    }
}