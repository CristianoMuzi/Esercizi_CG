using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vogliamo scrivere un programma per valutare il risultato di un test. seguendo questa logica:
            // Se l’alunno ottiene più di 90 punti, riceverà un 10,
            // Se ottiene più di 70 punti, riceverà un 8,
            // Se ottiene più di 50 punti, riceverà un 6,
            // Se ottiene più di 30 punti, riceverà un 4,
            // Se nessuna delle condizioni precedenti viene soddisfatta, riceverà un 2

            // Chiediamo all'utente di inserire il risultato del test
            Console.WriteLine("Inserisci il risultato del tuo test: ");

            // Salviamo il risultato del test nella variabile "risultato"
            int risultato = int.Parse(Console.ReadLine());


            // Adesso possiamo usare l'ISTRUZIONE CONDIZIONALE if per verificare il punteggio

            // Tra parentesi metto la CONDIZIONE (in questo caso SE il punteggio è maggiore di 90)
            if (risultato > 90)// Se la condizione è VERA (true) allora eseguiremo il codice tra parentesi graffe qui sotto
            {

                Console.WriteLine($"Il tuo risultato è {risultato}, il voto è: 10"); // Ovvero avvertiremo l'utente che il suo punteggio è 10
            }
            // Se la condizione (nel nostro caso risultato > 90) è FALSA (false) allora potremmo aggiungere un ulteriore controllo
            // utilizzando la keyword (parola chiave) else if in questo modo:
            else if (risultato > 70) // Quindi se risultato sarà maggiore di 70 (ma minore di 90) eseguiremo il codice racchiuso dentro le parentesi graffe qui sotto
            {
                Console.WriteLine($"Il tuo risultato è {risultato}, il voto è: 8"); // Ovvero avvertiremo l'utente che il suo punteggio è 8
            }
            // Faremo la stessa cosa per tutti i possibili volori
            else if (risultato > 50)
            {
                Console.WriteLine($"Il tuo risultato è {risultato}, il voto è: 6");
            }
            else if (risultato > 30)
            {
                Console.WriteLine($"Il tuo risultato è {risultato}, il voto è: 4");
            }
            else if (risultato >= 0)
            {
                Console.WriteLine($"Il tuo risultato è {risultato}, il voto è: 2");
            }
            // A questo punto manca solo da aggiungere un possibile errore nel valore digitato dall'utente, per farlo utilizziamo la parola else
            // In questo modo SE il codice negli if e else if precedenti non è stato raggiunto (nel nostro caso ad esempio se l'utente ha digitato il valore -3 come punteggio)
            // allora il codice intero a questo else verrà SERMPRE eseguito, in questo caso avvertiremo l'utente dell'errore
            else
            {
                Console.WriteLine($"Il valore {risultato} non è corretto, inserisci un risultato del test maggiore di 0");
            }
        }
    }
}