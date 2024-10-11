using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class MovieManager
    {
        public List<Movie> MoviesList = new List<Movie>();

        public void CreateMovie(int movieId, string title, string director, decimal rentalPrice)
        {
            Movie movie = new Movie(movieId, title, director, rentalPrice);
            MoviesList.Add(movie);
        }

        public void ReadMovie()
        {
            if(MoviesList.Count >0)
            {
                foreach (var movie in MoviesList)
                {
                    Console.WriteLine("Movies Are:");
                    Console.WriteLine(movie.DisplayMovieInfo());

                }
            }
            else
            {
                Console.WriteLine("There are no movies");
            }
            
        }

        public void UpdateMovie(int movieId, string NewTitle, string NewDirector, decimal NewRentalPrice)
        {

            var movie = MoviesList.FirstOrDefault(m => m.MovieId == movieId);
            if(movie != null)
            {
                movie.Title = NewTitle;
                movie.Director = NewDirector;
                movie.RentalPrice = NewRentalPrice;
                Console.WriteLine("movie updated successfully");

            }
            else
            {
                Console.WriteLine("movie is not found");
            }
        }



        public void DeleteMovie(int movieId)
        {
            var movie = MoviesList.FirstOrDefault(m => m.MovieId == movieId);
            if (movie != null)
            {
                MoviesList.Remove(movie);
                Console.WriteLine("movie deleted successfully");

            }
            else
            {
                Console.WriteLine("movie is not found");
            }
        }

        public void ValidateMovieRentalPrice(decimal price)
        {
            while (price <= 0)
            {
                Console.WriteLine("Error:price must be possitive,please enter again:");
                price = Convert.ToDecimal(Console.ReadLine());
            }
        }


    }
}
