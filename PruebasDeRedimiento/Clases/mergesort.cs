using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class mergesort
    {
        private int iteracion = 0;
        public mergesort(int[] A, int izq, int der)
        {
            DateTime inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-mergesort");

            mergesor(A,izq, der);

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

        public  void mergesor(int[] A, int izq, int der)
        {
            if (izq < der)
            {
                int m = (izq + der) / 2;
                mergesor(A, izq, m);
                mergesor(A, m + 1, der);
                mergesor(A, izq, m, der);
            }
        }

        public  void mergesor(int[] A, int izq, int m, int der)
        {
            int i, j, k;
            int[] B = new int[A.Length]; //array auxiliar
            for (i = izq; i <= der; i++) //copia ambas mitades en el array auxiliar
                B[i] = A[i];
            
            i = izq; j = m + 1; k = izq;
            while (i <= m && j <= der) //copia el siguiente elemento más grande
                if (B[i] <= B[j]) { 
                    A[k++] = B[i++]; iteracion++;
            }
                else
                    A[k++] = B[j++]; iteracion++;
            while (i <= m) //copia los elementos que quedan de la
                A[k++] = B[i++]; //primera mitad (si los hay)
        }
    }
}
