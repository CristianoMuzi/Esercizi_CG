using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatore matematico > segno di maggioranza
            // Operatore matematico < segno di minoranza
            // Operatore matematico >= maggiore o uguale a
            // Operatore matematico <= inferiore o uguale
            // Operatore matematico == pari
            // Operatore matematico != diverso
            // Operatore logico && vuol dire "e" tutte le condizioni devono essere soddisfatte
            // Operatore logico || vuol dire "oppure" - deve esseresoddisfatta una condizione
            // Operatore logico ! cambia il valore logico nel contrario, ad esempio, !true == false


            bool result = 5 > 3;
            Console.WriteLine(result);
            // Il risultato sarà true perchè 5 è SEMPRE maggiore di 3


            result = "ambaraba" == "cicci cocco";
            Console.WriteLine(result);
            // Il risultato sarà false perchè "ambaraba" non è MAI uguale a "cicci cocco"

            Console.WriteLine("Inserisci la tua età");
            int eta = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la quantità di soldi che possiedi");
            decimal soldi = decimal.Parse(Console.ReadLine());

            const int pegi = 16;
            const decimal prezzo = 199.50m;

            // Dentro la variabile di tipo bool (che quindi accetta solo due valori, o true o false)
            // che si chiama "posso_comprare_il_gioco" verrà salvato true SE eta è maggiore o uguale di pegi E soldi è maggiore o uguale di prezzo
            bool posso_comprare_il_gioco = (eta >= pegi && soldi >= prezzo);

            // Infine stampiamo il risultato
            Console.WriteLine("Puoi comprare il gioco? " + posso_comprare_il_gioco);
        }
    }
}