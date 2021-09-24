using System;

namespace TriPersonne
{
    class Group
    {
        private string libelle;
        private Personne[] membres; // Tableau
        private int nbr;

        public Group(string libelle_)
        {
            membres = new Personne[10];
            this.nbr = 0;
            this.libelle = libelle_;

        }
        public void ajouter(Personne p)
        {
            membres[nbr] = p;
            nbr++;





        }
        public void afficher()
        {
            Console.WriteLine("Groupe : " + this.libelle);


            for (int i = 0; i < nbr; i++)

            {
                membres[i].afficher();
            }
            if (nbr == 0)
                Console.WriteLine("Groupe vide ");
        }

        public void trier ()
        {
            bool estTrie = false;

            while (!estTrie)
            {
                estTrie = true;
                for (int i = 0; i <this.nbr - 1; i++)
                {
                    if (String.Compare(this.membres[i].getNom(),  this.membres[i + 1].getNom())==1)
                    {
                        Personne aux = this.membres[i];
                        this.membres[i] = this.membres[i + 1];
                        this.membres[i + 1] = aux;
                        estTrie = false;
                        
                    }
                }
                
            }
        }
    }
   
    class Vivant
    {
        protected string prenom; // Champs de l'objet chien
        protected int annee;




        public void afficher() // Methode de l'objet chien
        {
            Console.WriteLine("Vivant " + this.prenom + " " + this.annee);

        }
        //public int naissance() // Methode de l'objet chien
        // {

        //   return   2021 - (this.annee);
        //}
        public int age()
        {
            return 2021 - this.annee;
        }


    }

    class Chien : Vivant // Chien herite de Vvant
    {
        // Champs de l'objet chien
        private int tatoo;


        public Chien(string prenom_, int annee_, int tatoo_)// Constructeur d'un objet de tye chien
        {
            this.prenom = prenom_;
            this.annee = annee_;
            this.tatoo = tatoo_;


        }
        public new void afficher() // Methode de l'objet chien
        {
            Console.WriteLine("Mon chien " + this.prenom + ", il a " + this.age() + " ans(" + this.annee + ")" + "Son numéro de tatouage est :  " + this.tatoo);

        }
        //public int naissance() // Methode de l'objet chien
        // {

        //   return   2021 - (this.annee);
        //}


    }
    class Personne : Vivant
    {
        private string nom; // Champs de l'objet personne

        Chien sonChien; // Le chien de la perosnne eventuellement nul


        public Personne(string nom_, string prenom_, int annee_)// Constructeur d'un objet de tye personne
        {
            this.nom = nom_;
            this.prenom = prenom_;
            this.annee = annee_;
            this.sonChien = null; // PAs de chien à la création 



        }
        public new void afficher() // Methode de l'objet perosnne
        {
            Console.WriteLine(this.nom + " " + this.prenom + " " + this.age() + "(" + this.annee + ")");
            if (this.sonChien == null)
                Console.WriteLine("  Pas de chien ");
            else
            {
                Console.WriteLine(" Chien = ");
                this.sonChien.afficher();
            }


        }
        //public int naissance() // Methode de l'objet Personnne
        // {

        //   return   2021 - (this.annee);
        //}

        public void adopter(Chien c)
        {
            this.sonChien = c;
        }

        public string getNom()
        {
            return this.nom;
        }

    }
    class Program
    {
        static Personne p1, p2, p3, p4, p5; // Variables du programme
        //static Chien c1, c2;
        static Group g1, g2, g3;
        static void Main(string[] args)
        {
            p1 = new Personne("DUPONT", "ALBERT", 2000);   //Allocation d'un nouvel objet Personne
            p2 = new Personne("CASTEX", "JEAN", 2001);
            p3 = new Personne("ESCOBAR", "PABLO", 1964);
            p4 = new Personne("ANN", "LISA", 1985);
            p5 = new Personne("PAPILLON", "RICHARD", 1999);


            g1 = new Group("g1"); g2 = new Group("g2"); g3 = new Group("g3");
            g1.ajouter(p1); g2.ajouter(p4);
            g1.ajouter(p2); g2.ajouter(p5);
            g1.ajouter(p3);
            g1.afficher(); g2.afficher(); g3.afficher();
            g1.trier(); g2.trier(); g3.trier();
            g1.afficher(); g2.afficher(); g3.afficher();





            //p1.nom = "DUPONT";
            //p1.prenom = "Albert";
            //p1.age = 23;

            //p2 = new Personne();

            //p2.nom = "Castex";
            //p2.prenom = "Jean";
            //p2.age = 47;

            /*p1.afficher();
            p2.afficher();


            c1 = new Chien("Rex", 2005, 2014011);
            c2 = new Chien("Pablo", 2010, 28411110);
            c1.afficher();
            c2.afficher();

            p1.adopter(c1);
            p1.adopter(c2);




            p1.afficher();
            
            g1.afficher();

            Console.WriteLine("----");
            Console.WriteLine(p1.age());
            Console.WriteLine(c1.age());*/


            //Console.WriteLine(p1.nom);
            Console.WriteLine("Fin Normale"); Console.ReadLine();
        }
    }
}
