using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti al quiz di conoscenza!");
            Console.WriteLine("Rispondi alle domande digitando il numero della risposta corretta.");
            Console.WriteLine("Guadagnerai 1 punto per ogni risposta corretta.");

            string[] domande = {
                "Quante zampe ha un ragno?",
                "Quale pianeta è più vicino al Sole?",
                "Qual è il risultato di 5 + 3?",
                "Qual è la capitale della Francia?",
                "Qual è l'oceano più grande della Terra?"
            };

            string[,] risposte = {
                { "1. Sei", "2. Otto", "3. Dieci" },
                { "1. Venere", "2. Marte", "3. Mercurio" },
                { "1. Sette", "2. Otto", "3. Nove" },
                { "1. Parigi", "2. Londra", "3. Berlino" },
                { "1. Atlantico", "2. Pacifico", "3. Indiano" }
            };

            int[] risposteCorrette = { 2, 3, 2, 1, 2 };


            int punteggio = 0;


            for (int i = 0; i < domande.Length; i++)
            {
                Console.WriteLine($"\nDomanda {i + 1}: {domande[i]}");


                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(risposte[i, j]);
                }


                Console.Write("La tua risposta (inserisci il numero): ");
                int rispostaUtente;


                while (
                    !int.TryParse(Console.ReadLine(), out rispostaUtente)
                    || rispostaUtente < 1
                    || rispostaUtente > 3
                )
                {
                    Console.WriteLine("Inserisci un numero di risposta valido (1, 2 o 3): ");
                }
                if (rispostaUtente == risposteCorrette[i])
                {
                    Console.WriteLine("Ben fatto! Questa è la risposta corretta.");
                    punteggio++;
                }
                else
                {
                    Console.WriteLine("Mi dispiace, non è la risposta corretta.");
                }
            }
            Console.WriteLine(
                $"\nFine del quiz!  Il tuo punteggio è: {punteggio} su {domande.Length}."
            );


        }
    }
}
