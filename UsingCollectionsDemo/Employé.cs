using System;

namespace UsageCollections
{
    public class Etudiant
    {
        public string NO { get; set; }  // Numéro d'ordre
        public string Prénom { get; set; }
        public string Nom { get; set; }
        public double NoteCC { get; set; }
        public double NoteDevoir { get; set; }

        public double Moyenne => (NoteCC * 0.33) + (NoteDevoir * 0.67);  // Calcul de la moyenne
    }
}
