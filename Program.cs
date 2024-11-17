using System;

namespace TP1
{
    class Eleve // Nom de classe en majuscule; même nom pour le constructeur
    {
        private string nom; // Attribut propre à chaque instance
        private int niveau; // Attribut propre à chaque instance
        public int nbEleve; // Attribut propre à chaque instance

        public Eleve(string nom, int niveau) : base() // Hérite de la classe Object par défaut
        {
            this.nom = nom;
            this.niveau = niveau;
            nbEleve++; // Incrémente nbEleve à chaque nouvelle instance
        }

        public Eleve() : this("Anonyme", 0) { } // Constructeur par défaut qui appelle un autre constructeur avec "Anonyme" et 0

        String setNiveauGetNom(int niv) { // Modifie le niveau et retourne le nom
            niveau = niv; // Setter pour niveau
            return this.nom; // Getter pour nom
        }

        public void setNiveau(int niveau) { this.niveau = niveau; }
        public string getNom() { return nom; }

        // Override de la méthode ToString pour afficher les détails de l'instance
        public override String ToString() 
        { 
            return "Eleve " + nbEleve + " " + nom + " niveau " + niveau; 
        }
    }

    internal class Program
    {
        static void Main(string[] args) // Main reçoit un tableau de strings
        {
            Eleve e1 = new Eleve("Ahmed", 5);
            Console.WriteLine(e1);

            Eleve e2, e3 = e1; // e3 et e1 pointent vers le même objet en mémoire
            e1 = new Eleve();
            e2 = new Eleve("Ines", 2);

            Console.WriteLine(e1 + "\n" + e2 + "\n" + e3);
            // e1 = new Eleve(); appelle le constructeur par défaut, donc les valeurs sont "Anonyme" et 0
            // e2 = new Eleve("Ines", 2); les valeurs sont donc "Ines" et 2
            // e3 = e1; avant que e1 soit réinitialisé, il contient les valeurs initiales de e1, c'est-à-dire "Ahmed" et 5

            Console.ReadLine();
            return;
        }
    }
}
