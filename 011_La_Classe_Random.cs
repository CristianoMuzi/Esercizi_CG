using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {
            // In questo esercizio l'utente dovrà provare a indovinare in 3 tentativi un numero casuale tra 1 e 20 generato dal computer

            // Creiamo una variabile di tipo Random
            Random generatoreRandom = new Random();

            // Poi utilizziamo il metono Next(numero_di_partenza, Numero_finale -1) per dire a Random
            // di generare un numero casuale in quell'intervallo
            // ad esempio scrivendo generatoreRandom.next(1,11), verrà generato un numero casuale tra 1 e 10

            // Salviamo nella variabile "numeroDaIndovinare" un numero casuale tra 1 e 20
            int numeroDaIndovinare = generatoreRandom.Next(1, 21);

            // Salviamo nella variabile "numeroDiTentativi" il numero di tentativi effettuati dall'utente (partiamo da 0)
            int numeroDiTentativi = 0;

            // SCreiamo la variabile "numeroSelezionato" il numero selezionato dall'utente
            int numeroSelezionato;

            // PRIMO TENTATIVO

            // Chiediamo all'utente di provare ad indovinare il numero tra 1 e 20
            Console.WriteLine("Inserisci un numero (1-20): ");

            // Salviamo nella variabile "numeroSelezionato" il numero selezionato dall'utente
            numeroSelezionato = int.Parse(Console.ReadLine());

            // Aumentiamo di 1 il numero di tentativi dell'utente
            currentAttempt++;

            // Se il numero scelto dall'utente è maggiore del numero da indovinare
            if (numeroSelezionato > numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più piccolo di quello inserito
                Console.WriteLine("Non proprio, il mio numero è più piccolo di quello inserito");
            }
            // Altrimenti se il numero scelto dall'utente è minore del numero da indovinare
            else if (numeroSelezionato < numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più grande di quello inserito
                Console.WriteLine("Non proprio, il mio numero è maggiore di quello inserito");
            }
            // Altrimenti
            else
            {
                // Avviseremo l'utente che ha indovinato il numero e gli diremo quanti tentativi ha fatto in totale per indovinarlo
                Console.WriteLine($"Bravo, hai indovinato il numero estratto in {currentAttempt} tentativi!");

                // Utiliziamo questa parola per chiudere l'applicazione dopo che l'utente ha indovinato
                return;
            }

            // SECONDO TENTATIVO

            // Chiediamo all'utente di provare ad indovinare il numero tra 1 e 20
            Console.WriteLine("Inserisci un numero (1-20): ");

            // Salviamo nella variabile "numeroSelezionato" il numero selezionato dall'utente
            numeroSelezionato = int.Parse(Console.ReadLine());

            // Aumentiamo di 1 il numero di tentativi dell'utente
            currentAttempt++;

            // Se il numero scelto dall'utente è maggiore del numero da indovinare
            if (numeroSelezionato > numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più piccolo di quello inserito
                Console.WriteLine("Non proprio, il mio numero è più piccolo di quello inserito");
            }
            // Altrimenti se il numero scelto dall'utente è minore del numero da indovinare
            else if (numeroSelezionato < numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più grande di quello inserito
                Console.WriteLine("Non proprio, il mio numero è maggiore di quello inserito");
            }
            // Altrimenti
            else
            {
                // Avviseremo l'utente che ha indovinato il numero e gli diremo quanti tentativi ha fatto in totale per indovinarlo
                Console.WriteLine($"Bravo, hai indovinato il numero estratto in {currentAttempt} tentativi!");

                // Utiliziamo questa parola per chiudere l'applicazione dopo che l'utente ha indovinato
                return;
            }

            // TERZO TENTATIVO

            // Chiediamo all'utente di provare ad indovinare il numero tra 1 e 20
            Console.WriteLine("Inserisci un numero (1-20): ");

            // Salviamo nella variabile "numeroSelezionato" il numero selezionato dall'utente
            numeroSelezionato = int.Parse(Console.ReadLine());

            // Aumentiamo di 1 il numero di tentativi dell'utente
            currentAttempt++;

            // Se il numero scelto dall'utente è maggiore del numero da indovinare
            if (numeroSelezionato > numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più piccolo di quello inserito
                Console.WriteLine("Non proprio, il mio numero è più piccolo di quello inserito");
            }
            // Altrimenti se il numero scelto dall'utente è minore del numero da indovinare
            else if (numeroSelezionato < numeroDaIndovinare)
            {
                // Allora diremo all'utente che il numero da indovinare è più grande di quello inserito
                Console.WriteLine("Non proprio, il mio numero è maggiore di quello inserito");
            }
            // Altrimenti
            else
            {
                // Avviseremo l'utente che ha indovinato il numero e gli diremo quanti tentativi ha fatto in totale per indovinarlo
                Console.WriteLine($"Bravo, hai indovinato il numero estratto in {currentAttempt} tentativi!");

                // Utiliziamo questa parola per chiudere l'applicazione dopo che l'utente ha indovinato
                return;
            }
        }
    }
}