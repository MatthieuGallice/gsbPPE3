using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClasseSpecialite
    {
        #region propriétés privées
        private string id;
        private string specialite;

        #endregion

        #region constructeurs

        public ClasseSpecialite(string lid, string laspecialite)
        {
            id = lid;
            specialite = laspecialite;
        }


        #endregion

        #region accesseurs

        public string Id {
            get => id;
            set => id = value;
        }
        public string Specialite {
            get => specialite;
            set => specialite = value;
        }
        #endregion

        #region méthodes

        #endregion
    }
}
