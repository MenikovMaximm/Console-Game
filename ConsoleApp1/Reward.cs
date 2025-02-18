using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reward : Character
    {
        public int Exp { get; set; }
        public uint Health { get; set; }
        public int Strong { get; set; }
        public int Protected { get; set; }

        public Reward(int exp, uint health, int strong, int protectedValue)
        {
            Exp = exp;
            Health = health;
            Strong = strong;
            Protected = protectedValue;
        }
    }
}
