using System; 

namespace Capstone_Lab_5___Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Please enter a word to be translated to Pig Latin! ");

                string[] usersWords = Console.ReadLine().ToLower().Split(" ");

                foreach(string word in usersWords)
                {
                    ToPigLatin(word);
                }
                

                Console.WriteLine("would you like to translate another word? y/n? ");

                string y = Console.ReadLine().ToLower();

                if (y == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }


            }

            Console.WriteLine("Goodbye! ");
                 //hint: you loop through the vowels array and check the starting letter of the word against them          
        }

        private static void ToPigLatin(string usersWord)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int index = usersWord.IndexOfAny(vowels);
            if (index == -1)
            {
                index = 0; 
            }

            string firstLetter = usersWord.Substring(0, index);
            string restOfLetters = usersWord.Substring(index);


            string newWord = restOfLetters + firstLetter + "ay";


            string newWord2 = usersWord + "way";

            if (index == 0)
            {
                Console.WriteLine(newWord2);
            }
            else if (index != 0)
            {
                Console.WriteLine(newWord);
            }
        }
    }
}
