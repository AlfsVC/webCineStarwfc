using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webCineStar.dao
{
    public class CinesDAO
    {
        wcfCineStarCines.CineStarClient servicio = new wcfCineStarCines.CineStarClient();

      internal object getCines()
      {
            return servicio.getCines().Tables[0];
      }
    }
}