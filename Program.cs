
namespace MadLibs
    {
        class Program
        {
            static void Main(string[] args)
            {
                /*
                This program creates a short story in the form of a Mad Libs word game.
                Author:Donte M.
                */


                // Let the user know that the program is starting:


                // Give the Mad Lib a title:
                string title = "Mad Libs Madness";

                Console.WriteLine(title);
                // Define user input and variables:


                // The template for the story:
                Console.WriteLine("Let The Madness Begin!");

                // Ask user to provide MC name
                Console.Write("Enter the main character's name: ");
                string name = Console.ReadLine();

                // Ask user to provide 3 adjectives
                Console.Write("How are you feeling? ");
                string feeling = Console.ReadLine();

                Console.Write("What is the first color that comes to mind? ");
                string color = Console.ReadLine();

                Console.Write("What is the texture of your favorite shirt? ");
                string texture = Console.ReadLine();

                //Ask user to provide a verb
                Console.Write("Provide an action word such as run or jump ");
                string verb = Console.ReadLine();

                //Ask user to provide 2 nouns
                Console.Write("Provide a noun ");
                string noun1 = Console.ReadLine();

                Console.Write("Provide a second noun ");
                string noun2 = Console.ReadLine();

                //Ask user to provide one of each random subject
                Console.Write("Name an animal ");
                string animal = Console.ReadLine();

                Console.Write("Name a food ");
                string food = Console.ReadLine();

                Console.Write("Name a fruit ");
                string fruit = Console.ReadLine();

                Console.Write("Name a superhero ");
                string hero = Console.ReadLine();

                Console.Write("Name a country ");
                string country = Console.ReadLine();

                Console.Write("Name a dessert ");
                string dessert = Console.ReadLine();

                Console.Write("Enter a year ");
                string year = Console.ReadLine();

                string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {color} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {texture}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


                // Print the story:
                Console.WriteLine(story);
            }
        }
    }

