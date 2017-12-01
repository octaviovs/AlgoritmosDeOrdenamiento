  class QuickSort
    {
        private int[] sort;

        public QuickSort(int[] paso, int bajo, int alto)
        {
            quick(paso,bajo,alto);  
        }
        public void quick(int[] paso, int bajo, int alto) {    
            sort = paso;
            if (sort == null || sort.Length == 0)
                return;
            if (bajo >= alto)
                return;
            int izquierda_indice = bajo;
            int derecha_indice = alto;
            int mitad = bajo + (alto - bajo) / 2;
            int pivote = sort[mitad];    
            while (izquierda_indice <= derecha_indice)
            {
                while (sort[izquierda_indice] < pivote)
                {
                    izquierda_indice++;
                }
                while (sort[derecha_indice] > pivote)
                {
                    derecha_indice--;
                }
            
                if (izquierda_indice <= derecha_indice)
                {
                    int temp = sort[izquierda_indice];
                    sort[izquierda_indice] = sort[derecha_indice];
                    sort[derecha_indice] = temp;
                    izquierda_indice++;
                    derecha_indice--;
                }
            }
            // Recursivo
            if (bajo < derecha_indice)
            {
                quick(sort, bajo, derecha_indice);

            }
            if (alto > izquierda_indice)
            {
                quick(sort, izquierda_indice, alto);

            }


        }
    }
