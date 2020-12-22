using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClasseMedecin : ClassePersonne
    {
        #region propriétés privées
        private string tel;
        private int departement;
        private ClasseSpecialite laSpecialite;

        #endregion

        #region constructeurs
        public ClasseMedecin() { }
        public ClasseMedecin(int lid, string lenom, string leprenom, string ladresse, string letel, int ledepartement, ClasseSpecialite lSpecialite) : base(lid, lenom, leprenom, ladresse)
        {
            Tel = letel;
            Departement = ledepartement;
            LaSpecialite = lSpecialite;
        }
        #endregion

        #region accesseurs
        public string Tel { get => tel; set => tel = value; }
        public int Departement { get => departement; set => departement = value; }
        public ClasseSpecialite LaSpecialite { get => laSpecialite; set => laSpecialite = value; }
        #endregion

        #region méthodes
        // VERIFIE SI LE TEL EST VALIDE, UNIQUEMENT DES CHIFFRE ET 10 CARACTERE
        public static bool telValide(string tel)
        {
            bool resultat = false;
            var MyRegex = new Regex("^[0-9]*$");

            if (MyRegex.IsMatch(tel))
            {
                int nbTel = tel.Count();
                if(nbTel == 10)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }

        // VERIFIE SI LE DEPARTEMENT EST VALIDE, UNIQUEMENT DES CHIFFRE ET 2 CARACTERE
        public static bool departementValide(string departement)
        {
            bool resultat = false;
            var MyRegex = new Regex("^[0-9]*$");

            if (MyRegex.IsMatch(departement))
            {
                int nbTel = departement.Count();
                if (nbTel == 2)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }
        #endregion
    }
}
