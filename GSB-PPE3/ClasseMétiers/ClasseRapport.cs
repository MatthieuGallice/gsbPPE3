using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // pour utilisé les expression régulière

namespace ClasseMétiers
{
    public class ClasseRapport
    {
        #region propriétés privées

        private int id;
        private DateTime date;
        private string motif;
        private string bilan;
        private ClasseVisiteur leVisiteur;
        private ClasseMedecin leMedecin;
        private List<ClasseEchantillonOffert> lesEchantillonsOfferts = new List<ClasseEchantillonOffert>();

        #endregion

        #region constructeurs
        public ClasseRapport()
        {
        }
        public ClasseRapport(int lid, DateTime ladate, string lemotif, string lebilan)
        {
            id = lid;
            date = ladate;
            motif = lemotif;
            bilan = lebilan;
        }
        public ClasseRapport(int lid, DateTime ladate, string lemotif, string lebilan, ClasseVisiteur lVisiteur, ClasseMedecin lMedecin, List<ClasseEchantillonOffert> desEchantillonsOfferts)
        {
            id = lid;
            date = ladate;
            motif = lemotif;
            bilan = lebilan;
            leVisiteur = lVisiteur;
            leMedecin = lMedecin;
            lesEchantillonsOfferts = desEchantillonsOfferts;
        }

        #endregion

        #region accesseurs
        public int Id {get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Bilan { get => bilan; set => bilan = value; }
        public ClasseVisiteur LeVisiteur { get => leVisiteur; set => leVisiteur = value; }
        public ClasseMedecin LeMedecin { get => leMedecin; set => leMedecin = value; }
        public List<ClasseEchantillonOffert> LesEchantillonsOfferts { get => lesEchantillonsOfferts; set => lesEchantillonsOfferts = value; }

        #endregion

        #region méthodes
        // méthode qui vérifie si la quantite est valide, uniquement des chiffre
        public static bool quantiteValide(string quantite)
        {
            // variable boolean pour le return 
            bool resultat = false;
            // variable qui utilise la fonction Regex des expression régulière qui vérifie que la chaine de caractére posséde seulement des chiffre entre 0 et 9
            var MyRegex = new Regex("^[0-9]*$");

            // condition qui utilise IsMatch sur la chaine quantite, cette expression permet de vérifie si il existe une correspondance entre la chaine spécifier et le constructeur Regex 
            if (MyRegex.IsMatch(quantite))
            {
                resultat = true;   
            }
            // condition si l'expression est fausse
            else
            {
                resultat = false;
            }
            return resultat;
        }
        #endregion
    }
}
