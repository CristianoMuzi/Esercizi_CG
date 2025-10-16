using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chiediamo all'utente di inserire il valore di a
            Console.WriteLine("Inserisci il primo numero");

            // Salviamo il valore in una variabile
            int a = int.Parse(Console.ReadLine());

            // Chiediamo all'utente di inserire il valore di b
            Console.WriteLine("Inserisci il secondo numero");

            // Salviamo il valore in una variabile
            int b = int.Parse(Console.ReadLine());

            // Chiediamo all'utente di inserire un numero tra 1,2,3,4
            // in base al numero digitato dall'utente faremo un tipo di operazione sui numeri "a" e "b"
            Console.WriteLine("Inserisci il numero relativo all'operazione che vuoi effettuare: \n 1. Somma \n 2. Sottrazione \n 3. Moltiplicazione \n 4. Divisione");

            // Salviamo il valore scelto nella variabile "operazione"
            int operazione = int.Parse(Console.ReadLine());

            // Se il valore inserito dall'utente è "1"...
            if (operazione == 1)
            {
                // ...allora faremo l'addizione (+) tra i due numeri e faremo vedere il risultato all'utente
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            // Se invece, il valore inserito dall'utente è "2"...
            else if (operazione == 2)
            {
                // ...allora faremo la sottrazione (-) tra i due numeri e faremo vedere il risultato all'utente
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            // Se invece, il valore inserito dall'utente è "3"...
            else if (operazione == 3)
            {
                // ...allora faremo la moltiplicazione (*) tra i due numeri e faremo vedere il risultato all'utente
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            // Se invece, il valore inserito dall'utente è "4"...
            else if (operazione == 4)
            {
                // ...allora faremo la divisione (/) tra i due numeri e faremo vedere il risultato all'utente
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            // Se invece, nessuna delle precedenti condizioni è vera (l0utente ha digitato un numero diverso da 1,2,3,4)...
            else
            {
                //...allora avvertiamo l'utente del suo errore
                Console.WriteLine("Il numero inserito è non è compreso tra 1 e 4, non è possibile effettuare i calcoli");
            }


        }
    }
}