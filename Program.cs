using Functionality;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n" + "Lets Play HangMan" + $"\n\n");
            
            //generate random word and create instance State
            string currentWord = Words.RandomWord();
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
                Console.WriteLine($"\n\n" + $"Congratulations you have WON with {currentState.lives} lives remaining" + "\n" + ":)");
            }
            else
            {
                Console.WriteLine($"Sorry you have LOST" + $"\n" +":(");
            }
        }
    }
}