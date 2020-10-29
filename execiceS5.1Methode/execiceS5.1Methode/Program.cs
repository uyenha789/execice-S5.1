using Exercices5._1;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Exercices5._1
{
        public enum Genre { Femme, Homme };

    public struct Personne
    {
        public string prenom;
        public string nom;
        public string Genre;
        public int age;
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            string genre;



        }


        //Écrire une méthode qui affiche une ligne d'étoiles en guise de séparateur (AfficherSeparateur)
        //public static 
        public static string AfficherSeparateur()
        {
            string separateur = "*************************************************";
            return (separateur);
        }


        //Écrire une ou des méthodes qui demandent le nom, le prénom, le genre et l'âge d’une personne. (DemanderNom,...)
        public static Personne DemanderInfo()
        {
            // personne.nom = DemanderNom();
            //personne.prenom = DemanderPrenom();
            //personne.age = DemanderAge();
            //ersonne.Genre = DemanderGenre();
        }
        public static string DemanderNom()
        {
            Console.WriteLine($"Votre nom?: ");
            string nom = Console.ReadLine();
            return (nom);
        }
        public static string DemanderPrenom()
        {
            Console.WriteLine($"Votre prenom?: ");
            string prenom = Console.ReadLine();
            return (prenom);
        }
        public static int DemanderAge()
        {
            Console.WriteLine($"Quel age avez-vous?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            return (age);

        }
        public static Genre DemanderGenre()
        {
            Genre genre;
            Console.WriteLine($"Veulliez entrer 1 si vous êtes une femme ou 2 si vous êtes un homme: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index == 1)
            {
                genre = Genre.Femme;
            }
            else
            {
                genre = Genre.Homme;
            }
            return (genre);

        }

        public static void AfficherInfo(Personne personne)
        {
            Console.WriteLine(personne.nom + " " + personne.prenom + "a" + personne.age + "ans");

        }


        //Écrire une méthode qui affiche les informations de la personne (AfficherInfo)


        //Écrire une méthode qui appelle les précédentes pour demander les info et les afficher (TraiterPersonne)
        public static string TraiterPersonne()
        {

            string personne = AfficherInfo();
            return (personne);


        }

        public static void TraiterTous()
        {

        }


    }
}


//Écrire une méthode qui appelle trois fois TraiterPersonneet sépare l’affichage par des étoiles (TraiterTous)




//Appeler TraiterTousdans le main.
//Console.ReadKey();
