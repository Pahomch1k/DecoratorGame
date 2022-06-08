using System;

namespace Dz_12_DecoratorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
  
            var decorator1 = new PeopleVoin(new SimplePeople()); 
            var decorator2 = new Mech(decorator1);
            var decorator3 = new Vsadnik(decorator2);
            client.ClientCode(decorator3);
             
        }
    }
}