using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string rating, string studio)
        {
            this._title = title;
            this._rating = rating;
            this._studio = studio;
        }
        public Movie(string studio, string title)
        {
            this._title = title;
            this._studio = studio;
            this._rating = "PG";
        }
        public Movie[] GetPG(Movie[] inputMovies)
        {
            Movie[] movies = Array.FindAll(inputMovies, x => x._rating == "PG");

            return movies;
        }
        public void showMovie()
        {
            Console.WriteLine($"{_title} {_studio} {_rating}"); 
        }
    }

}
