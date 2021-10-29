using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine(" Hey welcome to my number guessing game!");
            //Console.WriteLine("See if you can guess the correct number!");
            //Console.WriteLine(" What is the upper limit for the range of the number?");

            //var userResponse = Console.ReadLine();

            //var upperLimit = int.Parse(userResponse);




            //var random = new Random();
            //var number = random.Next(1, upperLimit);

            //Console.WriteLine("Input your guess: ");

            //var guess = int.Parse(Console.ReadLine());

            //if (guess > number)
            //{
            //    Console.WriteLine("Your guess is way too high! Try again");
            //}
            //else if (guess < number)
            //{
            //    Console.WriteLine("Your guess is way too low!! Try again");
            //}
            //else
            //{
            //    Console.WriteLine("Your right on the mark!! Great guess!");

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Music":
                    Console.WriteLine("Music is an interesting subject!");
                    break;
                case "English":
                    Console.WriteLine("English is an enjoyable subject!");
                    break;
                case "Math":
                    Console.WriteLine("Math is a challenging subject!!");
                    break;
                default:
                    Console.WriteLine($"UGHHH I havent taken that subject yet.  {subject} sounds interesting!!");
                    break;
            }






        }
        }
    }

