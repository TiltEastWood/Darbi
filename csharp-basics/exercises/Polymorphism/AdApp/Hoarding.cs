namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private bool _prime;
        public Hoarding(int fee, int rate, int numDays, bool prime) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _prime = prime;
        }

        public new int Cost() 
        {
            int cost = _rate * _numDays;

            if(_prime == true)
            {
                cost = cost + (cost / 2);
            }

            return base.Cost() + cost;
        }

        public override string ToString() 
        {
            string result = " Hoarding cost: " + Cost();
            return base.ToString() + result;
        }
    }
}