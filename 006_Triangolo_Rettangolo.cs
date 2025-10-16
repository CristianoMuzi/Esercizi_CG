using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci la lunghezza di uno dei lati più corti");
            double lato_corto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la lunghezza dell'altro lato più corto");
            double lato_corto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la lunghezza del lato più lungo C");
            double lato_lungo = double.Parse(Console.ReadLine());

            // La classe Math calcolerà la potenza per noi
            // Il teorema di Pitagora dice che in un triangolo rettangolo, 
            // l'area del quadrato costruito sull'ipotenusa è uguale alla somma delle aree dei quadrati costruiti sui due cateti.
            // Quindi se la somma di lato_corto1 alla seconda e lato_corto2 alla seconda sarà UGUALE (==) a lato_lungo alla seconda
            // allora questo sarà un triangolo rettangolo
            bool triangolo_rettangolo = Math.Pow(lato_corto1, 2) + Math.Pow(lato_corto2, 2) == Math.Pow(lato_lungo, 2);


            Console.WriteLine("Il triangolo è rettangolo? " + triangolo_rettangolo);

        }
    }
}