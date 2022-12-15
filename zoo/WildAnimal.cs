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
        private bool predator = true;
       
        public WildAnimal(string type, string name, string color, int hungerLevel) : base( type, name, color, hungerLevel)
        {
        }


        public void Hunt()
        {
            while (hungerLevel > 0 && predator == true)
            {
                Console.WriteLine(string.Format("I am {0} {1} going to hunt ", name, color));
                hungerLevel--;
            }
        }




    }

}
