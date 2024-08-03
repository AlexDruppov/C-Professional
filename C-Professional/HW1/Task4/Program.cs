using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Word> dictionary = new Dictionary<string, Word>
            {
                {"книга", new Word("book", "buch") },
                {"стіл", new Word("table", "Tabelle") },
                {"машина", new Word("car", "auto") },
            };

            string dictionaryWord = "машина";

            if (dictionary.TryGetValue(dictionaryWord, out Word word)) 
            {
                Console.WriteLine($"{dictionaryWord} - {word.English}");
            }
            
            if (dictionary.TryGetValue(dictionaryWord, out word))
            {
                Console.WriteLine($"{dictionaryWord} - {word.German}");
            }

            Console.ReadKey();
        }
    }
}
