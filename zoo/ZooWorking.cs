using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zoo
{
    public class ZooWorking 
    { 
        public Animal[] Feed(Animal[] animal)
        {
            Animal[] homeAnimal = new Animal[animal.Length];

            for (int i = 0; i < animal.Length; i++)
            {
                animal[i].Eat(); 
                Console.WriteLine(animal[i].Name + " I'm not hungry anymore" );
            }
            return homeAnimal;
        }
    }
}
