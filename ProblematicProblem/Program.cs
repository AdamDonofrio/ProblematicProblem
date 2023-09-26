using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program 
    { 
        
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            bool cont;
            var contResponse = Console.ReadLine().ToLower();

            if (contResponse == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            if (cont)
            {
                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                int userAge = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? Sure/No: ");

                bool seeList;
                var seeListResponse = Console.ReadLine().ToLower();

                if (seeListResponse == "Sure" || seeListResponse == "sure")
                {
                    seeList = true;
                }
                else
                {
                    seeList = false;
                }

                //bool seeList = bool.Parse(Console.ReadLine());
                bool addToList = false;
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    //addToList = bool.Parse(Console.ReadLine());

                    //bool addToList;
                    var addToListResponse = Console.ReadLine().ToLower();

                    if (addToListResponse  == "yes")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }

                    Console.WriteLine();


                }
                //bool addToList = false;
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    var addToListResponse = Console.ReadLine().ToLower();

                    if (addToListResponse == "yes")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }
                }
                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    //int randomNumber = rng.Next(activities.Count);
                    int randomNumber = rng.Next(activities.Count);
                
                    string randomActivity = activities[randomNumber];
                    if (userAge > 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        //string randomNumber = rng.Next(activities.Count);
                        //string randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    //randActivityRedo = bool.Parse(Console.ReadLine());
                
                    var randActivityRedoResponse = Console.ReadLine().ToLower();
                    //bool randActivityRedo;

                    if (randActivityRedoResponse == "keep")
                    {
                        //randActivityRedo = false;
                        cont = false;
                    }
                    else
                    {
                        cont = true;
                    }
                }
            }
            
        

            
        }
    }

        
    
}