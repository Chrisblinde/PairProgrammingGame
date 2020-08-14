using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.GameConsole
{
    class GameUI
    {
        private bool _isRunning = true;
        private readonly IGame _game;

        public GameUI(IGame game)
        {
            _game = game;
        }


        //Entry point to our UI, it starts our user interface
        public void Start()
        {
            TitlePage();
            RunMenu();
        }

        private void TitlePage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(
                "                 ____________________________________________                  \n " +
                "             /                                                \\              \n" +
                "             /                                                  \\             \n" +
                "            / __________________________________________________ \\            \n" +
                "           |    _____________________________________________     |           \n" +
                "           |   |                                             |    |           \n" +
                "           |   |                                             |    |           \n" +
                "           |   |                 Welcome to:                 |    |           \n" +
                "           |   |       ___      _    _  __ __    _  _        |    |           \n" +
                "           |   |        |  |_| |_   | | |_ |_ | |  |_        |    |           \n" +
                "           |   |        |  | | |_   |_| |  |  | |_ |_        |    |           \n" +
                "           |   |                                             |    |           \n" +
                "           |   |             _     _               __   __   |    |           \n" +
                "           |   |    /\\/\\    /_\\   | \\     |    || |__} |__   |    |       \n" +
                "           |   |   /    \\  /   \\  |_/     |__  || |__}  __|  |    |         \n" +
                "           |   |                                             |    |           \n" +
                "           |   |                                             |    |           \n" +
                "           |   |_____________________________________________|    |           \n" +
                "           |                                                      |           \n" +
                "            \\____________________________________________________/           \n" +
                "                   \\_______________________________________/                 \n" +
                "                _______________________________________________               \n" +
                "             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_            \n" +
                "          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_         \n" +
                "       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_      \n" +
                "    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_   \n" +
                " _-'.-.-.-.-.-. .---.-. .-----------------------------. .-.---. .---.-.-.-.`-_\n" +
                ":-----------------------------------------------------------------------------:\n" +
                "`---._.-----------------------------------------------------------------._.---'\n" +
                "                                                                                \n" +
                "                                                                                ");

            Console.ResetColor();
            //Console.ReadLine();

            //Console.WriteLine("");
            Console.WriteLine("   Here we get to enjoy your take on all our favorite quotes from The Office.");
            Console.WriteLine("");

            _game.WriteLine("                           Press any key to play!");
            _game.ReadKey();
        }
        //This method has the task of running the menu
        private void RunMenu()

        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }


        }
        private string GetMenuSelection()
        {
            _game.Clear();
            _game.WriteLine("Choose Which Character You Want to Quote!\n" +
                "Select Character Name or Number:\n" +
                "1. Michael Scott\n" +
                "2. Dwight Schrute\n" +
                "3. Jim Halpert\n" +
                "4. Pam Beesly\n" +
                "5. Angela Martin\n" +
                "6. Return To Title Page\n" +
                "7. Exit Game");
            string userInput = _game.ReadLine();
            return userInput;
        }
        private void OpenMenuItem(string userInput)
        {
            _game.Clear();
            switch (userInput)
            {
                case "1":
                case "Michael Scott":
                    Michael();
                    break;
                case "2":
                case "Dwight Schrute":
                    Dwight();
                    break;
                case "3":
                case "Jim Halpert":
                    Jim();
                    break;
                case "4":
                case "Pam Beesly":
                    Pam();
                    break;
                case "5":
                case "Angela Martin":
                    Angela();
                    break;
                case "6":
                    TitlePage();
                    return;
                case "7":
                case "Exit":
                    _isRunning = false;
                    return;
                default:
                    _game.WriteLine("Invalid input, please pick a character above.");
                    return;
            }

        }

        private void Michael()
        {
            _game.WriteLine("Type a word for each part of speech below.\n");

            _game.Write("Plural Noun: ");
            string nounOne = _game.ReadLine();
            string newOne = char.ToUpper(nounOne[0]) + nounOne.Substring(1);

            _game.Write("Noun: ");
            string nounTwo = _game.ReadLine();

            _game.Write("Adjective: ");
            string adjOne = _game.ReadLine();

            _game.Write("Verb: ");
            string verbOne = _game.ReadLine();

            _game.Write("Noun: ");
            string nounThree = _game.ReadLine();

            _game.Write("Plural Noun: ");
            string nounFour = _game.ReadLine();

            _game.WriteLine("");
            _game.WriteLine("Press any key to see your Mad Libbed quote!");
            _game.ReadKey();

            _game.WriteLine("");
            _game.WriteLine("Here's your quote:\n");
            _game.WriteLine($"\u0022{newOne} are the best way to show {nounTwo} how much you care. It is like this {adjOne} thing that you can {verbOne} to and say, ‘Hey {nounThree}, I love you this many {nounFour}-worth.'\u0022\n");
            _game.WriteLine("Here's the Michael Scott original:\n");
            _game.WriteLine("\u0022Presents are the best way to show someone how much you care.It is like this tangible thing that you can point to and say, ‘Hey man, I love you this many dollars-worth.'\u0022");
            _game.ReadLine();

            //“Presents(N1) are the best way to show someone(N2) how much you care. It is like this tangible(Adj1) thing that you can point(V1) to and say, ‘Hey man(N3), I love you this many dollars(N4)-worth.'”
        }

        private void Dwight()
        {
            _game.WriteLine("Type a word for each part of speech below.\n");

            _game.Write("Movie Title: ");
            string movieTitle = _game.ReadLine();

            _game.Write("Adjective: ");
            string adjOne = _game.ReadLine();
            string newOne = char.ToUpper(adjOne[0]) + adjOne.Substring(1);

            _game.Write("Adjective: ");
            string adjTwo = _game.ReadLine();

            _game.Write("Animal Type: ");
            string animalType = _game.ReadLine();

            _game.WriteLine("");
            _game.WriteLine("Press any key to see your Mad Libbed quote!");
            _game.ReadKey();

            _game.WriteLine("");
            _game.WriteLine("Here's your quote:\n");
            _game.WriteLine($"\u0022I saw {movieTitle} accidentally. I bought a ticket for '{newOne} Man' and went into the {adjTwo} theatre. After an hour, I figured I was in the wrong theatre, but I kept waiting. Cuz that's the thing about {animalType} attacks...they come when you least expect it.\u0022\n");
            _game.WriteLine("Here's the Dwight Schrute original:\n");
            _game.WriteLine("\u0022I saw Wedding Crashers accidentally. I bought a ticket for 'Grizzly Man'and went into the wrong theatre.  After an hour, I figured I was in the wrong theatre, but I kept waiting. Cuz that's the thing about bear attacks... they come when you least expect it.\u0022");
            _game.ReadLine();


            // “I saw Wedding Crashers(Movie Title) accidentally. I bought a ticket for “Grizzly(Adj1) Man” and went into the wrong(Adj2) theater. After an hour, I figured I was in the wrong theater, but I kept waiting. Cuz that’s the thing about bear(animal) attacks… they come when you least expect it.”
        }

        private void Jim()
        {
            _game.WriteLine("Type a word for each part of speech below.\n");

            _game.Write("Name: ");
            string nameOne = _game.ReadLine();
            string newOne = char.ToUpper(nameOne[0]) + nameOne.Substring(1);

            _game.Write("Animal Type: ");
            string animalType = _game.ReadLine();

            _game.Write("Verb: ");
            string verbOne = _game.ReadLine();

            _game.Write("Movie Title: ");
            string movieTitle = _game.ReadLine();


            _game.WriteLine("");
            _game.WriteLine("Press any key to see your Mad Libbed quote!");
            _game.ReadKey();

            _game.WriteLine("");
            _game.WriteLine("Here's your quote:\n");
            _game.WriteLine($"\u0022Oh, so {newOne} gave me this wooden {animalType} as a gift. I found a recording device in it. Yes. So. I think if I {verbOne} it just right, I can get {newOne} to live out the plot of {movieTitle}.\u0022\n");
            _game.WriteLine("Here's the Jim Halpert original:\n");
            _game.WriteLine($"\u0022Oh, so Dwight gave me this wooden mallard as a gift. I found a recording device in it. Yes. So. I think if I play it just right, I can get Dwight to live out the plot of National Treasure.\u0022");
            _game.ReadKey();

            //Oh, so Dwight(Name) gave me this wooden mallard(animal) as a gift. I found a recording device in it. Yes. So. I think if I play(verb) it just right, I can get Dwight(Name) to live out the plot of National Treasure(movie).
        }

        private void Pam()
        {
            _game.WriteLine("Type a word for each part of speech below.\n");

            _game.Write("Type Of Vehicle: ");
            string vehicleType = _game.ReadLine();
            string newOne = char.ToUpper(vehicleType[0]) + vehicleType.Substring(1);

            _game.Write("Noun: ");
            string nounOne = _game.ReadLine();

            _game.Write("Number: ");
            string number = _game.ReadLine();

            _game.Write("Adjective: ");
            string adjOne = _game.ReadLine();

            _game.Write("Verb: ");
            string verbOne = _game.ReadLine();

            _game.WriteLine("");
            _game.WriteLine("Press any key to see your Mad Libbed quote!");
            _game.ReadKey();

            _game.WriteLine("");
            _game.WriteLine("Here's your quote:\n");
            _game.WriteLine($"\u0022When a child gets behind the wheel of a {newOne} and runs into a {nounOne}, you don't blame the child; he didn't know any better. You blame the {number} -year-old woman who got in the {adjOne} seat and said, '{verbOne}, kid; I trust you.\u0022\n");
            _game.WriteLine("Here's the Pam Beesly original:\n");
            _game.WriteLine("\u0022When a child gets behind the wheel of a car and runs into a tree, you don't blame the child; he didn't know any better. You blame the 30-year-old woman who got in the passenger seat and said, 'Drive, kid; I trust you.'\u0022");
            _game.ReadKey();


            //When a child gets behind the wheel of a car and runs into a tree, you don't blame the child; he didn't know any better. You blame the 30-year-old woman who got in the passenger seat and said, "Drive, kid; I trust you."
        }

        private void Angela()
        {
            _game.WriteLine("Type a word for each part of speech below.\n");

            _game.Write("Adjective: ");
            string adjOne = _game.ReadLine();

            _game.Write("Adjective: ");
            string adjTwo = _game.ReadLine();

            _game.Write("Verb: ");
            string verbOne = _game.ReadLine();

            _game.Write("Noun: ");
            string nounOne = _game.ReadLine();


            _game.WriteLine("");
            _game.WriteLine("Press any key to see your Mad Libbed quote!");
            _game.ReadKey();

            _game.WriteLine("");
            _game.WriteLine("Here's your quote:\n");
            _game.WriteLine($"\u0022I know that patience and loyalty are {adjOne} and {adjTwo} traits... but sometimes, I just think you need to {verbOne} a {nounOne}!\u0022\n");
            _game.WriteLine("Here's the Angela Martin original:\n");
            _game.WriteLine($"\u0022I know that patience and loyalty are good and virtuous traits... but sometimes, I just think you need to grow a pair!\u0022");
            _game.ReadKey();

            //I know that patience and loyalty are good and virtuous traits... but sometimes, I just think you need to grow a pair!
        }
    }
}


