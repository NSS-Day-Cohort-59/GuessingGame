using System;





Console.WriteLine("Guess the Secret Number!");
   
// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
int secretNumber = new Random().Next(1, 101);
Console.WriteLine(secretNumber);

// The prompt should display the number of guesses the user has left.
for (int i = 4; i >= 1; i--)
{  
    Console.Write($"Your Guess (Guesses left: {i}): ");
    string answer = Console.ReadLine();
    if (secretNumber == int.Parse(answer)) 
    {
        Console.WriteLine("correct!");
        break;
    }
    else {
        Console.WriteLine("Nope!");
    }
}