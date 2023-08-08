using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sample
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef Make chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef Make salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef Make bbq ribs");
        }
    }
}
