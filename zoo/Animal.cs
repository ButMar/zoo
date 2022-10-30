using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zoo
{
    public class Animal 
    {
        public Animal()
        {
        }

        public string type;
        public string name;
        public string color;
        public int numberPaws;
        public int wing;
        public bool tail;
        public int weight;
        public string live;
        public int hungerLevel;



        public void Eat()
        { 
            var i = 0;
            do
            {
                Console.WriteLine(string.Format("{0} {1} going eat", type, name));
                i++;

                //bool result = (i == weight);

            } while (i != weight);

        }


        public void Run()
        {
            if (live != "in ocean" && numberPaws != 0)
            {
               Console.WriteLine(string.Format("{0} {1} {2} on {3} paws runing at home {4}",
                                                color, type, name, numberPaws, live));
            }
            
        }


        public void Fly()
        {
            if (wing == 2)
            {
                Console.WriteLine("I {0} {1} can fly", color, name);
            }
            else
            {
                Console.WriteLine("You  {0} can't fly, becose you need to have 2 wings", type);
            }
            
        }


        public void Gump()
        {
            if (type == "bunny")
            {
              Console.WriteLine("You are {0} bunny, so you can jump", name);
            }
            
        }

        public void Befood()
        {
            if (weight < 50)
            {
                Console.WriteLine("carefully {0} {1} You will be food ", type, name);
            }
            else
            {
                Console.WriteLine("{0}, you will live", name);
            }

        }


    }

    

 }
