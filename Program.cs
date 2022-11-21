using System;





Console.WriteLine("Guess the Secret Number!");
   
int secretNumber = new Random().Next(1, 101);
Console.WriteLine(secretNumber);

for (int i = 4; i >= 1; i--)
{  
    Console.Write($"Your Guess (Guesses left: {i}): ");
    int answer = int.Parse(Console.ReadLine());
    if (secretNumber == answer) 
    {
        Console.WriteLine("correct!");
        break;
    }
    else {

        // Inform the user if their guess was too high or too low, when they guess incorrectly.
        Console.WriteLine(secretNumber > answer ? "too low!" : "too high!");
    }
}