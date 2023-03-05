using System.Collections;
using System.Net.Http.Headers;

namespace Library
{
    class Words
    {
        private static string[] wordsArr = { "hello", "radiology", "stick", "book", "telephone", "feburary" };
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
        public static async Task<string> RetrieveWordAsync()
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            return await ProcessRepositoriesAsync(client);
        }

        private static async Task<string> ProcessRepositoriesAsync(HttpClient client)
        {
            var json = await client.GetStringAsync(
                "https://random-word-api.herokuapp.com/word");
            //https://random-word-api.herokuapp.com/word
            //https://random-word.ryanrk.com/api/en/word/random
            
            string word = json;
            char[] charsToTrim = { '"', '[', ']' };
            string cleanedWord = (word.TrimStart(charsToTrim).TrimEnd(charsToTrim));
            return cleanedWord;
        }


    }
}
