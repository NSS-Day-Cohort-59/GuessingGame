using System;
using System.Collections.Generic;

// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
Console.Write("Difficulty? (1 - easy,2 - medium, 3 - hard, 4 - cheater: ");
int difficulty = int.Parse(Console.ReadLine());

List<int> difficulties = new List<int> {8, 6, 4, 0}; 
int numberOfGuesses = difficulties[difficulty - 1];

Console.WriteLine("Guess the Secret Number!");
   
int secretNumber = new Random().Next(1, 101);

int guessesLeft = numberOfGuesses;
while (difficulty == 4 || guessesLeft > 0)
{  
    Console.Write($"Your Guess (Guesses left: {(difficulty == 4 ? "INFINITE!!!" : guessesLeft)}): ");
    int answer = int.Parse(Console.ReadLine());
    if (secretNumber == answer) 
    {
        Console.WriteLine("correct!");
        break;
    }
    else {
        Console.WriteLine(secretNumber > answer ? "too low!" : "too high!");
    }

    guessesLeft--;
}