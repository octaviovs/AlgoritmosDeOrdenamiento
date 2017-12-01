using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class HeapSort
    {
        private int iteracion = 0;
        public   HeapSort(int[] v )
        {
            DateTime inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-HeapSort");
            ordenacionMonticulos(v);
            DateTime final = DateTime.Now;
            TimeSpan duracion = final - inicio;
            double segundosTotales = duracion.TotalSeconds;
            int segundos = duracion.Seconds;
            ///fin del algoritmo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fin");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Resultados");
            Console.WriteLine("Tiempo en segudos:" + duracion);
            Console.WriteLine("Numero de iteraciones" + iteracion);
        }
        public  void ordenacionMonticulos(int[] v)
        {
            int N = v.Length;
            for (int nodo = N / 2; nodo >= 0; nodo--) hacerMonticulo(v, nodo, N - 1);
            for (int nodo = N - 1; nodo >= 0; nodo--)
            {
                
                int tmp = v[0];
                v[0] = v[nodo];
                v[nodo] = tmp;
                hacerMonticulo(v, 0, nodo - 1);
            }
        }

        public  void hacerMonticulo(int[] v, int nodo, int fin)
        {
            int izq = 2 * nodo + 1;
            int der = izq + 1;
            int may;
            if (izq > fin) return;
            if (der > fin) may = izq;
            else may = v[izq] > v[der] ? izq : der;
            if (v[nodo] < v[may])
            {
                iteracion++;
                int tmp = v[nodo];
                v[nodo] = v[may];
                v[may] = tmp;
                hacerMonticulo(v, may, fin);
            }
        }

    }
}
