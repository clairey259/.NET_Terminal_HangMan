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
                Console.WriteLine("Lets Play HangMan");
                //generate random word
                string currentWord = Words.RandomWord();
                
                //show word length and number of lives 
                Words.BlankWord(currentWord);
                Console.WriteLine();
                Lives currentLives= new Lives(); 
                currentLives.ShowLives();

                //guess a letter
                Console.WriteLine("Guess a Letter:");
                string currentGuess = Console.ReadLine();


            }
    }
}