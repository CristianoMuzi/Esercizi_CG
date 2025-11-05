using System;

// Il namespace dovrà essere il vostro e non "Esercizi_CG"
namespace Esercizi_CG
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string operation;
            int result;

            Console.WriteLine("Inserisci il primo numero:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci l’operatore (+, -, *, /):");
            operation = int.Parse(Console.ReadLine()).ToString();

            Console.WriteLine("Inserisci il secondo numero:");
            number2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case ":":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Operazione non valida");
                    return;
            }

            Console.WriteLine("Risultato: " + result);
        }
    }
}