using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClasseVisiteur : ClassePersonne
    {

        #region propriétés privées
        private string cp;
        private string ville;
        private string login;
        private string mdp;
        private DateTime dateEmbauche;
        #endregion

        #region constructeurs
        public ClasseVisiteur() 
        {

        }
        public ClasseVisiteur(int lid, string lenom, string leprenom, string ladresse, string lecp, string laville, DateTime ladateEmbauche) : base(lid, lenom, leprenom, ladresse)
        {
            cp = lecp;
            ville = laville;
            dateEmbauche = ladateEmbauche;
        }
        public ClasseVisiteur(int lid, string lenom, string leprenom, string ladresse, string lecp, string laville, string lelogin, string lemdp, DateTime ladateEmbauche) : base(lid, lenom, leprenom, ladresse)
        {
            cp = lecp;
            ville = laville;
            dateEmbauche = ladateEmbauche;
            login = lelogin;
            mdp = lemdp;
        }
        #endregion

        #region accesseurs
        public string Cp {
            get => cp;
            set => cp = value;
        }
        public string Ville {
            get => ville;
        }
        public DateTime DateEmbauche {
            get => dateEmbauche;
        }

        #endregion

        #region méthodes

        #endregion

    }
}
