using System;

namespace Methods_Exercise_1_2
{
    internal class Program
    {
        public static void ShortStory()
        {
            Console.WriteLine("Hello, I would like to create a customized short story for you!");
            Console.WriteLine("Please answer the follwing questions");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Okay! Thank you for this information. Give me a second...");
            Console.WriteLine($"It was Christmas morning for {name}. You may be {age} years old but you were excited as ever." +
                $"Yet, there were no presents under the tree. Wait, whats that outside. The sounds of a {favoriteAnimal}! You got a {favoriteAnimal}" +
                $" for Christmas. You were as happy as could be!");
        }

        public static int Addition(int num1, int num2)
        { return num1 + num2; }

        public static int Multiply(int num1, int num2) 
        { return num1 * num2; }

        public static int Subtraction(int num1, int num2)
        { return num1 - num2; }

        public static int Division(int num1, int num2)
        { return num1 / num2; }


        static void Main(string[] args)
        {
            ShortStory();
            Addition(10, 2);
            Multiply(16, 87);
            Subtraction(65, 32);
            Division(5, 1);
        }
    }
}

    