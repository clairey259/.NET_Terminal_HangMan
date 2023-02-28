using System.Collections;

namespace Library
{
    class Words
    {
        static string[] wordsArr = {"hello", "radiology", "stick", "book", "telephone", "feburary"};
        //https://random-word-api.herokuapp.com/word 

        private static int LengthOfArr(string[] arr) {
            int length = arr.Length;
            return length;
        } 

        public static string RandomWord() {
            Random rdn = new Random(); 
            int num = rdn.Next(LengthOfArr(wordsArr));
            Console.WriteLine(wordsArr[num]);
            return wordsArr[num];

        }

        public static void BlankWord(string word) {
            char[] wordArr = word.ToArray();
            foreach (char i in wordArr)
            {
                Console.Write("_ ");
            }
        }
    }
}