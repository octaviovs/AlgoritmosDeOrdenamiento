using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class InsertionSort
    {
        private int[] sort;
        private int iteracion = 0;
        public InsertionSort(int[] paso)
        {

            DateTime inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-InsertionSort");
   
            sort = paso;
            int temp;
            string tiempo1 = DateTime.Now.ToLongTimeString();
            for (int i = 1; i < sort.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (sort[j] < sort[j - 1])
                    {

                        temp = sort[j];
                        sort[j] = sort[j - 1];
                        sort[j - 1] = temp;
                    }
                    iteracion++;
                }
            }
            DateTime final = DateTime.Now;
            TimeSpan duracion = final - inicio;
            double segundosTotales = duracion.TotalSeconds;
            int segundos = duracion.Seconds;
            ///fin del algoritmo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fin");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Resultados");
            Console.WriteLine("Tiempo en segudos:"+duracion);
            Console.WriteLine("Numero de iteraciones"+iteracion);

           
        }
    }
}
