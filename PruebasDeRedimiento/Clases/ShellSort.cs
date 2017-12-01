using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDeRedimiento.Clases
{
    class ShellSort
    {
        private int iteracion = 0;
    public    ShellSort(int[] v)
        {
            DateTime inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inicio-ShellSort");

            ordenacionShell(v);

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
        public  void ordenacionShell(int[] v)
        {
           int N = v.Length;
            int incremento = N;
            do
            {
                incremento = incremento / 2;
                for (int k = 0; k < incremento; k++)
                {
                    for (int i = incremento + k; i < N; i += incremento)
                    {
                        int j = i;
                        while (j - incremento >= 0 && v[j] < v[j - incremento])
                        {
                            int tmp = v[j];
                            v[j] = v[j - incremento];
                            v[j - incremento] = tmp;
                            j -= incremento;
                            iteracion++;
                        }
                    }
                }
            } while (incremento > 1);
        }
    }
}
