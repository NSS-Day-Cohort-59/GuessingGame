using System;




Console.WriteLine("Guess the Secret Number!");
   
int secretNumber = 42;

for (int i = 1; i <= 4; i++)
{  
    // Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
    Console.Write($"Your Guess ({i}): ");
    string answer = Console.ReadLine();
    if (secretNumber == int.Parse(answer)) 
    {
        // End the loop early if the user guesses the correct number.
        Console.WriteLine("correct!");
        break;
    }
    else {
        Console.WriteLine("Nope!");
    }
}