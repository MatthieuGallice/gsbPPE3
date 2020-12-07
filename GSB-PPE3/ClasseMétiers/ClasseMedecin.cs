using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ClasseMedecin(string lid, string lenom, string leprenom, string ladresse, string letel, int ledepartement, ClasseSpecialite lSpecialite) : base(lid, lenom, leprenom, ladresse)
        {
            tel = letel;
            departement = ledepartement;
            laSpecialite = lSpecialite;
        }
        #endregion

        #region accesseurs
        public string Tel
        {
            get => tel;
        }
        public int Departement
        {
            get => departement;
        }
        public ClasseSpecialite LaSpecialite {
            get => laSpecialite;
        }

        #endregion

        #region méthodes

        #endregion
    }
}
