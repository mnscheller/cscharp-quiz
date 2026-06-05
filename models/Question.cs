namespace Quizgame.Models
{
    public class Question
    {
        public int QuestionId { get; init; }
        public string QuestionContent { get; init; }
        public List<AnserOptions> AnswerOption { get; init; }
        public int RightAnswerId { get; init; } //0..3 //option ID
        public string Category { get; init; }
        public Difficulty Difficulty { get; set; }
        public int Point { get; set; }
    }

    public class AnserOptions
    {
        public int OptionID { get; set; }
        public string Option { get; set; }
    }

    public enum Difficulty
    {
        leicht,
        mittel,
        schwer
    }
}