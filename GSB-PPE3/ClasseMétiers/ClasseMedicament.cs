using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
   public class ClasseMedicament 
   {
        #region propriété privées 

        private string id;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreindications;
        private ClasseFamille famille;
        #endregion

        #region Accesseur

        public string Id { get => id; set => id = value; }
        public string NomCommercial { get => nomCommercial; set => nomCommercial = value; }
        public string Effets { get => effets; set => effets = value; }
        public string Contreindictions { get => contreindications; set => contreindications = value; }
        public ClasseFamille Famille { get => famille; set => famille = value; }
        public string Composition { get => composition; set => composition = value; }
        #endregion

        #region Constructeur
        public ClasseMedicament() { }
        public ClasseMedicament(string unid, string unnomcomposition, string unecomposition, string deseffets, string unecontreindications)
        {
            id = unid;
            nomCommercial = unnomcomposition;
            Composition = unecomposition;
            effets = deseffets;
            contreindications = unecontreindications;
        }

        public ClasseMedicament(string unid, string unnomcomposition, string unecomposition, string deseffets, string unecontreindications , ClasseFamille lafamille)
        {
            id = unid;
            nomCommercial = unnomcomposition;
            Composition = unecomposition;
            effets = deseffets;
            contreindications = unecontreindications;
            famille = lafamille;

            
        }
        #endregion
   }
}
