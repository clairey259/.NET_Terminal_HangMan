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
            Console.WriteLine(num);
            return wordsArr[num];

        }
    }
}