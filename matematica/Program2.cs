using libreriamatematica;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Che operazione vuoi fare? (A/S/D/P/Max)");
            string risposta = Console.ReadLine();
            double risultato;
                switch(risposta)
            {
                case "A":
                    risultato = Operazioni.Somma(n1,n2);
                    break;
                case "P":
                    risultato = Operazioni.Potenza(n1, n2);
                    break;
                case "Max":
                    risultato = Operazioni.Massimo(n1, n2);
                    break;
                case "D":
                    risultato = Operazioni.Divisione(n1, n2);
                    break;
                case "S":
                    risultato = Operazioni.Differenza(n1, n2);
                    break;
                default:
                    throw new Exception("scelta non valida");

            }
            Console.WriteLine(risultato);
            Console.ReadLine();
        }
    }
}
