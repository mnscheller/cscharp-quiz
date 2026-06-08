using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


using Quizgame.Models;

namespace QuizGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "QuizGame";

            // Der Pfad zu deiner JSON-Datei
            string filePath = $"questions.json";

            // Aufruf der separaten Methode
            List<Question> questions = LoadQuestions(filePath);

            // Prüfen, ob das Laden erfolgreich war
            if (questions != null && questions.Count > 0)
            {
                Console.WriteLine($"Erfolgreich {questions.Count} Fragen geladen!");

            }
            else
            {
                Console.WriteLine("Das Quiz konnte nicht gestartet werden, da keine Fragen geladen wurden.");
            }

            Console.ReadLine(); // Verhindert, dass sich das Fenster sofort schließt
        }

        // Lädt Quizfragen aus einer JSON-Datei und gibt sie als Liste zurück.
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

                // Optionen für Groß-/Kleinschreibung und den Enum-Converter erstellen
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                // HIER DIE ÄNDERUNG: Wir deserialisieren in die Wrapper-Klasse statt direkt in die Liste
                QuizDataWrapper loadedData = JsonSerializer.Deserialize<QuizDataWrapper>(jsonString, options);

                // Wir geben nur die Liste aus dem Wrapper zurück
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