using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creiamo 3 variabili: a,b,c
            // da notare che è possibile creare le variabili senza assegnare loro un valore
            int a;
            int b;
            int c;

            // Chiediamo all'utente di inserire il valore del segmento a
            Console.WriteLine("Inserisci la lunghezza del lato a: ");

            // Salviamo il valore in una variabile
            a = int.Parse(Console.ReadLine());

            // Chiediamo all'utente di inserire il valore del segmento b
            Console.WriteLine("Inserisci la lunghezza del lato b: ");

            // Salviamo il valore in una variabile
            b = int.Parse(Console.ReadLine());

            // Chiediamo all'utente di inserire il valore del segmento c
            Console.WriteLine("Inserisci la lunghezza del lato c: ");

            // Salviamo il valore in una variabile
            c = int.Parse(Console.ReadLine());

            // Controlliamo che la somma della lunghezza di 2 lati sia maggiore della lunghezza del terzo lato
            if (a + b > c || a + c > b || b + c > a)
            {
                // Se è vero eseguiamo questo codice...
                Console.WriteLine($"Con dei segmenti lunghi {a}, {b}, {c} è possibile costruire un triangolo");
            }
            else
            {
                // ...altrimenti eseguiamo questo
                Console.WriteLine($"Purtroppo, con dei segmenti lunghi {a}, {b}, {c} non è possibile costruire un triangolo");
            }
        }
    }
}