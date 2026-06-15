# Projekt: Quiz-App in C#
## test funktioniert alles mit dem pull Hallo
## hallos
## Worum geht's?

Ihr entwickelt **zu zweit (Pair Programming)** eine Quiz-App als Konsolenanwendung in C#. Das Thema eurer Fragen ist **C#** — ein paar Fragen sind schon in `questions.json` enthalten, weitere schreibt ihr selbst dazu.

Der Schwerpunkt liegt auf **objektorientierter Programmierung** und dem Arbeiten mit **Dateien (JSON)**.

---

## Pflichtaufgaben

1. **Multiple-Choice-Fragen** mit jeweils 4 Antwortmöglichkeiten (A/B/C/D), genau eine ist richtig
2. **Fragen aus der JSON-Datei laden** (`questions.json`)
3. **Kategorien** — der Spieler wählt vor dem Start eine Kategorie (*Datentypen*, *Schleifen*, *Collections*, *OOP*, *Methoden*, *Kontrollstrukturen*) oder „Alle"
4. **Schwierigkeitsstufen** — leicht / mittel / schwer (mit unterschiedlichen Punktwerten)
5. **Punktestand** während des Spiels und am Ende anzeigen
6. **Highscore-Liste** in eine Datei speichern und beim nächsten Start laden (Top 10)
7. **Saubere OOP-Struktur** — siehe Vorgaben unten

---

## Technische Vorgaben

- **OOP ist Pflicht.** Mindestens folgende Klassen:
  - `QuizGame` — Spielablauf (Frage stellen, Antwort prüfen, Punkte vergeben)
- JSON-Verarbeitung mit `System.Text.Json`
- **Keine 300-Zeilen `Main`-Methode!** Code sinnvoll in Methoden und Klassen aufteilen
- Sinnvolle Variablen- und Methodennamen (Englisch oder Deutsch — aber einheitlich)

---

## Vorgegebene Daten

In diesem Repository findet ihr bereits:

- `questions.json` — eine kleine Beispiel-Fragensammlung als Vorlage. Behaltet das Format bei, wenn ihr neue Fragen hinzufügt!

Die Struktur ist in der Datei dokumentiert — schaut sie euch zuerst an, bevor ihr mit dem Code beginnt.

---

## Vorgehen

| Stunde | Ziel |
|--------|------|
| **1** | Planung: Klassendiagramm zeichnen. `Question`-Klasse anlegen. JSON laden und Fragen in einer Liste speichern. |
| **2** | Spielablauf: Frage anzeigen, Antwort einlesen, prüfen, Punkte zählen, am Ende Ergebnis ausgeben. |
| **3** | Menü mit Kategorien- und Schwierigkeitsauswahl. Code refactoren — was passt nicht in `Main`? |
| **4** | Highscores in Datei speichern/laden. Letzte Politur. Vorstellung in der Gruppe. |

---

## Bonus-Aufgaben (für die Schnellen)

- **Quiz-Editor**: Im Menü neue Fragen hinzufügen und in die JSON-Datei zurückspeichern
- **Zeitlimit** pro Frage (z. B. 15 Sekunden)
- **Zufällige Reihenfolge** der Fragen und der Antwortoptionen
- **Farbige Konsolen-Ausgabe** (`Console.ForegroundColor`) — grün bei richtig, rot bei falsch
- **Joker** wie „50:50" (zwei falsche Antworten ausblenden)
- **Statistik**: Wie viele Fragen pro Kategorie richtig?

---

## Abgabe per Pull Request

Die Abgabe erfolgt über einen **Pull Request** in diesem Repository.

### So geht's:
1. **Im PR-Beschreibungstext (Pull Request Description)** schreibt ihr:
   - **Team**: Wer war dabei?
   - **Erledigt**: Welche Pflichtaufgaben sind fertig?
   - **Bonus**: Welche Bonus-Features habt ihr umgesetzt?
   - **Schwierigkeiten**: Was war schwer? Wo seid ihr hängen geblieben?
   - **Reflexion**: Was würdet ihr beim nächsten Mal anders machen?

### Was im PR enthalten sein muss:

- [ ] Lauffähiger C#-Code (`dotnet run` startet das Spiel)
- [ ] Aussagekräftige Commit-Messages
- [ ] Ausgefüllte PR-Beschreibung (siehe oben)
---

## Was macht einen guten Commit aus?

Ein guter Commit erzählt einem späteren Leser (auch eurem zukünftigen Ich!) in einem Satz, **was** geändert wurde und **warum**. Haltet euch an folgende Regeln:

### 1. Eine Sache pro Commit
Ein Commit sollte genau **eine logische Änderung** enthalten — z. B. „Question-Klasse hinzugefügt" oder „JSON-Loader implementiert". Mischt nicht mehrere Themen in einen Commit.

### 2. Aussagekräftige Commit-Message
Die erste Zeile (Subject) ist die wichtigste:

- **Kurz**: max. ~50 Zeichen
- **Im Imperativ / Präsens**: „Add JSON loader" oder „Füge JSON-Loader hinzu" — nicht „Added" oder „I added"
- **Konkret**: sagt, *was* sich ändert, nicht nur *dass* sich etwas ändert

✅ Gute Beispiele:
```
Füge Question-Klasse mit JSON-Properties hinzu
Implementiere Highscore-Speicherung in Datei
Fix: Falsche Auswertung bei leerer Antwort
Refactor: Spiellogik aus Main in QuizGame verschoben
```

❌ Schlechte Beispiele:
```
update
fix
wip
Stuff
asdf
Änderungen
```

### 3. Häufig committen
Lieber **viele kleine Commits** als ein riesiger am Ende. Faustregel: Wenn ihr eine in sich abgeschlossene Sache fertig habt (z. B. eine Methode funktioniert), ist das ein guter Zeitpunkt für einen Commit.

### 4. Nur funktionierenden Code committen
Pusht keinen Code, der nicht kompiliert oder offensichtlich kaputt ist. Wenn ihr zwischendurch einen unvollständigen Stand sichern müsst, schreibt das in die Message: `WIP: Highscore-Laden` — und überschreibt das später.

### 5. Mehr Details? → Commit-Body verwenden
Wenn die Änderung größer ist, könnt ihr nach der Subject-Zeile (leere Zeile dazwischen!) einen ausführlicheren Text schreiben:

```
Füge Schwierigkeitsfilter im Hauptmenü hinzu

Der Spieler kann jetzt vor Spielstart leicht/mittel/schwer auswählen.
Die ausgewählte Schwierigkeit wird an QuizGame übergeben und filtert
die Fragenliste entsprechend.
```

📖 Mehr lesen: [How to Write a Git Commit Message (Chris Beams)](https://cbeams.com/posts/git-commit/)

