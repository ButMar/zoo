using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zoo
{
    public class WildAnimal : Animal
    {
        public WildAnimal()
        {
        }

        private bool predator = true;
        private bool eatAnimals = true;
        


        public void Hunt()
        { 
            while (hungerLevel > 0)
            {
              Console.WriteLine(string.Format("I am {0} {1} {2}  going  to hunt ", color, name, type));
              hungerLevel--;
            }
            
        }

        


}

 }
