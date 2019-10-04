using System;
using libreriamatematica;

namespace Matematica
{
    class Program
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
            try
            {

                if (risposta == "A")
                    risultato = Operazioni.Somma(n1, n2);
                else if (risposta == "S")
                    risultato = Operazioni.Differenza(n1, n2);
                else if (risposta == "D")
                    risultato = Operazioni.Divisione(n1, n2);

                if (risposta == "P")
                    risultato = Operazioni.Potenza(n1, n2);
                else if (risposta == "Max")
                    risultato = Operazioni.Massimo(n1, n2);
                else
                    risultato = double.NaN;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                risultato = double.NaN;
            }
            Console.WriteLine(risultato);
            Console.ReadLine();



        }
    }
}
