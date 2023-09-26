using System;
using System.Collections.Generic;



class VocabQuiz
{
    static void Main()
    {
        // Erstelle ein Wörterbuch für Vokabeln (Englisch zu Deutsch).
        Dictionary<string, string> vocabDictionary = new Dictionary<string, string>();



        // Füge Vokabeln zum Wörterbuch hinzu.
        vocabDictionary.Add("Vocabulary", "Wortschatz");
        vocabDictionary.Add("adventurous", "abenteuerlustig");
        vocabDictionary.Add("ambitious", "ehrgeizig");
        vocabDictionary.Add("argumentative", "streitsüchtig");
        vocabDictionary.Add("cheerful", "fröhlich");
        vocabDictionary.Add("curious about", "neugierig auf");
        vocabDictionary.Add("outgoing", "gesellig");
        vocabDictionary.Add("rebellious", "rebellisch");
        vocabDictionary.Add("stubborn", "stur");
        vocabDictionary.Add("artistic", "künstlerisch");
        vocabDictionary.Add("emotional", "emotional");
        vocabDictionary.Add("experienced", "erfahren");
        vocabDictionary.Add("generous", "großzügig");
        vocabDictionary.Add("helpful", "hilfsbereit");
        vocabDictionary.Add("hopeful", "hoffnungsvoll");
        vocabDictionary.Add("likeable", "sympathisch");
        vocabDictionary.Add("musical", "musikalisch");
        vocabDictionary.Add("optimistic", "optimistisch");
        vocabDictionary.Add("pessimistic", "pessimistisch");
        vocabDictionary.Add("practical", "praktisch");
        vocabDictionary.Add("realistic", "realistisch");
        vocabDictionary.Add("relaxed", "entspannt");
        vocabDictionary.Add("reliable", "zuverlässig");
        vocabDictionary.Add("talented", "talentiert");
        vocabDictionary.Add("thoughtful", "nachdenklich");
        vocabDictionary.Add("bring back memories", "Erinnerungen wecken");
        vocabDictionary.Add("childhood memories", "Kindheitserinnerungen");
        vocabDictionary.Add("have a good memory", "ein gutes Gedächtnis haben");
        vocabDictionary.Add("learn things by heart", "etwas auswendig lernen");
        vocabDictionary.Add("long-term memory", "Langzeitgedächtnis");
        vocabDictionary.Add("perfect recall", "perfektes Erinnern");
        vocabDictionary.Add("remember every detail", "sich an jedes Detail erinnern");
        vocabDictionary.Add("short-term memory", "Kurzzeitgedächtnis");
        vocabDictionary.Add("go in one ear and out the other", "ins eine Ohr rein, ins andere raus");
        vocabDictionary.Add("memory plays tricks on you", "das Gedächtnis spielt einem Streiche");
        vocabDictionary.Add("on the tip of your tongue", "auf der Zunge liegen");
        vocabDictionary.Add("refresh somebody's memory", "jemandes Gedächtnis auffrischen");
        vocabDictionary.Add("ring a bell", "eine Glocke läuten");
        vocabDictionary.Add("slip my mind", "aus meinem Gedächtnis entfallen");
        vocabDictionary.Add("fed up with", "genug haben von");
        vocabDictionary.Add("fond of", "etwas mögen");
        vocabDictionary.Add("nervous about", "nervös sein wegen");
        vocabDictionary.Add("not keen on", "nicht scharf sein auf");
        vocabDictionary.Add("passionate about", "leidenschaftlich sein für");
        vocabDictionary.Add("really into", "richtig begeistert von sein");
        vocabDictionary.Add("terrified of", "große Angst haben vor");
        vocabDictionary.Add("thrilled by", "begeistert sein von");



        Console.WriteLine("Willkommen zum Englisch-Vokabelquiz!");



        // Durchlaufe das Wörterbuch und frage nach Übersetzungen.
        foreach (var kvp in vocabDictionary)
        {
            Console.WriteLine($"Wie lautet die deutsche Übersetzung von '{kvp.Key}'?");
            string userAnswer = Console.ReadLine();



            if (userAnswer.ToLower() == kvp.Value.ToLower())
            {
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine($"Falsch. Die richtige Antwort ist: '{kvp.Value}'.");
            }
        }



        Console.WriteLine("Das Quiz ist beendet. Vielen Dank!");
    }
}