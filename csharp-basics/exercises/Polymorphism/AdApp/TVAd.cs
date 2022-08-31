using System;

namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _rate;
        private TimeSpan _start;
        private TimeSpan _end;
        public TVAd(int fee, int seconds, int rate, int start, int end) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _start = new TimeSpan(start, 0, 0);
            _end = new TimeSpan(end, 0, 0);
        }
        
        public new int Cost() 
        {
            int cost = _seconds * _rate;
            TimeSpan now = DateTime.Now.TimeOfDay;

            if(now >= _start && now <= _end)
            {
                return cost * 2 + base.Cost();
            }
            return cost + base.Cost();
        }

        public override string ToString() 
        {
            string result = " TV add cost is : " + Cost();
            return base.ToString() + result;
        }
    }
}