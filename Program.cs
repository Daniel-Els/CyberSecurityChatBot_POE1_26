using System;

namespace CyberSecurityChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start the chatbot
            StartChatbot();
        }

        // Main chatbot method
        static void StartChatbot()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("  Cybersecurity Awareness Chatbot");
            Console.WriteLine("=====================================\n");

            // Ask for user name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Basic validation for empty name
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User"; // default name
            }

            Console.WriteLine($"\nHello, {userName}! Welcome to the chatbot.\n");

            // Start conversation loop
            ChatLoop(userName);
        }

        // Chat loop method
        static void ChatLoop(string userName)
        {
            bool running = true;

            while (running)
            {
                Console.Write("\nAsk me something (type 'exit' to quit): ");
                string userInput = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please enter something.");
                    continue;
                }

                // Convert input to lowercase for easier matching
                userInput = userInput.ToLower();

                // Exit condition
                if (userInput == "exit")
                {
                    Console.WriteLine($"Goodbye, {userName}! Stay safe online.");
                    running = false;
                }
                else
                {
                    RespondToUser(userInput);
                }
            }
        }

        // Response system
        static void RespondToUser(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm just a bot, but I'm here to help you stay safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate you about cybersecurity and online safety.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask me about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with a mix of letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Be careful of emails asking for personal info. Always verify the sender.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Avoid clicking suspicious links and always check website security (https).");
            }
            else
            {
                Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
            }
        }
    }
}