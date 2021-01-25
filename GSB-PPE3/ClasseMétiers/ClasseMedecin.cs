using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // pour utilisé les expression régulière
using System.Threading.Tasks;

namespace ClasseMétiers
{
    // héritage avec la classe personne 
    public class ClasseMedecin : ClassePersonne
    {
        #region propriétés privées
        // propriétés privées
        private string tel;
        private int departement;
        private ClasseSpecialite laSpecialite;

        // prorpiétés pour le constructeur de la focntion chargerLeMedecin
        private int idRap; 
        private int idVis;
        private string nomVis;
        private string prenomVis;
        private DateTime dateRap;
        private string motifRap;
        private string bilanRap;
        #endregion

        #region constructeurs
        // constructeur de la classe médecin
        public ClasseMedecin() { }
        public ClasseMedecin(int lid, string lenom, string leprenom, string ladresse, string letel, int ledepartement, ClasseSpecialite lSpecialite) : base(lid, lenom, leprenom, ladresse)
        {
            Tel = letel;
            Departement = ledepartement;
            LaSpecialite = lSpecialite;
        }
        // constructeur pour la fonction chargerLeMedecin de classePMedecin
        public ClasseMedecin(int lid, string lenom, string leprenom, string ladresse, int idRap, int idVis, string nomVis, string prenomVis, DateTime dateRap, string motifRap, string bilanRap) : base(lid, lenom, leprenom, ladresse)
        {
            this.IdRap = idRap;
            this.IdVis = idVis;
            this.NomVis = nomVis;
            this.PrenomVis = prenomVis;
            this.DateRap = dateRap;
            this.MotifRap = motifRap;
            this.BilanRap = bilanRap;
        }
        #endregion

        #region accesseurs
        public string Tel { get => tel; set => tel = value; }
        public int Departement { get => departement; set => departement = value; }
        public ClasseSpecialite LaSpecialite { get => laSpecialite; set => laSpecialite = value; }
        public int IdRap { get => idRap; set => idRap = value; }
        public int IdVis { get => idVis; set => idVis = value; }
        public string NomVis { get => nomVis; set => nomVis = value; }
        public string PrenomVis { get => prenomVis; set => prenomVis = value; }
        public DateTime DateRap { get => dateRap; set => dateRap = value; }
        public string MotifRap { get => motifRap; set => motifRap = value; }
        public string BilanRap { get => bilanRap; set => bilanRap = value; }
        #endregion

        #region méthodes
        // méthode qui vérifie si le numéro de téléphone est valide, uniquement des chiffre, posséde 10 caractéres et commence par un préfixe valide
        public static bool telValide(string tel)
        {
            // variable boolean pour le return 
            bool resultat = false;
            // variable qui utilise la fonction Regex des expression régulière qui vérifie que la chaine de caractére posséde seulement des chiffre entre 0 et 9
            var MyRegex = new Regex("^[0-9]*$");

            // condition qui utilise IsMatch sur la chaine tel, cette expression permet de vérifie si il existe une correspondance entre la chaine spécifier et le constructeur Regex 
            if (MyRegex.IsMatch(tel))
            {
                // variable qui récupére la taille de la chaine de caractére
                int nbTel = tel.Count();
                // condition qui vérifie que le numéro de téléphone égale 10 chiffres
                if(nbTel == 10)
                {
                    // variable qui récupére les deux premier chiffre du numéro de téléphone
                    string telDébut = tel.Substring(0, 2); 
                    // condition qui vérifie les deux premier chiffre du numéro de téléphone
                    if(telDébut == "01" || telDébut == "02" || telDébut == "03" || telDébut == "04" || telDébut == "05" || telDébut == "06" || telDébut == "07" || telDébut == "09")
                    {
                        resultat = true;
                    }
                    // condition si le début du numéro de téléphone est faux
                    else
                    {
                        resultat = false;
                    }
                }
                // condition si la taille est fausse
                else
                {
                    resultat = false;
                }
            }
            // condition si l'expression est fausse
            else
            {
                resultat = false;
            }
            return resultat;
        }

        // méthode qui vérifie si le numéro de département est valide, uniquement des chiffre et posséde 2 caractéres
        public static bool departementValide(string departement)
        {
            // variable boolean pour le return 
            bool resultat = false;
            // variable qui utilise la fonction Regex des expression régulière qui vérifie que la chaine de caractére posséde seulement des chiffre entre 0 et 9
            var MyRegex = new Regex("^[0-9]*$");

            // condition qui utilise IsMatch sur la chaine departement, cette expression permet de vérifie si il existe une correspondance entre la chaine spécifier et le constructeur Regex 
            if (MyRegex.IsMatch(departement))
            {
                // variable qui récupére la taille de la chaine de caractére
                int nbDep = departement.Count();
                // condition qui vérifie que le numéro de département égale 2 chiffres
                if (nbDep == 2)
                {
                    resultat = true;
                }
                // condition si la taille est fausse
                else
                {
                    resultat = false;
                }
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
