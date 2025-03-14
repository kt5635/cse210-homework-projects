using System;
using System.Collections.Generic;

public class PromptGenerator {
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts.Add("What are three things you are grateful for today, and why?");
        _prompts.Add("What is one area in your life where you'd like to improve? What steps can you take to get there?");
        _prompts.Add("What is something you’ve been avoiding, and why do you think you’ve been avoiding it?");
        _prompts.Add("Describe a situation that made you feel proud of yourself. What did it teach you about your strengths?");
        _prompts.Add("If you could live anywhere in the world for a year, where would it be and why?");
        _prompts.Add("Write about a person who has positively impacted your life and why.");
        _prompts.Add("What’s a lesson you’ve learned from a difficult relationship?");
        _prompts.Add("What is one small act of kindness you could do today for someone else?");
        _prompts.Add("How did you spend your time today? Is there something you would change if you could?");
        _prompts.Add("What’s one thing you learned today, either about yourself or the world around you?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}