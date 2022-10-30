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
        public HerbivorousAnimal()
        {
        }

        private bool peaceful = true;
        private bool eatGrass = true;

        public void Hide()
        {
            if (peaceful == true && eatGrass == true)
            {
              Console.WriteLine(string.Format("everyone {0} knows how to hide", type));
            }
            
        }

        




    }
    
}
