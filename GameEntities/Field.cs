using Data.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities
{
    public class Field
    {
        public ObservableCollection<Card> FirstLine = new ObservableCollection<Card>();
        public ObservableCollection<Card> SecondLine = new ObservableCollection<Card>();
        public ObservableCollection<Card> ThirdLine = new ObservableCollection<Card>();
    }
}
