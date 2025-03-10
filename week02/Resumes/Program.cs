using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Product Support";
        job1._startYear = 2018;
        job1._endYear = 2020;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Boostability";
        job2._jobTitle = "Customer Support";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Katie Morris";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}