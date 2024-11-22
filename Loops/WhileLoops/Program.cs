/*2. Number Guessing Game (While Loop)
Description: Build a game where the computer generates a random number between 1 and 100, and the player has to guess it. Each time the player guesses incorrectly, the program gives a hint whether the guess is too high or too low.

Requirements:

Use a while loop that runs until the player guesses the correct number.
After each guess, the program should inform the player if the guess is too high or too low.
Keep track of the number of attempts and display it when the player guesses correctly.
Allow the player to quit the game early (ask if they want to keep playing after each guess).
*/

using System.Threading.Channels;
bool playing = true;
bool gameon = true;
int guess;

Console.WriteLine("Number Guessing Game");
Console.WriteLine("--------------------");
Console.WriteLine(@"
    Build a game where the computer generates a random number between 1 and 100,
    and the players has to guess it. Each time the player guesses incorrectly, 
    the program gives a hint whether the guess is too high or too low.");
Console.WriteLine("Press any key to play.");
Console.ReadLine();


while (gameon) { 
Console.Clear();

Random random = new Random();
int number = random.Next(1, 101);

    while (playing) { 
        Console.WriteLine("Guess the number between 1 and 100.");

        while (!(int.TryParse(Console.ReadLine() , out guess )) ||( guess>100 || guess<1))
        {
        Console.WriteLine("Please make sure it is an integer between 1 and 100");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Guess the number between 1 and 100.");
    }
        if (guess > number)
        {
        Console.WriteLine("The guess it too high.Please try again or press q to quit.");
            if (Console.ReadLine() == "q")
            {
                gameon = false;
                playing = false;
                
            }
        }
        else if(guess < number)
        {
        Console.WriteLine("The guess it too low.Please try again or press q to quit.");
            if (Console.ReadLine() == "q")
            {
                gameon = false;
                playing = false;
            }
        }
        else if(guess == number)
        {
        Console.WriteLine("Winner. You got it right.");
        Console.ReadLine();
            Console.WriteLine("Press any key to play again or q to quit.");

            if (Console.ReadLine() == "q")
                {
                gameon = false;
            }
            break;
        }
    }
}






















