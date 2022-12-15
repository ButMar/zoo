using System;
using System.Collections.Generic;
using System.Xml.Linq;
using zoo.Utils;

namespace zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("cat", "Tom", "white", 2);
            Animal dog = new Animal("dog", "Tuzik", "black", 5);
            Animal rabit = new Animal("rabit", "Tosha", "grey", 6);
            Animal[] cages1 = new Animal[] { cat, dog, rabit };
            
            ZooWorking nick = new ZooWorking();
            List<Animal> animals = new List<Animal>();
            
            try 
            {
                var reader = new FileReader();
                animals = reader.ReadAnimalsFromFile(@"D:\AnimalDatabase.txt");
            }

             catch (FormatException e)
            {
                Console.WriteLine("Format of hunger level for is wrong. Message: " + e.Message);
            }
            catch (ArgumentNullException e) {  
            
                // send.SMS("Databse ofline")
                throw e;
            }


            foreach (Animal animal in animals)
            {
               Console.WriteLine("Hello my new friend " + animal.Type + " " + animal.Name);
            }


            //WildAnimal wolf = new WildAnimal("wolf", "Zub", "grey", 6);
            //WildAnimal fox = new WildAnimal("fox", "Alisa", "red", 2);
            //WildAnimal lion = new WildAnimal("lion", "lev", "red", 3);

            //WildAnimal[] cages2 = new WildAnimal[] { wolf, fox, lion };
            //nick.Feed(cages2);




        }
    }
}
