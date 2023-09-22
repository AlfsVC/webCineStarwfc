using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webCineStar.dao
{
    public class CinesDAO
    {
        wcfCineStarcines.CineStarClient servicio = new wcfCineStarcines.CineStarClient();

      internal object getCines()
      {
            return servicio.getCines().Tables[0];
      }
    }
}