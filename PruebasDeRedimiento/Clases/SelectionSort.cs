using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class SelectionSort
    {

        private int[] sort;
        private int iteracion = 0;
     public   SelectionSort(int[] paso)
        {
            DateTime inicio = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-SelectionSort");
            sort = paso;
       
            for (int i = 0; i < sort.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[j] < sort[index])
                    {
                        index = j;
                    }

                    iteracion++;
                }
                int menor = sort[index];
                sort[index] = sort[i];
                sort[i] = menor;
            }
            //fin del algotirmo
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
    }
}
