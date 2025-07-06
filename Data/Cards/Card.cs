using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Cards
{
    public abstract class Card 
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public string Type { get; }

        protected Card(string name, int strength, string type) { 
            Name = name;
            Strength = strength;
            Type = type;
        }

        public abstract void Play();
    }
}
