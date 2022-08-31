using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private string _name;
        private List<Advert> campaign;

        public Campaign(string name) 
        {
            _name = name;
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return "Advert Campaign" + _name + "\nTotal Cost = "+ GetCost();
        }
    }
}