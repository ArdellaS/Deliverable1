
using System;

namespace Deliverable2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int PickActivity;
            int PeopleNumber;
            string SelectedActivity;
            string SuggestedActivity;
            string TravelMethod;


            Console.WriteLine("Happy Friday! What would you like to do this weekend? Here are some options. Please pick a number");
            Console.WriteLine("1.) Action");
            Console.WriteLine("2.) Chilling");
            Console.WriteLine("3.) Danger");
            Console.WriteLine("4.) Good Food");


            PickActivity = Convert.ToInt32(Console.ReadLine());

            if (PickActivity == 1)
            {
                SelectedActivity = "action";
                SuggestedActivity = "Go-Kart Racing";
            }
            else if (PickActivity == 2)
            {
                SelectedActivity = "chilling";
                SuggestedActivity = "hiking";
            }
            else if (PickActivity == 3)
            {
                SelectedActivity = "danger";
                SuggestedActivity = "skydiving";
            }
            else
            {
                SelectedActivity = "good food";
                SuggestedActivity = "to IHOP";
            }


            Console.WriteLine("How many people are you bringing with you?");

            PeopleNumber = Convert.ToInt32(Console.ReadLine());

            if (PeopleNumber == 0)
            {
                TravelMethod = "sneakers.";
            }

            else if (PeopleNumber <= 4)
            {
                TravelMethod = "a sedan.";
            }

            else if (PeopleNumber <= 10)
            {
                TravelMethod = "a Volkswagen bus.";
            }

            else
            {
                TravelMethod = "an airplane.";
            }

            Console.WriteLine("If you to try " + SelectedActivity + " this weekend, then you should go " + SuggestedActivity + " and you should travel in " + TravelMethod);

            Console.WriteLine("Have a good weekend!");
            Console.Read();

        }
    }
}