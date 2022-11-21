using System;



Console.WriteLine("Guess the Secret Number!");
   
int secretNumber = 42;

// Give the user four chances to guess the number.
for (int i = 1; i <= 4; i++)
{  
    Console.Write("Your Guess: ");
    string answer = Console.ReadLine();
    if (secretNumber == int.Parse(answer)) 
    {
        Console.WriteLine("correct!");
    }
    else {
        Console.WriteLine("Nope!");
    }
}