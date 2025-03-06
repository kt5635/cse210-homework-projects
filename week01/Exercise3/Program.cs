using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

        int guess= -1;

        while(guess != randomNumber)  
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if(guess < randomNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > randomNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess == randomNumber)
        {
            Console.WriteLine("Congratulations, you guessed right!");
        }

        }


    }
}