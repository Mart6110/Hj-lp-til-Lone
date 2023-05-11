using Hjælp_til_Lone.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_til_Lone.Class
{
    class Wizard : Character, ITeleport, IThrowFrostNova, IThrowMagicMisile
    {
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }
        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}
