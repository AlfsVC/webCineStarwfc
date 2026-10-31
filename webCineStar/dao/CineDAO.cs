using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webCineStar.dao
{
    public class CineDAO
    {
        wcfCineStarCines.CineStarClient servicio = new wcfCineStarCines.CineStarClient();

    internal object getCine(string idcine)
    {
         return servicio.getCine(idcine).Tables[0];
    } 
        internal object getTarifas(string idcine)
        {
            return servicio.getTarifas( idcine).Tables[0];
        }
        internal object getPeliculas(string idcine)
        {
            return servicio.getPeliculas( idcine).Tables[0];
        }
        internal object getCinePeliculas(string idcine)
        {
            return servicio.getCinePeliculas(idcine).Tables[0];
        }
    }
}