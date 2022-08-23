using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (title == _inventory[i].Title)
                {
                    _inventory[i].BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (title == _inventory[i].Title)
                {
                    _inventory[i].BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var item in _inventory)
            {
                if (title == item.Title)
                {
                    item.ReceivingRating(rating);
                }    
            }
        }

        public void ListInventory()
        {
            for(int i = 0; i < _inventory.Count; i++)
            {
                Console.WriteLine(_inventory[i]);
            }
        }
    }
}
