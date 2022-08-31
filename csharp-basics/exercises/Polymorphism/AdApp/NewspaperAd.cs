namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        private new int Cost()
        {
            var costPerCollum = _rate * _column;
            var fee = costPerCollum + base.Cost();
            return fee;
        }

        public override string ToString()
        {
            string result = " NewspaperAD cost : " + Cost();
            return base.ToString() + result;
        }
    }
}