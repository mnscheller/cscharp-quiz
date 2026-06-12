using System.Text.Json.Serialization;

namespace QuizGame.Models
{
    public class Question
    {
        [JsonPropertyName("id")]
        public int QuestionId { get; init; }

        [JsonPropertyName("text")]
        public string QuestionContent { get; init; }

        [JsonPropertyName("options")]
        public List<string> AnswerOption { get; init; }

        [JsonPropertyName("correctAnswerIndex")]
        public int RightAnswerId { get; init; } //0..3 //option ID

        [JsonPropertyName("category")]
        public string Category { get; init; }

        [JsonPropertyName("difficulty")]
        public Difficulty Difficulty { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }
    }

    public enum Difficulty
    {
        leicht,
        mittel,
        schwer
    }
}