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
            HerbivorousAnimal horse = new HerbivorousAnimal();
            horse.type = "horse";
            horse.name = "Tuz";
            horse.color = "black";
            horse.numberPaws = 4;
            horse.tail = true;
            horse.weight = 5;
            horse.live = " in field";

            HerbivorousAnimal bunny = new HerbivorousAnimal();
            bunny.type = "bunny";
            bunny.name = "Tosha";
            bunny.color = "grey";
            bunny.numberPaws = 4;
            bunny.tail = false;
            //bunny.weight = 1.5;
            bunny.live = "in forest";
            
            HerbivorousAnimal goose = new HerbivorousAnimal();
            goose.type = "goose";
            goose.name = "Gia";
            goose.color = "white";
            goose.numberPaws = 2;
            goose.wing = 2;
            goose.tail = true;
            //goose.weight = 3.7;
            goose.live = " home in people";

            WildAnimal lion = new WildAnimal();
            lion.type = "lion";
            lion.name = "Lenya";
            lion.color = "yellow";
            lion.numberPaws = 4;
            lion.tail = true;
            //lion.weight = 150;
            lion.live = " in field";
            lion.hungerLevel = 3;

            WildAnimal shark = new WildAnimal();
            shark.type = "shark";
            shark.name = "Ice";
            shark.color = "blue";
            shark.tail = true;
            shark.weight = 730;
            shark.live = " in ocean";
            shark.hungerLevel = 5;

            WildAnimal eagle = new WildAnimal();
            eagle.type = "eagle";
            eagle.name = "Recar";
            eagle.color = "brown";
            eagle.numberPaws = 2;
            eagle.wing = 2;
            eagle.tail = true;
            //eagle.weight = 7.4;
            eagle.live = " in forest";
            eagle.hungerLevel = 1;
            

            horse.Eat();
            //goose.Run();
            //lion.Hunt();
            //eagle.Fly();
            //bunny.Fly();
            //bunny.Gump();
            //bunny.Befood();
            //eagle.Befood();
            //shark.Befood();

            Console.WriteLine();










        }
    }
}
