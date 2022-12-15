using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo.Utils
{
    internal class FileReader
    {
        public List<Animal> ReadAnimalsFromFile(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            var result = new List<Animal>();

            foreach (string animalLine in lines)
            {
                string[] animalParams = animalLine.Split(',');
                string type = animalParams[1]; 
                string name = animalParams[2];
                string color = animalParams[3];
                int hungerLevel = int.Parse(animalParams[4]);
                
                result.Add(new Animal(type, name, color, hungerLevel));
            }
          
            return result;
            string? name = Console.ReadLine();
        }
    }
}
