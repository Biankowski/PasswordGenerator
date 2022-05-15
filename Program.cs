// Simple Password Ganerator created by Rodrigo Bianchini.
// This was made for educational purposes.
using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WordList that will be usend to generate the Password.
            // If you wish to add any other special characters to your password, just insert them in this array.
            string[] wordList = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "{", "}", "[", "]", "%", "$", "#", "@", "!", "&", "*", };

            Generator generate = new Generator();

            // This continueChoice variable is used to track the program loop at the end.
            bool continueChoice = true;
            Console.WriteLine("Welcome to Rodrigo's Password Generator! Choose the number of characters you want in your password.");
            Console.WriteLine();
            do
            {
                Console.Write("6 (weak); 12 (medium); 18 (Strong): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "6":
                        generate.WeakPassword(wordList);
                        Console.WriteLine();
                        Console.WriteLine("There you go! This password is very weak, never use it in real life.");
                        break;
                    case "12":
                        generate.MediumPassword(wordList);
                        Console.WriteLine();
                        Console.WriteLine("There you have it! This is a medium sized password, choose a larger one for a better protection.");
                        break;
                    case "18":
                        generate.StrongPassword(wordList);
                        Console.WriteLine();
                        Console.WriteLine("Excelent choice! This is a very strong password. Remember to use 2FA in all your accounts for extra protection ;). ");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Something went wrong! Try again.");
                        break;
                }
                Console.Write("Do you wish to generate another password? Y/n: ");
                string exit = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (exit == "y" || exit == "yes")
                {
                    continueChoice = true;
                }
                else if (exit == "n" || exit == "no")
                {
                    Console.WriteLine("Bye!");
                    continueChoice = false;
                }
                else
                {
                    Console.WriteLine("Something went wrong!");
                    continueChoice = false;
                }
            } while (continueChoice == true);

            Console.ReadLine();
        }
    }
}