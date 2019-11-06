using System;

namespace Lab8
{
    class Program
    {
        public static int GetInput()
        {
            string input = Console.ReadLine();
            int newInput = int.Parse(input);
            return newInput;
        }
        //public static int IndexOf(string [] Array)
        //{
        //    int input = int.Parse(GetInput());
        //    return int.Parse(Array[0]);
        //}
        static void Main(string[] args)
        {
            bool again = true;
            bool doAgain = true;
            bool repeat = true;
            bool start = true;
            bool again2 = true;
            bool doAgain2 = true;

            string[] name =
            {
                "",
                "Elisa",
                "Owen",
                "Agnes",
                "Mike",
                "Sharon",
                "Tony",
                "Abi",
                "Linda",
                "Jim",
                "Scott"
            };
            string[] age =
            {
                "",
                "36",
                "3",
                "1",
                "67",
                "66",
                "29",
                "28",
                "60",
                "67",
                "57"
            };
            string[] color =
            {
                "",
                "Pink",
                "Blue",
                "Yellow",
                "Red",
                "Green",
                "Navy",
                "Maize",
                "Purple",
                "Black",
                "Grey"
            };
            string[] city =
            {
                "",
                "Chicago",
                "Los Angeles",
                "New Orleans",
                "New York",
                "Dublin",
                "Austin",
                "Seattle",
                "Detroit",
                "Toronto",
                "Vancouver"
            };
            string[] options =
            {
                "",
                "Favorite Food",
                "Current Age",
                "Favorite City",
                "Favorite Color"
            };
            string[] food =
            {
                "",
                "Pasta",
                "Chicken Nuggets",
                "Yogurt",
                "Chicken",
                "Salmon",
                "Burgers",
                "Cheesy Potatoes",
                "Desert",
                "Pizza",
                "Breakfast"
            };
            string[] hometown =
            {
                "",
                "Minneapolis",
                "Ann Arbor",
                "Ann Arbor",
                "Wayne",
                "Dearborn",
                "Detroit",
                "Marquette",
                "Canada",
                "Detroit",
                "Detroit"
            };
            Console.WriteLine("Let me tell you about someone in the class!\n\n--------------------------------------------------\n");
            Console.WriteLine("Please choose from one of the following students:\n");
            //print user corresponding number and name associations
            //while (start)
            //{
            for (int index = 1; index < name.Length; index++)
            {
                string s = name[index];
                Console.WriteLine(index + " for " + s);
            }
            while (again)
            {
                try
                {
                    int choice = GetInput();
                    if (choice == 0)
                    {
                        Console.WriteLine("Please enter a number from the list above\n");
                        again = true;
                    }
                    else
                    {
                        Console.WriteLine($"\n{name[choice]} is from {hometown[choice]}.\n");
                        Console.WriteLine($"\nWould you like to learn more about {name[choice]}?  Please enter either 'Y' or 'N'");
                        again = false;
                    }

                    while (doAgain && again == false)
                    {
                        string keepGoing = Console.ReadLine();
                        if (keepGoing == "n" || keepGoing == "N")
                        {
                            Console.WriteLine("\nThanks for the chat.  Have a great day!\n");
                            return;
                        }
                        else if (keepGoing == "y" || keepGoing == "Y")

                        {
                            Console.WriteLine("\nGreat!  Please choose from the following:\n");
                            doAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                            doAgain = true;
                        }
                    }
                    while (repeat && again == false)
                    {
                        for (int index = 1; index < options.Length; index++)
                        {
                            string s = options[index];
                            Console.WriteLine(index + " for " + s);
                        }
                        repeat = false;
                        try
                        {
                            int choice2 = GetInput();
                            if (choice2 == 0)
                            {
                                Console.WriteLine("\nPlease enter a number from the list below:\n");
                                again = true;
                            }
                            if (choice2 == 1)
                            {
                                Console.WriteLine($"{name[choice]}'s favorite food is {food[choice]}.");
                                Console.WriteLine($"Would you like to learn more about {name[choice]}. Please enter either 'Y' or 'N'");
                                again = false;
                            }
                            if (choice2 == 2)
                            {
                                Console.WriteLine($"{name[choice]} is {age[choice]} years old.");
                                Console.WriteLine($"Would you like to learn more about {name[choice]}. Please enter either 'Y' or 'N'");
                                again = false;
                            }
                            if (choice2 == 3)
                            {
                                Console.WriteLine($"{name[choice]}'s favorite city is {city[choice]}.");
                                Console.WriteLine($"Would you like to learn more about {name[choice]}. Please enter either 'Y' or 'N'");
                                again = false;
                            }
                            if (choice2 == 4)
                            {
                                Console.WriteLine($"{name[choice]}'s favorite color is {color[choice]}.");
                                Console.WriteLine($"Would you like to learn more about {name[choice]}. Please enter either 'Y' or 'N'");
                                again = false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number from the list above\n");
                            repeat = true;
                            again = false;
                        }
                        while (doAgain2 && again2 == false)
                        {
                            string keepGoing = Console.ReadLine();
                            if (keepGoing == "n" || keepGoing == "N")
                            {
                                Console.WriteLine("\nOK!\n");
                            }
                            else if (keepGoing == "y" || keepGoing == "Y")
                            {
                                Console.WriteLine("\nGreat!  Please choose from the following:\n");
                                doAgain2 = false;
                                again2 = false;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                                doAgain2 = true;
                                again2 = false;
                            }
                        }
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number \n");
                    again = true;
                }
                //Console.WriteLine($"Would you like to learn more?");
            }
            //}
        }
    }
}