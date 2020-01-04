﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{

    // *************************************************************
    // Application:     The Conversation (Example Code)
    // Author:          Velis, John E.
    // Description:     An application that has a conversation with the user
    //                  about skiing
    // Date Created:    5/20/2019
    // Date Revised:    12/20/2019
    // *************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            string userName;
            string favoriteSki;
            string typeOfSkiing;
            string favoriteArea;
            string userResponse;

            int averageHoursPerDay;
            int averageDaysPerYear;
            int yearsSkied;
            int totalHoursSkied;

            //
            //      **********************
            //      *   Opening Screen   *
            //      **********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //
            // display a opening screen information
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThe Skier App");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //
            //      ***************************
            //      *   Introduction Screen   *
            //      ***************************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //
            // display header
            //
            Console.WriteLine();
            Console.WriteLine("\t\tIntroduction");
            Console.WriteLine();

            //
            // enter conversation with user
            //
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is John.");

            //
            // get the user's name and echo it back
            //
            Console.WriteLine();
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userName + ".");
            //Console.WriteLine("It is nice to meet you {0}.", userName);
            //Console.WriteLine($"It is nice to meet you {userName}.");

            //
            // determine if the user skis
            //
            Console.WriteLine();
            Console.Write($"Do you like to ski {userName}?");
            userResponse = Console.ReadLine();

            //
            // pause the app for the user
            //
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //
            // get more information if the user is a skier
            //
            if (userResponse == "yes")
            {
                //
                //      *****************************
                //      *   Type of Skiing Screen   *
                //      *****************************
                //
                // set cursor invisible, background colors, foreground colors, and clear screen
                //
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                //
                // display header
                //
                Console.WriteLine();
                Console.WriteLine("\t\tType of Skiing");
                Console.WriteLine();

                //
                // get user's favorite ski
                //
                Console.WriteLine();
                Console.WriteLine("Glad to hear you like skiing. It is one of my favorite sports!");
                Console.WriteLine();
                Console.Write("What is your favorite ski?");
                favoriteSki = Console.ReadLine();
                Console.WriteLine("So, {0}, you like {1} skis.", userName, favoriteSki);

                //
                // get the user's type of skiing
                //
                Console.WriteLine();
                Console.WriteLine("I am interested in what kind of skiing you do.");
                Console.Write("Do you prefer \"downhill\", \"cross country\", or \"back country\"?");
                typeOfSkiing = Console.ReadLine();

                //
                // get the user's favorite area
                //
                Console.WriteLine();
                Console.Write("What is your favorite area to ski?");
                favoriteArea = Console.ReadLine();

                //
                // provide feedback on the type of skiing
                //
                Console.WriteLine();
                if (typeOfSkiing == "downhill")
                {
                    Console.WriteLine("I have downhill skied for most of my life, but gave it up last year.");
                    Console.WriteLine($"I hear the {favoriteArea} is a great place to ski {userName}.");
                }
                else if (typeOfSkiing == "cross country")
                {
                    Console.WriteLine("I spend some of my time cross country skiing.");
                    Console.WriteLine($"I am not sure I have skied at {favoriteArea}. I will have to give it a try.");
                }
                else if (typeOfSkiing == "back country")
                {
                    Console.WriteLine("I spend most of my time skiing now in back country.");
                    Console.WriteLine($"Well {userName}, I am not sure I have skied at {favoriteArea}. I will have to give it a try.");
                }
                else // user's response was not valid
                {
                    Console.WriteLine("I am afraid I don't recognize that type of skiing.");
                    Console.WriteLine($"But you say you can do that at {favoriteArea}, eh!");
                }

                //
                // pause the app for the user
                //
                Console.WriteLine();
                Console.WriteLine("\tPress any key to continue.");
                Console.ReadKey();

                //
                //      *******************************
                //      *   Skiing Frequency Screen   *
                //      *******************************
                //
                // set cursor invisible, background colors, foreground colors, and clear screen
                //
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                //
                // display header
                //
                Console.WriteLine();
                Console.WriteLine("\t\tAmount of Skiing");
                Console.WriteLine();

                //
                // query the user for information
                //
                Console.WriteLine("I would like to learn more about how much you ski.");
                Console.WriteLine();

                Console.Write("How many years have you skied?");
                userResponse = Console.ReadLine();
                yearsSkied = int.Parse(userResponse);
                Console.WriteLine();

                Console.Write("How many days on average do you ski in a year?");
                userResponse = Console.ReadLine();
                averageDaysPerYear = int.Parse(userResponse);
                Console.WriteLine();

                Console.Write("How many hours on average do you ski in a day?");
                userResponse = Console.ReadLine();
                averageHoursPerDay = int.Parse(userResponse);
                Console.WriteLine();

                totalHoursSkied = yearsSkied * averageDaysPerYear * averageHoursPerDay;

                Console.WriteLine($"Well {userName}, from my calculations it appears you have skied {totalHoursSkied} hours in your lifetime.");
                Console.WriteLine("Not bad!");
                Console.WriteLine();

                //
                // thank the user and say good bye
                //
                Console.WriteLine();
                Console.WriteLine($"{userName}, it has been great getting learn more about your skiing interests.");
                Console.WriteLine("Have a nice day.");

                //
                // pause the app for the user
                //
                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }

            //
            // thank the user if the user is not a skier
            //
            else
            {
                //
                //      *****************************
                //      *     Thank User Screen     *
                //      *****************************
                //
                // set cursor invisible, background colors, foreground colors, and clear screen
                //
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"I am sorry you don't like skiing {userName}. It has been nice meeting you.");

                //
                // pause the app for the user
                //
                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }

            //
            //      **********************
            //      *   Closing Screen   *
            //      **********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //
            // display the closing screen information
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThank You for Your Interest in Our Application");
            Console.WriteLine();
            Console.WriteLine("\t\t\tClown Car Productions");
            Console.WriteLine();

            //
            // pause the app for the user
            //
            Console.WriteLine();
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
        }
    }
}
