using System;

namespace PasswordGenerator
{
    internal class Generator
    {
        // Function to generate a Weak Password
        public void WeakPassword(string[] wordList)
        {
            string[] _wordList = wordList;

            Random random = new Random();
            string passWord = "";

            for (int i = 0; i < wordList.Length; i++)
            {
                int index = random.Next(wordList.Length);
                passWord += wordList[index];
                if (passWord.Length >= 6)
                {
                    break;
                }
            }
            Console.WriteLine(passWord);
        }
        // Function to generate a Medium Password
        public void MediumPassword(string[] wordList)
        {
            string[] _wordList = wordList;

            Random random = new Random();
            string passWord = "";

            for (int i = 0; i < wordList.Length; i++)
            {
                int index = random.Next(wordList.Length);
                passWord += wordList[index];
                if (passWord.Length >= 12)
                {
                    break;
                }
            }
            Console.WriteLine(passWord);
        }
        // Function to generate a Strong Password
        public void StrongPassword(string[] wordList)
        {
            string[] _wordList = wordList;

            Random random = new Random();
            string passWord = "";

            for (int i = 0; i < wordList.Length; i++)
            {
                int index = random.Next(wordList.Length);
                passWord += wordList[index];
                if (passWord.Length >= 18)
                {
                    break;
                }
            }
            Console.WriteLine(passWord);
        }
    }
}