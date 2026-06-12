using System.Text.Json.Serialization;

namespace QuizGame.Models;


public class QuizDataWrapper
{
    [JsonPropertyName("questions")]
    public List<Question> Questions { get; set; }
}