using System;
using System.Collections.Generic;

namespace TeamMarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> films = new List<Movie>();
            List<Holiday> holidayList = new List<Holiday>();
            Movie film = new Movie("Casino Royal", "Eon Production","PG13");
            Movie film2 = new Movie("Casino Royal", "Eon Production","+18");
            Movie film3 = new Movie("Tom And Jerry", "Eon Production","PG13");
            Holiday holiday = new Holiday("Independence Day",1,"October");
            Holiday holiday2 = new Holiday("Democracy Day",12,"june");
            Holiday holiday3 = new Holiday("Teacher Day",7,"october");

            films.Add(film);
            films.Add(film2);
            films.Add(film3);
            holidayList.Add(holiday);
            holidayList.Add(holiday2);
            holidayList.Add(holiday3);

             Holiday.avgDate(holidayList);

            var moivesFromGetPg = Movie.getPG(films);
            foreach (var movieInList in moivesFromGetPg)
            {
                Console.WriteLine($"{movieInList._title} {movieInList._studio} {movieInList._ratings}");
             
            }

            var checkMonth = Holiday.inSameMonth(holiday._month,holiday3._month);
            Console.WriteLine(checkMonth);

        }
    }
}
