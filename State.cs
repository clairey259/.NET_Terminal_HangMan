
using Spectre.Console;

namespace Functionality
{
    class State
    {
        string word;
        public int lives;
        List<string> guesses;

        //constructor
        public State(string newWord, int amountOfLives)
        {
            word = newWord;
            guesses = new List<string>();
            lives = amountOfLives;
        }

        //methods
        public void AddGuess(string guess)
        {
            guesses.Add(guess);
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
            if (guesses.Contains(i))
            {
                AnsiConsole.Markup($"[red]You've already guessed {i}\n[/]");
            }
            else if (word.Contains(i))
            {
                AnsiConsole.Markup($"[darkturquoise]Correct\n\n[/]");
            }
            else
            {
                AnsiConsole.Markup("[darkgreen]Incorrect" + $"\n\n[/]");
                lives--;
            }
        }

        public bool IsGameWon() {
            foreach (char w in word.ToArray()) 
            {
                if (!guesses.Contains(w.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsGameLost()
        {
            return lives <= 0;
        }

        private bool IsGameFinished()
        {
            return IsGameLost() || IsGameWon();
        }

        public bool IsGameRunning()
        {
            return !IsGameFinished();
        }
    }
}