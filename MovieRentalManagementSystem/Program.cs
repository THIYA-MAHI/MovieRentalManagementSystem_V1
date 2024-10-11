using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager manager = new MovieManager();
            bool exit = false;

            while (!exit) {
            Console.WriteLine("Movie Rental Management System:");
            Console.WriteLine("1. Add a Movie");
            Console.WriteLine("2. View All Movies");
            Console.WriteLine("3. Update a Movie");
            Console.WriteLine("4. Delete a Movie");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");/*break*/


                switch (option)
                {
                    case 1:
                        createMovie(manager);
                        Console.WriteLine("movie added successfully");
                        Console.WriteLine(" ");/*break*/

                        break;
                    case 2:
                        manager.ReadMovie();
                        foreach (var movierec in movies)
                        {
                            Console.WriteLine(movierec.DisplayMovieInfo());
                        }
                        break;

                        
                    case 3:
                        updateMovie(manager);
                        Console.Clear();

                        break;
                    case 4:
                        deleteMovie(manager);

                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("you choose ivalid option. please enter correct option");
                        Console.WriteLine(" ");


                        break;
                }
                       
            }            
        }
        static void createMovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieId = int .Parse(Console.ReadLine());

            Console.WriteLine("2. enter the movie title");
            string movieTitle = Console.ReadLine();

            Console.WriteLine("3. enter the movie director");
            string movieDirector = Console.ReadLine();

            Console.WriteLine("4. enter the movie Rental Price");
            decimal rentalPrice = decimal.Parse(Console.ReadLine());
            manager.ValidateMovieRentalPrice(price);


            manager1.CreateMovie(movieId, movieTitle, movieDirector, rentalPrice);
        }

        static void updateMovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieId = int.Parse(Console.ReadLine());

            Console.WriteLine("2. enter the new movie title");
            string NewTitle = Console.ReadLine();

            Console.WriteLine("3. enter the new movie director");
            string NewDirector = Console.ReadLine();

            Console.WriteLine("4. enter the new movie Rental Price");
            decimal NewrentalPrice = decimal.Parse(Console.ReadLine());

            manager1.UpdateMovie(movieId,NewTitle,NewDirector,NewrentalPrice);
        }

        static void deleteMovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieId = int.Parse(Console.ReadLine());

            manager1.DeleteMovie(movieId);
        }

       
    }
}
