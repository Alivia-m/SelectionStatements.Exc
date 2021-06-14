using System;

namespace SelectionStatements.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 13;

            Console.WriteLine("Try to guess my favorite number. Hint: it might bring bad luck");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            string subject = "social studies";

            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "social studies":
                    Console.WriteLine("Not bad, I prefer english though");
                    break;
                case "english":
                    Console.WriteLine("Right on!");
                    break;
                case "math":
                    Console.WriteLine("Yikes...");
                    break;
                case "science":
                    Console.WriteLine("Bill Nye, the science guy~");
                    break;
                case "sports":
                    Console.WriteLine("Sounds cool, are you trying to make a career out of it?");
                    break;

                default:
                    Console.WriteLine("Sounds boring");
                    break;
            }


            
            
            
            
        }   
    }
}
