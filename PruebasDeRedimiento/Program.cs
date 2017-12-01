using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebasDeRedimiento.Clases;

namespace PruebasDeRedimiento
{
    class Program
    {
        static int n;
        int[] vector;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ingrese cuantas posiciones va tener el vector");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }

            mergesort(vector);

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            SelectionSor(vector);
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }

            InsertionSort(vector);
           
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            QuickSor(vector);
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }

            heapSort(vector);
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            Shell_Sort(vector);

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            BubleSort(vector);
            Console.ReadKey();
        }

        public static void InsertionSort(int[] vec) {

            InsertionSort orden = new Clases.InsertionSort(vec);
        }
        public static void SelectionSor(int[] vec)
        {
            SelectionSort oreden = new SelectionSort(vec);

        }
        public static void QuickSor(int[] vec)
        {
            int low = 0;
            int high = n - 1;
            QuickSort orden = new QuickSort(vec, low, high);
        }
        public static void mergesort(int[] vec)
        {

            mergesort orden = new mergesort(vec, 0, n - 1);
        }
        public static void heapSort(int[] vec)
        {
            HeapSort orden = new HeapSort(vec);
        }
        public static void Shell_Sort(int[] vec)
        {
            ShellSort orden = new Clases.ShellSort(vec);

        }
        public static void BubleSort(int[] vec)
        {
            BubbleSort orden = new BubbleSort(vec);

        }
    }
}
//http://jorgep.blogspot.mx/2010/09/shell-sort.html
//http://jorgep.blogspot.mx/2010/10/ordenacion-por-burbuja-bubble-sort.html
//http://jorgep.blogspot.mx/2010/10/ordenacion-shaker.html
//http://jorgep.blogspot.mx/2010/09/ordenacion-rapida-quick-sort.html
//http://jorgep.blogspot.mx/2010/10/ordenacion-por-residuos-radix-sort.html
///http://jorgep.blogspot.mx/p/ordenaciones.html