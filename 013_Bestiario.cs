using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {


        static void Main(string[] args)
        {
            // Chiediamo all'utente di inserire il nome di un mostro
            Console.WriteLine("Benvenuto cacciatore, quale mostro stai cacciando?");

            // Salviamo il valore in una variabile
            string mostro = Console.ReadLine();

            Console.WriteLine($"{monster} tu dici... Lasciami pensare...");

            // Utilizziamo lo switch sulla variabile "mostro" (che contiene il valore inserito dall'utente)
            // Utilizziamo il ToLower() per trasformare tutte le lettere della parola inserita dall'utente in lettere minuscole, così che sia poi piu facile controllare la risposta
            // Infatti "Grifone" != "grifone"
            switch (mostro.ToLower())
            {
                // Se mil valore di "mostro" è "grifone" allora...
                case "grifone":
                    // ...diamo all'utente le informazioni sul grifone.
                    Console.WriteLine("Un grifone sembra una combinazione di un leone (coda e pelliccia) e un'aquila (becco affilato e ricurvo, artigli e ali enormi).");
                    break;

                // Altrimenti se mil valore di "mostro" è "demone" allora...
                case "demone":
                    // ...diamo all'utente le informazioni sul demone.
                    Console.WriteLine("Agli occhi di un residente medio dei Regni del Nord, un demone è l'incarnazione di tutto ciò che è malvagio e diabolico,come si può notare in molti proverbi famosi.");
                    break;
                // Altrimenti se mil valore di "mostro" è "troll" allora...
                case "troll":
                    // ...diamo all'utente le informazioni sul troll.
                    Console.WriteLine("Incontriamo i troll principalmente in montagna. Le parti inferiori sono abitate dai troll delle rocce, mentre i troll del ghiaccio si stabiliscono tra i pendii innevati di Skellige e dei Regni Settentrionali.");
                    break;
                // In tutti gli altri casi (quindi se l'utente a chiesto una creatura non presente nel bestiario o ha sbagliato a scrivere)...
                default:
                    // ...avvertiamo l'utente.
                    Console.WriteLine("Sfortunatamente, non conosco una creatura del genere.");
                    break;
            }

        }
    }
}