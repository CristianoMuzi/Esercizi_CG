using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {


        static void Main(string[] args)
        {

            // Utilizziamo una variabile di tipo string per salvare il valore di una frase o parola
            string gioco = "Red Dead Redemption 2";
            string personaggio = "Arthur Morgan";

            // Utilizziamo una variabile di tipo int per salvare il valore di un numero intero (es. 1,2,3,4...)
            int eta = 41;

            // Utilizziamo una variabile di tipo float o decimal o double per salvare il valore di un numero con virgola (es. 1.34)
            float altezza = 1.80f;
            decimal risparmi = 345.78m;

            // Utilizziamo una variabile di tipo char per salvare il valore di un singolo carattere (es. 'm')
            char sesso = 'm';

            // Utilizziamo una variabile di tipo bool per salvare un valore che puo essere SOLO true(vero) oppure false(falso)
            bool saSparare = true;

            // Utilizziamo Console.WriteLine() per scrivere qualcosa sulla console 
            // Possiamo scrivere una frase come ad esempio "ciao mi chiamo Arturo" 
            // O anche il valore che è contenuto in una variabile utilizzando il nome della variabile stessa)
            Console.WriteLine($"Nome del gioco:{gioco} \n personaggio:{personaggio} \n  eta:{eta} \n altezza:{altezza} \n risparmi:{risparmi} \n sesso:{sesso} \n sasparare: {saSparare}");

            // Utilizziamo Console.ReadLine() per leggere un valore dalla console
            // (o in questo caso solo per non far chiudere la console)
            Console.ReadLine();

        }
    }
}