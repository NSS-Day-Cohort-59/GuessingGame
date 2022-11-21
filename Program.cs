using System;



    // Display a message to the user asking them to guess the secret number.
Console.WriteLine("Guess the Secret Number!");
   
    // Display a prompt for the user's guess.
Console.Write("Your Guess: ");
    // Take the user's guess as input and save it as a variable.
string answer = Console.ReadLine();   
    // Display the user's guess back to the screen.
Console.WriteLine($"Your Guess: {answer}");
