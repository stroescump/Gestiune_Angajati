using System;
using System.Collections.Generic;
using System.Text;
using the_vide_app.Interfaces;
using the_vide_app.CSO_IMPOZIT;

namespace the_vide_app.Classes
{
    [Serializable]
    class Muncitor : DetaliiSalariu
    {
        private string nume;
        private string angajator;
        private double salariu;
        private string profilePicPath;
        private int CAS = Convert.ToInt32(cotatii.ResourceManager.GetString("CAS"));
        private int CASS = Convert.ToInt32(cotatii.ResourceManager.GetString("CASS"));
        private int IMPOZIT_VENIT = Convert.ToInt32(cotatii.ResourceManager.GetString("IMPOZIT_VENIT"));

        public double calculeazaBonus(double salariuBrut, float procentBonus)
        {
            try
            {

                double salariuNet = salariuBrut - (salariuBrut * (CAS + CASS + IMPOZIT_VENIT));
                return salariuNet * procentBonus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double calculeazaImpozit(double salariuBrut)
        {
            return salariuBrut * (CAS + CASS + IMPOZIT_VENIT);
        }

        public double calculeazaSalariuNet(double salariuBrut)
        {
            return salariuBrut - (salariuBrut * (CAS + CASS + IMPOZIT_VENIT));
        }
    }
}
