using QuizGame.Models;


namespace QuizGame.UI
{
    class QuizUI
    {
        public void PrepareUI(List<Question> questions)
        {
            Console.WriteLine("Willkommen zum QuizGame!");
            var Question = new Question
            {
                QuestionId = 1,
                QuestionContent = "Welcher Datentyp speichert eine ganze Zahl in C#?",
                AnswerOption = new List<string>()
                {
                    "string",
                    "int",
                    "bool",
                    "double"
                },
                RightAnswerId = 1,
                Category = "Datentypen",
                Difficulty = Difficulty.leicht,
                Points = 10
            };
            Console.WriteLine($"Frage: {Question.QuestionContent}");

            for (int i = 0; i < Question.AnswerOption.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Question.AnswerOption[i]}");
            }
            // answerInput(Question);
            Console.WriteLine("Bitte geben Sie die Nummer der richtigen Antwort ein:");
            string userInput = Console.ReadLine();

        }
    }
}

