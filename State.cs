using Library;
using System.Collections;

namespace Functionality
{
    class State
    {
        string word;
        public int lives;
        List<string> guesses;
        List<string> incorrectGuesses;
        public List<string> correctGuesses;


        //constructor
        public State(string newWord, int amountOfLives)
        {
            word = newWord;
            guesses = new List<string>();
            incorrectGuesses = new List<string>();
            lives = amountOfLives;
            correctGuesses = new List<string>();
        }


        //methods
        public void AddGuess(string guess)
        {
            guesses.Add(guess);
            if (word.Contains(guess) == false)
            {
                incorrectGuesses.Add(guess);
            }
            else correctGuesses.Add(guess);
        }

        public void DisplayWord(string word)
        {
            char[] wordArr = new char[] { };
            wordArr = word.ToCharArray();
            foreach (char item in wordArr)
            {
                string i = item.ToString();
                if (guesses.Contains(i))
                {
                    Console.Write($"{item} ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine($"\n");

        }

        public void UpdateLives(string i)
        {
            if (word.Contains(i))
            {
                Console.WriteLine($"Correct\n\n");
            }
            else
            {
                Console.WriteLine("Incorrect" + $"\n\n");
                lives --;
            }
        }
    }
}