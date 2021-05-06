using System;
using System.Collections.Generic;

namespace TeamMarsProject
{

 public class Movie
 {
        public string _title;
        public string _studio;
        public string _ratings;
        

        public Movie(string title, string studio, string ratings)
        {
            _title = title;
            _studio = studio;
            _ratings = ratings;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _ratings = "PG";
        }
        public Movie()
        {

        }

        public static List<Movie> getPG(List<Movie> movies)
        {
            List<Movie> PgMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if(movie._ratings == "PG13")
                {
                    PgMovies.Add(movie);
                }
            }
            return PgMovies;
        }

 }
}
