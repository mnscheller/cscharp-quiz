namespace QuizGame.Models
{
    class HighscoreEntry
    {
        public required string Name { get; set; }

        public required int Points { get; set; }

        public required DateOnly Date { get; set; }

    }
}