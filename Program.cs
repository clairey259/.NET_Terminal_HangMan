using System.Collections;
using System.Linq;
using Functionality;
using Game;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                start with 5 lives and length of word shown as _ _ _
                read console line and compare to letters 
                if matches show letter and adds to guessed letters arr and correct letter array
                if no matches life lost and adds to guessed letter arr 
                when lives == 0 then write to console Game over OR if all letters has been guessed
            */
            Console.WriteLine($"\n\n" + "Lets Play HangMan" + $"\n\n");
            //generate random word and create instance of lives
            string currentWord = Words.RandomWord();
            State currentState = new State(currentWord, 5);
            
            while (currentState.lives > 0 | currentState.correctGuesses.Count != currentWord.Length)
            {
            //show word length and lives
            currentState.DisplayWord(currentWord);
            Console.WriteLine($"\n\nCurrent Lives: {currentState.lives}\n");
            //Console.WriteLine($"Current Lives: {5 - currentState.incorrectGuesses.Count()}");


            //guess a letter and update lives
            Console.Write("Guess a Letter: ");
            string currentGuess = Console.ReadLine();
            currentState.AddGuess(currentGuess);
            currentState.UpdateLives(currentGuess);

            }

            if (currentState.lives > 0)
            {
                Console.WriteLine ($"\n\n" + $"Congratulations you have WON with {currentState.lives} remaining" + "\n" + ":)");
            }
            Console.WriteLine($"Sorry you have LOST" + $"\n" +":(");
        }
    }
}