using System;

namespace CaesarsCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter your secret message");
            string message = Console.ReadLine();
            message = message.ToLower();

            char[] secretMessage = message.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            //value to shift our character by to point to its next character
            int key = 3;

            for(int i=0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);

                int newLetterPosition = (letterPosition + key) % 26;

                letter = alphabet[newLetterPosition];
                encryptedMessage[i] = letter;
            }

            String codedMessage = String.Join("", encryptedMessage);
            Console.WriteLine($"{message} becomes {codedMessage} using cipherKey of {key}");

        }
    }
}