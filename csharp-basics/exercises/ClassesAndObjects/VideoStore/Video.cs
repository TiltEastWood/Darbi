using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string title;
        private bool checkedOut;
        List<double> _rating;  

        public Video(string title)
        {
            this.title = title;
            checkedOut = false;
            _rating = new List<double>();
        }
        public void BeingCheckedOut()
        {
            checkedOut = true;
        }

        public void BeingReturned()
        {
            checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public string Available()
        {
            if (checkedOut == true)
            {
                return "Not available";
            }
            else
            {
                return "Is available";
            }
        }

        public string Title => title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
