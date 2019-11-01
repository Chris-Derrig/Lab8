using System;

namespace Lab8
{
    class Program
    {
        //public static string GetIndex(string input, Array);
        //{
            
        //}

        static void Main(string[] args)
        {
            bool again = true;
            //declare students
            string[] name = {
                "",
                "Elisa",
                "Owen",
                "Agnes",
                "Mike",
                "Sharon"
            };
            //declare favorite foods
            string[] food = {
                "",
                "Pasta",
                "Chicken Nuggets",
                "Yogurt",
                "Chicken",
                "Salmon"
            };
            //declare hometown
            string[] hometown = {
                "",
                "Minneapolis",
                "Ann Arbor",
                "Ann Arbor",
                "Wayne",
                "Dearborn"
            };

            Console.WriteLine("Let me tell you about someone in the class!\n----------");
            Console.WriteLine("Please choose from one of the following students\n");
            //print user corresponding number and name associations
            for (int index = 1; index < name.Length; index++)
            {
                string s = name[index];
                Console.WriteLine(index + " for " + s);
            }
            string input = Console.ReadLine();
            int newInput = int.Parse(input);
            
            while (again)
            {
                if (newInput > name.Length || newInput == 0)
                {
                    Console.WriteLine("Please enter a number from the list above");
                }
                
                Console.WriteLine($"{name[newInput]} is from {hometown[newInput]}.  Their favorite food is {food[newInput]}");
            }
            again = false;
        }
    }
}
