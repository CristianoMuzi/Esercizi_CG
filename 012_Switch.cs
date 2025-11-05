using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {


        static void Main(string[] args)
        {
            // Chiediamo all'utente di inserire un numero da 1 a 7
            Console.Write("Inserisci il numero del giorno della settimana (1-7): ");

            // Facciamo il Parse per trasformare la stringa letta in un numero
            int giorno = int.Parse(Console.ReadLine());

            // Utilizziamo lo switch sulla variabile "giorno" (che contiene il valore inserito dall'utente)
            switch (giorno)
            {
                // Se mil valore di "giorno" è 1 allora...
                case 1:
                    //...diciamo all'utente che il 1 giorno della settimana corrisponde a lunedì...
                    Console.WriteLine($"Il {day} giorno della settimana è Lunedì.");
                    // (Ricordiamo di utilizzare il breack alla fine)
                    break;

                // ...altrimenti se mil valore di "giorno" è 2 allora...
                case 2:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a martedì...
                    Console.WriteLine($"Il {day} giorno della settimana è Martedì.");
                    break;

                // ...altrimenti se mil valore di "giorno" è 3 allora...
                case 3:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a mercoledì...
                    Console.WriteLine($"Il {day} giorno della settimana è Mercoledì.");
                    break;

                // ...altrimenti se mil valore di "giorno" è 4 allora...
                case 4:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a giovedì...
                    Console.WriteLine($"Il {day} giorno della settimana è Giovedì.");
                    break;

                // ...altrimenti se mil valore di "giorno" è 5 allora...
                case 5:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a venerdì...
                    Console.WriteLine($"Il {day} giorno della settimana è Venerdì.");
                    break;

                // ...altrimenti se mil valore di "giorno" è 6 allora...
                case 6:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a sabato...
                    Console.WriteLine($"Il {day} giorno della settimana è Sabato.");
                    break;

                // ...altrimenti se mil valore di "giorno" è 7 allora...
                case 7:
                    //...diciamo all'utente che il 2 giorno della settimana corrisponde a domenica.
                    Console.WriteLine($"Il {day} giorno della settimana è Domenica.");
                    break;

                // Alla fine mettiamo sempre un "default" per tutti gli altri casi, come ad esempio, nle caso un cui l'utente scriva un numero non compreso tra 1 e 7
                default:
                    // E diciamo all'utente che ha sbagliato a scrivere
                    Console.WriteLine("Numero giorno della settimana non corretto!");
                    break;
            }

        }
    }
}