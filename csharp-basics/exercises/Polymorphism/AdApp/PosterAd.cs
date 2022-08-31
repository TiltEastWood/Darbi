using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    internal class PosterAd : Advert
    {
        private int _dimensions;
        private int _copies;
        private int _rate;

        public PosterAd(int fee, int dimensions, int copies, int rate) : base(fee)
        {
            _rate = rate;
            _dimensions = dimensions;
            _copies = copies;
        }
        public new int Cost()
        {
            int cost = _rate * _copies + _dimensions;
            return cost + base.Cost();
        }

        public override string ToString()
        {
            string result = " Poster add costs are: " + Cost();
            return base.ToString() + result;
        }
    }
}
