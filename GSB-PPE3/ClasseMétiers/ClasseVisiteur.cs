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
        private string login;
        private string mdp;
        private string cp;
        private string ville;
        private DateTime dateEmbauche;
        #endregion

        #region constructeurs

        public ClasseVisiteur(string lid, string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche) : base(lid, lenom, leprenom, ladresse)
        {
            login = lelogin;
            mdp = lemdp;
            cp = lecp;
            ville = laville;
            dateEmbauche = ladateEmbauche;
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
