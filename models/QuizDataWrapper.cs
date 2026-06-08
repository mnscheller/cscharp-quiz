using System.Text.Json.Serialization;

namespace Quizgame.Models;


public class QuizDataWrapper
{
    [JsonPropertyName("questions")]
    public List<Question> Questions { get; set; }
}