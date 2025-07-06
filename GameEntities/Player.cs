using Data.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities
{
    public class Player
    {
        public string Name { get; set; }
        public ObservableCollection<Card> Deck { get; }
        public ObservableCollection<Card> Grave { get; }
        public ObservableCollection<Card> Hand { get; }
        public Field Field { get; set; }

        public Player()
        {
            Name = "Player 1";
            Deck = new ObservableCollection<Card>();
            Grave = new ObservableCollection<Card>();
            Hand = new ObservableCollection<Card>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Hand.Add(new UnitCard($"i", rnd.Next(14)));
            }
            Field = new Field();
        }
    }
}
