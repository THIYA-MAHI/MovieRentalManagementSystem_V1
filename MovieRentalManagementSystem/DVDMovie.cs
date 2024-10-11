using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class DVDMovie : Movie
    {
        public decimal DiscWeight {  get; set; }
        public decimal Duration { get; set; }
        public DVDMovie(int movieId, string title, string director, decimal rentalPrice, decimal discWeight, decimal duration) : base(movieId, title, director, rentalPrice)
        {
            DiscWeight = discWeight;
            Duration = duration;
        }

        public string DisplayDVDMovieInfo()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director: {Director}, rentalPrice: {RentalPrice}";
        }
        public override string DisplayMovieInfo()
        {
            return $"{base.DisplayMovieInfo()},duration:{Duration},weight:{DiscWeight}";
        }

    }
}
