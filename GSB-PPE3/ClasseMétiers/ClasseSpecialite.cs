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
        // propriétés privées
        private int id;
        private string specialite;

        #endregion

        #region constructeurs
        // constructeur de la classe spécialité
        public ClasseSpecialite()
        {

        }
        public ClasseSpecialite(int lid, string laspecialite)
        {
            id = lid;
            specialite = laspecialite;
        }


        #endregion

        #region accesseurs
        public int Id {
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
