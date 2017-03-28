using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClasses
{
    public class Card
    {
        private string _Suite;
        private int _CardNumber;
        private bool _Flipped;

        public Card()
        {
            _Suite = "Clubs";
            _CardNumber = 1;
            _Flipped = false;
        }

        public Card(string suite, int card, bool flipped)
        {
            _Suite = suite;
            _CardNumber = card;
            _Flipped = flipped;
        }

        public int CardNumber
        {
            get
            {
                return _CardNumber;
            }
            set
            {
                _CardNumber = value;
            }
        }

    }
}
