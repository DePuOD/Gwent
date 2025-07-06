using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Cards
{
    public class UnitCard : Card
    {
        public UnitCard(string name, int strength) : base(name, strength, "UnitCard")
        {
            Name = name;
            Strength = strength;
        }
        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
