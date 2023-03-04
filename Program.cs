using Functionality;
using Library;
using Spectre.Console;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Markup($"[bold darkblue]\n\n" + "Lets Play HangMan" + $"\n\n[/]");
            //generate random word and create instance State
            var currentWord = Words.RetrieveWordAsync().Result;
            State currentState = new State(currentWord, 5);
            
            while (currentState.IsGameRunning())
            {
                //show word length and number of lives
                currentState.DisplayWord(currentWord);
                Console.WriteLine($"\n\nCurrent Lives: {currentState.lives}\n");
                
                //guess a letter, update lives, update guesses
                Console.Write("Guess a Letter: ");
                string currentGuess = Console.ReadLine();
                currentState.UpdateLives(currentGuess);
                currentState.AddGuess(currentGuess);
            }

            if (currentState.IsGameWon())
            {
                AnsiConsole.Markup($"[bold darkturquoise]\n\n" + $"Congratulations you have WON with {currentState.lives} lives remaining" + "\n" + ":)[/]"+ $"\n\n\n");
            }
            else
            {
                AnsiConsole.Markup($"[bold darkgreen]Sorry you have LOST" + $"\n" +":([/]"+ $"\n\n\n");
            }
            Console.Write("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}