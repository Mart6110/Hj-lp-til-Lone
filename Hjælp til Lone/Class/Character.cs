using Hjælp_til_Lone.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_til_Lone.Class
{
    class Character : IDie, IFight, IHeal
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
    }
}
