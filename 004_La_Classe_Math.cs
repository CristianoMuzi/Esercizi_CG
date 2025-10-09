using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 5;
            double potenza = 3;

            // La classe "Math" fa le operazioni piu complicate (come ad esempio radice quadrata e potenza) al posto nostro

            // Pow si usa per calcolare la potenza
            double risultato = Math.Pow(numero, potenza);
            Console.WriteLine(risultato);

            double numero = 9;
            // Sqrt si usa per calcolare la radice quadrata
            double risultato = Math.Sqrt(numero);
            Console.WriteLine(risultato);

            // Inoltre la classe Math da anche accesso ad alcune costanti matematiche utili, come ad esempio il pi
            Console.WriteLine(Math.PI);
        }
    }
}