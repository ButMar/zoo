using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal horse = new Animal("horse", "Tuz", "black", 5, 2);
            HerbivorousAnimal rabit = new HerbivorousAnimal("rabit", "Tosha", "grey");

            horse.Eat();
            horse.Run();
            horse.Fly();
            horse.Gump();
            horse.Befood();

            rabit.Hide();




            Console.WriteLine();










        }
    }
}
