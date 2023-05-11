﻿using Hjælp_til_Lone.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_til_Lone.Class
{
    class Witch : Character, IRaiseShield, IShieldGlare, ITeleport
    {
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
