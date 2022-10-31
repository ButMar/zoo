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
        protected string Mtype;
        protected string Mname;
        protected string Mcolor;
        protected int MnumberPaws = 4;
        protected int Mwing = 2;
        protected int Mweight;
        protected string Mhome = "forest";
        protected int MhungerLevel;

        public Animal(string type, string name, string color, int weight, int hungerLevel)
        {
            Mtype = type;
            Mname = name;   
            Mcolor = color;
            Mweight = weight;
            MhungerLevel = hungerLevel;
        }

        
 
        public void Eat()
        { 
            var i = 0;
            do
            {
                Console.WriteLine(string.Format("{0} {1} going eat in {2} paws", Mtype, Mname, MnumberPaws));
                i++;

            }  while (i != Mweight);

        }


        
        public void Run()
        {
            if (Mhome != "in ocean" && MnumberPaws != 0)
            {
               Console.WriteLine(string.Format("{0} {1} {2} on {3} paws runing at home {4}",
                                                Mcolor, Mtype, Mname, MnumberPaws, Mhome));
            }
            
        }


        public void Fly()
        {
            if (Mwing == 2)
            {
                Console.WriteLine("I {0} {1} can fly", Mcolor, Mname);
            }
            else
            {
                Console.WriteLine("You  {0} can't fly, becose you need to have 2 wings", Mtype);
            }
            
        }


        public void Gump()
        {
            if (Mtype == "rabit")
            {
              Console.WriteLine("You are {0} rabit, so you can jump", Mname);
            }
            
        }

        public void Befood()
        {
            if (Mweight < 50)
            {
                Console.WriteLine("carefully {0} {1} You will be food ", Mtype, Mname);
            }
            else
            {
                Console.WriteLine("{0}, you will live", Mname);
            }

        } 


    }

}
