using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "English":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before.  {subject} sounds fun!");
                    break;


            }
            var answer = 4;
            var repsonse = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

          
        }
    }
}
