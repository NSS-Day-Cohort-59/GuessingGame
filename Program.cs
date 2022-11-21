using System;
using System.Collections.Generic;


// Prompt the user for a difficulty level before they are prompted to guess the number.
Console.Write("Difficulty? (1 - easy,2 - medium, 3 - hard, 4 - super hard");
int difficulty = int.Parse(Console.ReadLine());

// in JS: const difficulties = [8,6,4]
List<int> difficulties = new List<int> {8, 6, 4, 2}; 
int numberOfGuesses = difficulties[difficulty - 1];

Console.WriteLine("Guess the Secret Number!");
   
int secretNumber = new Random().Next(1, 101);

for (int i = numberOfGuesses; i >= 1; i--)
{  
    Console.Write($"Your Guess (Guesses left: {i}): ");
    int answer = int.Parse(Console.ReadLine());
    if (secretNumber == answer) 
    {
        Console.WriteLine("correct!");
        break;
    }
    else {
        Console.WriteLine(secretNumber > answer ? "too low!" : "too high!");
    }
}