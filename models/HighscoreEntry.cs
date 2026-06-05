namespace Quizgame.Models
{
    class HighscrooreEntry
    {
        public required string Name { get; set; }

        public required int Points { get; set; }

        public required DateOnly Date { get; set; }

    }
}