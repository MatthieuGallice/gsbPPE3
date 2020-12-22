using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClasseFamille
    {
        #region attribut
        private int id_famille;
        private string libelle;

        #endregion

        #region Accesseur 

        public int Id_famille1 { get => id_famille; set => id_famille = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        #endregion

        #region constructeur
        public ClasseFamille(int id, string lib)
        {
            id_famille = id;
            libelle = lib;
        }
        #endregion

        


    }



}
