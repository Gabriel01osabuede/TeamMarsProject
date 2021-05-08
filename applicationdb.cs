using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace week4project
{
    /// <summary>
    /// An mock of singleton design pattern
    /// </summary>
    public class Db
    {
        private List<Movie> Movie;
        private List<Holiday> Holiday;
      private Db()
        {
            this.Movie = new List<Movie>();
            this.Holiday = new List<Holiday>();
        }

        public static Db Initialize()
        {
            return new Db();
        }
        
        //  public static Holiday holiday()
        // {
        //     return new Holiday();
        // }

        public void  AddMovie(Movie m)
        {
            this.Movie.Add(m);
        }

        public void AddHoliday(Holiday h)
        {
            this.Holiday.Add(h);
        }
        

        public IEnumerable<Movie> GetMovies()
        {
            return this.Movie;
        }
           public IEnumerable<Holiday> getHoliday()
        {
            return this.Holiday;
        }
    }

}