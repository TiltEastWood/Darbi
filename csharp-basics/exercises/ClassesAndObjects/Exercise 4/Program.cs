using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Eon Productions", "Casion Royal", "PG-13");
            Movie movie2 = new Movie("Buena Vista International", "Glass", "PG-13");
            Movie movie3 = new Movie("Columbia Pictures", "Spider-Man: Into the Spider-Verse");

            Movie[] movies = new[] { movie1, movie2, movie3 };

            Movie[] moviesPG = movie1.GetPG(movies);

            movie1.showMovie();
            movie2.showMovie();
            movie3.showMovie();

            moviesPG[0].showMovie();
        }
    }
}
