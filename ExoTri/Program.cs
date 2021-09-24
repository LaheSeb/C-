using System;


namespace TriBubble
{
    class ProgramTri
    {
        static void Main(string[] args)
        {
            
            int K, L, I, J;
            int[] Tableau = { 15, 10, 23, 2, 8, 9, 14, 16, 42, 8 };
            Console.Write("Avant : ");


            for (K = 0; K < Tableau.Length; K++)
            {
                
                if (K == Tableau.Length - 1)
                {
                    Console.Write(Tableau[K]);
                }
                else
                {
                    Console.Write(Tableau[K] + ", ");
                }
            }
            //+---------------------+
            //| DEBUT TRIE A BULLE  |
            //+---------------------+
            for (I = Tableau.Length - 2; I >= 0; I--)
            {
                for (J = 0; J <= I; J++)
                {
                    if (Tableau[J + 1] < Tableau[J])
                    {
                        int t = Tableau[J + 1];
                        Tableau[J + 1] = Tableau[J];
                        Tableau[J] = t;
                    }
                }
            }

           //+-------------------+
            //| FIN TRIE A BULLE  |
            //+-------------------+
            Console.WriteLine();
            Console.Write("Après : ");
            for (L = 0; L < Tableau.Length; L++)
            { 
                if (L == Tableau.Length - 1)
                {
                    Console.Write(Tableau[L]);
                }
                else
                {
                    Console.Write(Tableau[L] + ", ");
                }

            
                
            }
            Console.WriteLine();
        }
    }
    
}