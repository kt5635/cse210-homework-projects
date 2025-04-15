// Showing creativity: Added a method that tracks the score and "levels" up as point threasholds are reached.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}