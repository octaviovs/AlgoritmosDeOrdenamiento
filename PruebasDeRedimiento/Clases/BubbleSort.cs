using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class BubbleSort
    {
        private int iteracion = 0;
        public BubbleSort(int [] v )
        {
          



            DateTime inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-BubbleSort");
            ordenacionBurbuja(v);
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

        public  void ordenacionBurbuja(int[] v)
        {
           int N = v.Length;
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        iteracion++;
                        int tmp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
