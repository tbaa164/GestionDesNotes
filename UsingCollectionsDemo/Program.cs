using System;
using System.Collections;

namespace UsageCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lstEtudiants = new SortedList();
            double sommeMoyennes = 0;
            int nbEtudiants = 0;

            Console.Write("Combien d'étudiants voulez-vous ajouter ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNuméro d'ordre: ");
                string no = Console.ReadLine();

                Console.Write("Prénom: ");
                string prenom = Console.ReadLine();

                Console.Write("Nom: ");
                string nom = Console.ReadLine();

                Console.Write("Note de Contrôle Continu: ");
                double noteCC = double.Parse(Console.ReadLine());

                Console.Write("Note de Devoir: ");
                double noteDevoir = double.Parse(Console.ReadLine());

                Etudiant etudiant = new Etudiant
                {
                    NO = no,
                    Prénom = prenom,
                    Nom = nom,
                    NoteCC = noteCC,
                    NoteDevoir = noteDevoir
                };

                lstEtudiants.Add(no, etudiant);
                sommeMoyennes += etudiant.Moyenne;
                nbEtudiants++;
            }

            Console.Write("\nChoisissez le nombre de lignes par page (1-15) : ");
            int lignesParPage;
            while (!int.TryParse(Console.ReadLine(), out lignesParPage) || lignesParPage < 1 || lignesParPage > 15)
            {
                Console.Write("Valeur invalide. Veuillez entrer un nombre entre 1 et 15 : ");
            }

            Console.WriteLine("\nListe des étudiants :");
            int count = 0;
            foreach (DictionaryEntry entry in lstEtudiants)
            {
                Etudiant etu = (Etudiant)entry.Value;
                Console.WriteLine($"NO: {etu.NO}, Prénom: {etu.Prénom}, Nom: {etu.Nom}, NoteCC: {etu.NoteCC}, NoteDevoir: {etu.NoteDevoir}, Moyenne: {etu.Moyenne:F2}");

                count++;
                if (count % lignesParPage == 0)
                {
                    Console.WriteLine("\nAppuyez sur Entrée pour voir la suite...");
                    Console.ReadLine();
                }
            }

            double moyenneClasse = sommeMoyennes / nbEtudiants;
            Console.WriteLine($"\nMoyenne de la classe : {moyenneClasse:F2}");

            Console.WriteLine("\nAppuyez sur Entrée pour quitter...");
            Console.ReadLine();
        }
    }
}
