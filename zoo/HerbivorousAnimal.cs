using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zoo
{
    public class HerbivorousAnimal : Animal
    {
        private bool peaceful = true;
        private bool eatGrass = true;

        public HerbivorousAnimal(string type, string name, string color, int hugerlevel) :
                                 base( type, name, color, hugerlevel)
        {                   
        }

        public void Hide()
        {
            if (peaceful == true && eatGrass == true)
            {
                Console.WriteLine(string.Format("everyone {0} knows how to hide", type));
            }
        }

    }

}
