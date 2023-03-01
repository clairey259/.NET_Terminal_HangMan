using Functionality;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n" + "Lets Play HangMan" + $"\n\n");
            //generate random word and create instance of lives
            string currentWord = Words.RandomWord();
            State currentState = new State(currentWord, 5);
            
            while (currentState.IsGameRunning())
            {
                //show word length and lives
                currentState.DisplayWord(currentWord);
                Console.WriteLine($"\n\nCurrent Lives: {currentState.lives}\n");
                //Console.WriteLine($"Current Lives: {5 - currentState.incorrectGuesses.Count()}");


                //guess a letter and update lives
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