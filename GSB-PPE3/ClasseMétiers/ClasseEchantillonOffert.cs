using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMétiers
{
    public class ClasseEchantillonOffert
    {
        #region attribut
        private int quantite;
        private List<ClasseMedicament> leMedicament;
        #endregion

        #region Accesseur
        public int Quantite { get => quantite; set => quantite = value; }
        public List<ClasseMedicament> LeMedicament { get => leMedicament; set => leMedicament = value; }

        #endregion

        #region Constructeur
        public ClasseEchantillonOffert(int unequantite , List<ClasseMedicament> unMedicament)
        {
            quantite = unequantite;
            leMedicament = unMedicament;
        }
         #endregion
    }
}
