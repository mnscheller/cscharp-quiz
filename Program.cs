using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


using QuizGame.Models;
using QuizGame.UI;

namespace QuizGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "QuizGame";

            QuizUI qui = new QuizUI();



            string filePath = $"questions.json";
            List<Question> questions = LoadQuestions(filePath);

            // Prüfen, ob das Laden erfolgreich war
            if (questions != null && questions.Count > 0)
            {
                Console.WriteLine($"Erfolgreich {questions.Count} Fragen geladen!");
                qui.PrepareUI();

            }
            else
            {
                Console.WriteLine("Das Quiz konnte nicht gestartet werden, da keine Fragen geladen wurden.");
            }

        }

        public static List<Question> LoadQuestions(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Die Datei '{path}' wurde nicht gefunden.");
                    return null;
                }

                string jsonString = File.ReadAllText(path);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                QuizDataWrapper loadedData = JsonSerializer.Deserialize<QuizDataWrapper>(jsonString, options);

                return loadedData?.Questions;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Laden der JSON-Datei: {ex.Message}");
                return null;
            }
        }
    }

}