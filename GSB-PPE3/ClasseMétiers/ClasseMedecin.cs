﻿using System;
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

        #endregion
    }
}
