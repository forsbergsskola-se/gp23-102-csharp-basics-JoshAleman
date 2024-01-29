// We set the quantity to 24
int matches = 24;
// We print a welcome message
Console.WriteLine("Output:Welcome to Nim!");
// The initial display of the total amount is printed
Console.WriteLine($"Output:{new string('|', matches)} ({matches})");

// This is the label to mark the beginning of the player's turn
PlayerTurn:
// We ask the player to indicate how much amount he wants to withdraw.
Console.WriteLine("Output:How many matches do you want to draw?");
// This is the variable to store the amount the player wants to withdraw
int playerDraw;

// We try to convert the user input to an integer
if (int.TryParse(Console.ReadLine(), out playerDraw))
    
{
    // If the conversion fails, an error message is printed and it is back to the player's turn
    Console.WriteLine("Output:Invalid input. Please enter a valid number.");
    goto PlayerTurn;
}
// We check if the amount the player wants to withdraw is valid between 1 and 3
if (playerDraw < 1 || playerDraw > 3 || playerDraw > matches)
{
    // If the amount is invalid, an error message is printed and it is back to the player's turn
    Console.WriteLine("Output:Invalid move. Please enter a valid number of matches to draw.");
    goto PlayerTurn;
}
// The number of matches is updated by subtracting those removed by the player
matches -= playerDraw;
// We print the updated visualization.
Console.WriteLine($"Output:{new string('|', matches)} ({matches})");

// Here we check if the player has removed the last match
if (matches == 0)
{
    // If so, we print a defeat message and skip to the end of the game
    Console.WriteLine("Output:You drew the last match. You lose.");
    goto EndGame;
}
// A random number of matches is generated that the AI removes (between 1 and 3)
int aiDraw = new Random().Next(1, Math.Min(4, matches + 1));
// The number of matches is updated by subtracting those removed by the AI
matches -= aiDraw;

// We print the updated display of matches and the remaining quantity
Console.WriteLine($"Output:The AI draws {aiDraw} matches.");
Console.WriteLine($"Output:{new string('|', matches)} ({matches})");

// We check if the AI has removed the last match
if (matches == 0)
{
    // If so, a victory message is printed to the user and skips to the end of the game, the AI loses.
    Console.WriteLine("Output:Congratulations! You win!");
    goto EndGame;
}
// Returns to the player's turn to continue the game
goto PlayerTurn;

// Label to mark the 
EndGame:
Console.WriteLine("Output:Game over.");