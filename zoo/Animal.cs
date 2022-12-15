using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zoo
{
    public class Animal 
    {
        protected string type;
        protected string name;
        protected string color;
        protected int numberPaws;
        protected bool wing = false;
        protected int weight;
        protected int hungerLevel;

        public Animal(string type, string name, string color, int hungerLevel)
        {
            this.type = type;
            this.name = name;
            this.color = color;
            this.hungerLevel = hungerLevel;
        }
        public string Type { get { return type; } }
        public string Name { get { return name; } }
        public string Color { get { return color; } }
        public int HungerLevel
        { 
            get { return hungerLevel; }
            set { hungerLevel = value; }
        }


        public int Eat()
        {
            do
            {
                hungerLevel--;
            }
            while (hungerLevel > 0);

            return hungerLevel;
        }


        public void Run()
        {
            if ( numberPaws != 0)
            {
               Console.WriteLine(string.Format("{0} {1} on {3} paws runing at home}",
                                                color, name, numberPaws));
            }
            
        }


        public void Fly()
        {
            if (wing == true)
            {
                Console.WriteLine("I {0} can fly", name);
            }
            else
            {
                Console.WriteLine("You  {0} can't fly, becose you need to have 2 wings", name);
            }
            
        }



    }

}
