using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClassePersonne
    {

        #region propriétés privées
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        #endregion

        #region constructeurs
        public ClassePersonne()
        {
        }
        public ClassePersonne(int lid, string lenom, string leprenom, string ladresse)
        {
            id = lid;
            nom = lenom;
            prenom = leprenom;
            adresse = ladresse;
        }

        #endregion

        #region accesseurs
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nom
        {
            get => nom;
            set => nom = value;
        }
        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }
        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        #endregion

        #region méthodes

        #endregion

    }
}