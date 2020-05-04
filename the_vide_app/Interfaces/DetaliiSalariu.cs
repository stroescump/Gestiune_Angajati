using System;
using System.Collections.Generic;
using System.Text;

namespace the_vide_app.Interfaces
{
    interface DetaliiSalariu
    {
        double calculeazaSalariuNet(double salariuBrut);
        double calculeazaImpozit(double salariuBrut);
        double calculeazaBonus(double salariuBrut, float procentBonus);
    }
}
