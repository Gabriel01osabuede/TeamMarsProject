using System;
using System.Collections.Generic;
using System.Linq;

namespace week4project
{
     public class Homescreen
    {
        public static void Homescreens()
        {                   
        
        Movie movie = new Movie();
        Menu menu = new Menu();
        menu.setCurrentStage(1);
        Db applicationDatabase = Db.Initialize();
      
       
        bool appIsRunning = true;

        while(appIsRunning){
        
        while(menu.getCurrentStage() == 1)
        {
            Menu.PromptUser("\nWelcome to Team Mars Project..");
            Menu.PromptUser("To guild you through the app follow these easy steps.");
            Menu.PromptUser("Select 1 To Enter The movie section of the app,\n Select 2 to enter Holiday Section\n Select 3 to Exit The App.");
            string selectedMenuChoice = Console.ReadLine();
            switch (selectedMenuChoice)
            {
                case "1":
                menu.setCurrentStage(2);
                break;
                case "2":
                menu.setCurrentStage(3);
                break;
                case "3":
                Menu.PromptUser("Thank you for your time.");
                Environment.Exit(0);
                break;

            }

            Console.Clear();
        }

        while(menu.getCurrentStage() == 2)
        {
            
            Menu.PromptUser("Welcome to the Movies app");
            Menu.PromptUser("Press 1 To Add Movies e.g(Title,Production and Rating).");
            Menu.PromptUser("Press 2 To View All Movies in Database");
            Menu.PromptUser("Press 3 To View All Movies With PG13");
            Menu.PromptUser("Press B To Return To The Home Screen");
            
             
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                 string reply = "NO";
                    do{
                Menu.PromptUser("Welcome");
                Menu.PromptUser("Please Input the Movie Title");
                string title = Console.ReadLine();
                Menu.PromptUser("Please input the Movie studio");
                string studio = Console.ReadLine();
                Menu.PromptUser("Please input the Movie rating");
                string ratings = Console.ReadLine().ToUpper();

                
                applicationDatabase.AddMovie(new Movie(title, studio, ratings));
                
                    Console.WriteLine("Would you like to add More Movies.\n YES OR NO");
                    reply = Console.ReadLine().ToUpper();
                    }while(reply == "YES");

                Console.WriteLine("Thank you all your Movies have been stored.\n");
        
                menu.setCurrentStage(2);
                break;
                case "2":
                 if (applicationDatabase.GetMovies().Count() == 0) 
                    {
                        Console.WriteLine("YOu dont have any Movie in database.");
                        menu.setCurrentStage(1);
                        break;
                    }
                           Console.WriteLine("MOVIE TITLE\t||\tSTUDIO PRODUCTION\t||\tMOVIE RATING");
                foreach(var movies in applicationDatabase.GetMovies())
                {
                    Console.WriteLine($"{movies._title}\t\t{movies._studio}\t\t\t{movies._ratings}\n");
                }
                Console.WriteLine("\n============================\n");
                menu.setCurrentStage(2);
                break;
                case "3":
                 if (applicationDatabase.GetMovies().Count() == 0) 
                    {
                        Console.WriteLine("YOu dont have any Movie in database.");
                        menu.setCurrentStage(1);
                        break;
                    }
                var moivesFromGetPg = Movie.getPG(applicationDatabase.GetMovies().ToList());
                Console.WriteLine("MOVIE TITLE\t||\tSTUDIO PRODUCTION\t||\tMOVIE RATING");
                foreach (var movieInList in moivesFromGetPg)
                {
                    Console.WriteLine($"{movieInList._title}\t\t{movieInList._studio}\t\t\t{movieInList._ratings}\n");
                    
                }
                Console.WriteLine("\n============================\n");
                menu.setCurrentStage(2);
                break;
                case "b":
                menu.setCurrentStage(1);
                break;
            }
        }
        while(menu.getCurrentStage()== 3)
        {
            
            Menu.PromptUser("Welcome to the Holiday app");
            Menu.PromptUser("Press 1 To Add Holiday e.g(Holiday Name,Holiday day,Holiday Month).");
            Menu.PromptUser("Press 2 To View All Holiday in Database");
            Menu.PromptUser("Press 3 To View All Holidays With Same Month");
            Menu.PromptUser("Press 4 To View The Average of all Holiday Days.");
            Menu.PromptUser("Press b To Return To The Home Screen");

            String userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                
                    string reply = "NO";
                    do{
                Menu.PromptUser("Welcome");
                Menu.PromptUser("Please Input the Holiday Name");
                string nameOfHoliday = Console.ReadLine();
                Menu.PromptUser("Please input the Holiday Day");
                int dayOfMonth = Int32.Parse(Console.ReadLine());
                Menu.PromptUser("Please input the Holiday Month");
                string monthOfHoliday = Console.ReadLine().ToUpper();

                applicationDatabase.AddHoliday(new Holiday(nameOfHoliday, dayOfMonth, monthOfHoliday));
                
                    Console.WriteLine("Would you like to add More Holiday.\n YES OR NO");
                    reply = Console.ReadLine().ToUpper();
                    }while(reply == "YES");

                Console.WriteLine("Thank you all your data have been stored.\n");
                break;
                case "2":
                 if (applicationDatabase.getHoliday().Count() == 0) 
                    {
                        Console.WriteLine("YOu dont have any holiday in database.");
                        menu.setCurrentStage(1);
                        break;
                    }
                Console.WriteLine("HOLIDAY NAME\t||\tHOLIDAY DAY\t||\tHOLIDAY MONTH");
                foreach(var holidays in applicationDatabase.getHoliday())
                {
                    Console.WriteLine($"{holidays._name}\t\t{holidays._day}\t\t{holidays._month}\n");
                }
                Console.WriteLine("\n============================\n");
                break;
                case "3":
                Menu.PromptUser("Please Input Month To check");
                string month = Console.ReadLine().ToUpper();
                Console.WriteLine("HOLIDAY NAME\t||\t HOLIDAY DAY\t||\tHOLIDAY MONTH");
                foreach(var holiday in  applicationDatabase.getHoliday())
                {
                    if (month == holiday._month)
                    {
                        Console.WriteLine($"{holiday._name}\t\t{holiday._day}\t\t{holiday._month}\n");
                    }
                }   
                break;
                case "4":
                UserInteractionsHolidayApp.avgDate(applicationDatabase.getHoliday().ToList());
                break;
                case "b":
                menu.setCurrentStage(1);
                break;
            }
        }
        }
        }
       }
    }