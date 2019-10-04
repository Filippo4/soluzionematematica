using System;

namespace libreriamatematica
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Differenza(int a, int b)
        {
            int differenza = a - b;
            return differenza;
        }
        public static double Divisione(double a, double b)
        {
            if (b==0)
            {
                throw new Exception("b = 0");
            }
            double div = a / b;
            return div;
        }
        public static int Moltiplicazione(int a, int b)
        {
            int m = a * b;
            return m;
        }
        public static int Potenza(int a, int b)
        {
           int c = 0;
            while (c< b)
            {
                c++;
                a = a * a;
            }
            return a;

        }
        public static double Massimo(int a, int b)
        {
            double max;
            if (a >= b)
            {
                max = a;
            }
            else 
            {
                max = b;
            }
            return max;
        }

    }
}
