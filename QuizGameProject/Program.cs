using System.Threading.Channels;

namespace QuizGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] question = new string[3]
            {
               "1. what is th capital of egypt",
               "2. what is your name ",
               "what is your age"
            };
            string[] answer = new string[3]
            {
                "cairo",
                "mohammed",
                "18"
            };
            int correctanswer = 0;
            Console.WriteLine("welcom to my game");
            Console.WriteLine("--------------------");
            Console.WriteLine("let's to answer the question : ");

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                string useranswer = Console.ReadLine();
                try
                {

                    bool result = IsTheAnswerCorrect(useranswer, answer[i]);
                    if (result == true)
                    {
                        Console.WriteLine("The Answer Is True");
                        correctanswer++;
                    }
                    else
                    {
                        Console.WriteLine($"The Answer Is False , The Correct Answer Is {answer[i]}");
                    }
                }
                catch (Exception ex) 
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"Your Score Is {correctanswer} of 3");
            Console.WriteLine("Thank You For Playing........");

        }
        private static bool IsTheAnswerCorrect(string userAnswer, string correctAnswer)
        {

            if (string.IsNullOrEmpty(userAnswer)) {

                throw new Exception("answer can't be empty");
            }

            if (userAnswer == correctAnswer)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
