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
        private ClasseMedicament leMedicament;
        private ClasseRapport leRapport;
        private int idRapport;
        #endregion

        #region Accesseur
        public int Quantite { get => quantite; set => quantite = value; }
        public ClasseMedicament LeMedicament { get => leMedicament; set => leMedicament = value; }
        public ClasseRapport LeRapport { get => leRapport; set => leRapport = value; }
        public int IdRapport { get => idRapport; set => idRapport = value; }

        #endregion

        #region Constructeur
        public ClasseEchantillonOffert() { }
        public ClasseEchantillonOffert(int unequantite , ClasseMedicament unMedicament)
        {
            quantite = unequantite;
            leMedicament = unMedicament;
        }

        public ClasseEchantillonOffert(int unequantite, ClasseMedicament unMedicament, ClasseRapport unRapport)
        {
            quantite = unequantite;
            leMedicament = unMedicament;
            LeRapport = unRapport;
        }

        public ClasseEchantillonOffert(int unequantite, ClasseMedicament unMedicament, int codeRapport)
        {
            quantite = unequantite;
            leMedicament = unMedicament;
            idRapport = codeRapport;
        }
        #endregion
    }
}
