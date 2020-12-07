using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
   public class ClasseMedicament 
   {
        #region attribut

        private string id;
        private string nomCommercial;
        private string effets;
        private string contreindictions;
        private ClasseFamille famille;
        #endregion

        #region Accesseur

        public string Id { get => id; set => id = value; }
        public string NomCommercial { get => nomCommercial; set => nomCommercial = value; }
        public string Effets { get => effets; set => effets = value; }
        public string Contreindictions { get => contreindictions; set => contreindictions = value; }
        public ClasseFamille Famille { get => famille; set => famille = value; }
        #endregion

        #region Constructeur

        public ClasseMedicament(string unid, string unnomcomposition, string deseffets, string unecontreindictions)
        {
            id = unid;
            nomCommercial = unnomcomposition;
            effets = deseffets;
            contreindictions = unecontreindictions;
        }

        public ClasseMedicament(string unid, string unnomcomposition, string deseffets, string unecontreindictions , ClasseFamille lafamille)
        {
            id = unid;
            nomCommercial = unnomcomposition;
            effets = deseffets;
            contreindictions = unecontreindictions;
            famille = lafamille;

            
        }
        #endregion
   }
}
