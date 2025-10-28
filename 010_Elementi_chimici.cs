using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {

            // Chiediamo all'utente di inserire il numero atomico o il simbolo di un elemento
            Console.WriteLine("Inserisci il simbolo o il numero atomico di un elemento");

            // Salviamo il valore nella variabile di tipo stringa "elemento"
            string elemento = Console.ReadLine();

            // Se "elemento" è uguale alla lettera H o al numero 1 (non c'è bisogno di fare il parse in quanto non dobbiamo svolgere operazioni matematiche su questo numero)
            if (elemento == "H" || elemento == "1")
            {
                // Allora diciamo all'utente che l'elemento selezionato è l'idrogeno
                Console.WriteLine("L'elemento selezionato è l' Idrogeno");
            }
            // Altrimenti
            // Se "elemento" è uguale alla a "Co" o al numero 27
            else if (elemento == "Co" || elemento == "27")
            {
                // Allora diciamo all'utente che l'elemento selezionato è il Cobalto
                Console.WriteLine("L'elemento selezionato è il Cobalto");
            }
            // Altrimenti
            // Se "elemento" è uguale alla a "K" o al numero 19
            else if (elemento == "K" || elemento == "19")
            {
                Console.WriteLine("L'elemento selezionato è il Potassio");
            }
            // Possiamo mettere un else if per ogni elemento della tavola periodica
            //...
            //...
            // Poi alla fine mettiamo un else (senza if) per controllare eventuali valori non validi
            else
            {
                Console.WriteLine("Non conosco questo elemento.");
            }

        }
    }
}