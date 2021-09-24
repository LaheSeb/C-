using System;

namespace Exo1
{
    class Program
    {
        static int i = 123 ;
        static int j = 123;// Variables globale
        static char c = '!';
        static bool b = true;
        static float f = 0.123f;
        static string s = "coucou les filles";
        

        static void maProcedure(int n)
        {
            int aux; //variable locale 
            Console.WriteLine("Je suis dans maProcedure");
            aux = i + n;
            i = aux; //  i = i +n
        }
        static int maFonction(int n)
        {
            Console.WriteLine("Je suis dans maFonction");
            return i * n;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(i + ' ' + c + ' ');
            //Console.WriteLine(""+i + ' ' + c + ' '  + b + ' '  + f + ' ' + s);
            //Console.WriteLine(i + " " + c + " " + b + " " + f + " " + s);
            //Console.ReadLine();
           i++; // i= i+1
            Console.WriteLine("i = " + i);
            maProcedure(1); Console.WriteLine("i = " + i);
            maProcedure(2); Console.WriteLine("i = " + i);
            Console.WriteLine("i = " + i);
            
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + maFonction(3));


            Console.WriteLine("Fin Normale "); Console.ReadLine(); // Important de finir avecConsole.ReadLine();

        }
    }
}
