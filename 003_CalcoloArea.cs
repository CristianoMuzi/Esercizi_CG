using System;

namespace quiz
{
    class Program
    {


        static void Main(string[] args)
        {

            int h;
            int a, b;
            Console.WriteLine("Inserisci la lunghezza del lato a: ");

            // Utilizziamo Console.ReadLine() per leggere un valore dalla console
            // e, in questo caso, per salvarlo nella variabile "a"
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la lunghezza del lato b: ");

            // Utilizziamo il "Parse" per trasformare il valore di tipo "string" letto dalla console 
            // (i valori provenienti dalla console saranno SEMPRE di tipo string) in un tipo "int"
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("Inserisci l’altezza di h: ");
            h = int.Parse(Console.ReadLine());
            long risultato = (a + b) * h / 2;
            Console.WriteLine($"L’area del trapezio è: {risultato}");
            Console.ReadLine();

        }
    }
}