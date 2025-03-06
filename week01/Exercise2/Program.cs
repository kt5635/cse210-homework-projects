using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string LetterGrade = "";

        if (grade >= 90)
        {
            LetterGrade = "A";
        }
        else if (grade <90 && grade >= 80)
        {
            LetterGrade = "B";
        }
        else if (grade <80 && grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (grade <70 && grade >= 60)
        {
            LetterGrade = "D";
        }
        else {
            LetterGrade = "F";
        }

        string sign = "";

        if (LetterGrade != "A" && LetterGrade != "F")
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 <= 3)
            {
                sign = "-";
            }
        }
        else if (LetterGrade == "A" && grade <= 93)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {LetterGrade}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congatulations! You have passed the class!");
        }
        else 
        {
            Console.WriteLine("Don't worry you will pass next time!");
        }

    }
}
