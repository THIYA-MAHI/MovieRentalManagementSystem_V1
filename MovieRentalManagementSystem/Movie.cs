using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class Movie
    {
        public int MovieId {  get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public decimal RentalPrice { get; set; }
        public int TotalMovies { get; set; }

        public Movie(int movieId, string title, string director, decimal rentalPrice, int totalMovies)
        {
            MovieId = movieId;
            Title = title;
            Director = director;
            RentalPrice = rentalPrice;
            TotalMovies++;
        }

        public Movie(int movieId, string title, string director, decimal rentalPrice)
        {
            MovieId = movieId;
            Title = title;
            Director = director;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director: {Director}, rentalPrice: {RentalPrice}";
        }

        public virtual string DisplayMovieInfo()
        {
            return $"ID: {MovieId}, Title: {Title}, Director: {Director}, RentalPrice: {RentalPrice}";
        }


    }
}
