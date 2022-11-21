using System;



Console.WriteLine("Guess the Secret Number!");
   
    // Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
int secretNumber = 42;
Console.Write("Your Guess: ");
string answer = Console.ReadLine();
    // Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
if (secretNumber == int.Parse(answer))
{
    Console.WriteLine("correct!");
}
else {
    Console.WriteLine("Nope!");
}