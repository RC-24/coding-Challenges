using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetCipher {
    class Program {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        const string sectionDivider = "\n----------------";

        [STAThread]
        static void Main(string[] args) {
            // Prompt user to choose between encoding and decoding a message
            Console.WriteLine(String.Format("Select an option:\n1 - Encode a message\n2 - Decode a message{0}", sectionDivider));
            var input = Console.ReadKey();

            switch (input.KeyChar) {
                case '1':
                    EncodeMessage();
                    break;
                case '2':
                    DecodeMessage();
                    break;
                default:
                    Console.WriteLine(String.Format("{0}\nInvalid input detected. The program will now close.", sectionDivider));
                    System.Threading.Thread.Sleep(3000);
                    return;
            }
        }

        private static void EncodeMessage() {
            Console.WriteLine(String.Format("{0}\nPlease enter the message you wish to encode:", sectionDivider));
            string messageToEncode = GetMessage();

            Console.WriteLine(String.Format("{0}\nPlease enter your secret keyword:", sectionDivider));
            string keyword = GetKeyword();

            string encodedMessage = GetEncodedMessage(messageToEncode, keyword);

            Clipboard.SetText(encodedMessage);
            Console.WriteLine(String.Format("{0}\nYour encoded message is:\n{1}\nYour encoded message has been copied to the clipboard", 
                sectionDivider, encodedMessage));
            System.Threading.Thread.Sleep(5000);
        }

        private static void DecodeMessage() {
            Console.WriteLine(String.Format("{0}\nPlease enter the message you wish to decode:", sectionDivider));
            string messageToDecode = GetMessage();

            Console.WriteLine(String.Format("{0}\nPlease enter your secret keyword:", sectionDivider));
            string keyword = GetKeyword();

            string decodedMessage = GetDecodedMessage(messageToDecode, keyword);

            Console.WriteLine(String.Format("{0}\nYour decoded message is:\n{1}",
                sectionDivider, decodedMessage));
            System.Threading.Thread.Sleep(5000);
        }

        private static string GetMessage() {
            string message = "";

            // Don't show the keyword in the console window. Show * symbols instead
            while (true) {
                var input = Console.ReadKey(false);

                // Exit when enter button is pressed
                if (input.Key == ConsoleKey.Enter) {
                    return message;
                }

                message += input.KeyChar;

                // Only letters are valid for the message (no spaces, numbers or special charcters)
                if (!alphabet.Contains(input.KeyChar)) {
                    Console.WriteLine("\nInvalid input detected. The message can only contain letters.");
                    message = "";
                }
            }
        }

        private static string GetKeyword() {
            string keyword = "";

            // Don't show the keyword in the console window. Show * symbols instead
            while (true) {
                var input = Console.ReadKey(true);

                // Exit when enter button is pressed
                if(input.Key == ConsoleKey.Enter) {
                    return keyword;
                }

                Console.Write("*");
                keyword += input.KeyChar;

                // Only letters are valid for this cipher (no spaces, numbers or special charcters)
                if (!alphabet.Contains(input.KeyChar)) {
                    Console.WriteLine("\nInvalid input detected. The keyword can only contain letters.");
                    keyword = "";
                }
            }
        }

        private static string GetEncodedMessage(string message, string keyword) {
            string encodedMessage = "";
            string trimmedKeyword = GetTrimmedKeyword(keyword, message.Length);

            for(int i = 0; i < message.Length; i++) {
                string alphabetRowStartingWithLetter = GetAlphabetRowStartingWithLetter(trimmedKeyword[i]);

                encodedMessage += alphabetRowStartingWithLetter[alphabet.IndexOf(message[i])];
            }

            return encodedMessage;
        }

        private static string GetTrimmedKeyword(string keyword, int messageLength) {
            if(keyword.Length == messageLength) {
                return keyword;
            }
            else if(keyword.Length > messageLength) {
                return keyword.Substring(0, messageLength);
            }
            else {
                int currentIndex = 0;
                while(keyword.Length < messageLength) {
                    keyword += keyword[currentIndex];
                    currentIndex++;
                }
                return keyword;
            }
        }

        // Returns a string containing the alphabet in order but starting at the specified letter
        // For example. If the letter g is supplied as the argument then the output will be: ghijklmnopqrstuvwxyzabcdef
        private static string GetAlphabetRowStartingWithLetter(char letter) {
            string alphabetRow = "";
            int letterIndex = alphabet.IndexOf(letter);

            alphabetRow += alphabet.Substring(letterIndex, 26 - letterIndex);

            int i = 0;
            while(alphabetRow.Length < 26) {
                alphabetRow += alphabet[i];
                i++;
            }

            return alphabetRow;
        }

        private static string GetDecodedMessage(string message, string keyword) {
            string decodedMessage = "";
            string trimmedKeyword = GetTrimmedKeyword(keyword, message.Length);

            for (int i = 0; i < message.Length; i++) {
                string alphabetRowStartingWithLetter = GetAlphabetRowStartingWithLetter(trimmedKeyword[i]);

                decodedMessage += alphabet[alphabetRowStartingWithLetter.IndexOf(message[i])];
            }

            return decodedMessage;
        }
    }
}
