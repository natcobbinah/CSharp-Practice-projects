using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False' \n Press Enter to begin:");
            string? entry = Console.ReadLine();

            //demo sample questions
            string[] questions = { "Dog is a mammal", "An adult human has 32 teeths", "Beans is a type of legume" };
            bool[] answers = { true, true, true };

            RunQuiz(questions, answers);
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[questions.Length];

            if(questions.Length != answers.Length)
            {
                Console.WriteLine("questions and ansers do not match in order");
            }

            int askingIndex = 0;
            int scoreIndex = 0;
            int score = 0;
            bool inputBool;

            foreach(string question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                string? input = Console.ReadLine();

                bool isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            foreach(bool answer in answers)
            {
                bool response = responses[scoreIndex];
                Console.WriteLine($"{scoreIndex + 1} Input: {response} | Answer: {answers[scoreIndex]}");

                if (response.Equals(answer))
                {
                    score++;
                }
                scoreIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length}");
        }
    }
}