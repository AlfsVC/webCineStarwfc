using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webCineStar.dao
{
    public class PeliculasDAO
    {
        wcfCineStarCines.CineStarClient servicio = new wcfCineStarCines.CineStarClient();
        internal object getPeliculas(string idPelicula)
        {
            return servicio.getPeliculas(idPelicula).Tables[0];
        }
        internal object getPelicula(string idPelicula)
        {
            return servicio.getPelicula(idPelicula).Tables[0];
        }

    }
}