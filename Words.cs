using System.Collections;

namespace Library
{
    class Words
    {
        public static string[] wordsArr = { "hello", "radiology", "stick", "book", "telephone", "feburary" };
        //https://random-word-api.herokuapp.com/word 

        private static int LengthOfArr(string[] arr)
        {
            int length = arr.Length;
            return length;
        }

        public static string RandomWord()
        {
            Random rdn = new Random();
            int num = rdn.Next(LengthOfArr(wordsArr));
            return wordsArr[num];

        }

        public static void BlankWord(string word)
        {
            char[] wordArr = word.ToArray();
            foreach (char i in wordArr)
            {
                Console.Write("_ ");
            }
        }

        public static bool ItMatches(char x, char[] word)
        {
            IEnumerable wordArr = word.ToArray();
            foreach (char i in wordArr)
            {
                if (i == x)
                {
                    Console.WriteLine("Correct!");
                    return true;
                } 
                else
                {
                    Console.WriteLine("Incorrect!");
                    return false;
                }
            
            }
            return false;        
            }
    }
}
