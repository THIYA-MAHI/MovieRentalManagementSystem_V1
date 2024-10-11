using MovieRentalManagementSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class DigitalMovie : Movie
    {
        public decimal FileSize { get; set; }
        public string foramt { get; set; }
        public DigitalMovie(int movieId, string title, string director, decimal rentalPrice, decimal fileSize, string foramt) : base(movieId, title, director, rentalPrice)
        {
            FileSize = fileSize;
            this.foramt = foramt;
        }

        public string DisplayDigitalMovieInfo()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director: {Director}, rentalPrice: {RentalPrice}";
        }
        public override string DisplayMovieInfo()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director: {Director}, rentalPrice: {RentalPrice} ";
        }
    }
}
