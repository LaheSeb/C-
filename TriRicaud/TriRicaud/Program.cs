using System;

namespace TriRicaud
{
    class Program
    {
        static int[] tab ;
        static int cpt;

        static void remplir()
        {
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = rnd.Next()%100;
               
            
        }
        static void afficher()
        { 
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");

            Console.Write("[" + cpt + "]");
                Console.WriteLine();

        }
        static void trier()
        {
             
            bool estTrie = false;
            Console.WriteLine();

            while(!estTrie)
            {
                estTrie = true;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i+ 1])
                    {
                        int aux = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = aux;
                        estTrie = false;
                        cpt = i;
                    }
                }
                afficher();
            }
        }
        static void Main(string[] args)
        {
            tab = new int[10]; //Allouer
            remplir();
            afficher();
            trier();
            Console.WriteLine("Hello World!");
        }
    }
}
