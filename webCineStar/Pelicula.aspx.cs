using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCineStar.dao;

namespace webCineStar
{
    public partial class Pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            string idPelicula = Request.QueryString["idPelicula"];

            if (idPelicula != null && int.TryParse(idPelicula, out id))
            {
                PeliculasDAO peliculaDAO = new PeliculasDAO();
                frmPelicula.DataSource = peliculaDAO.getPelicula(idPelicula);
                frmPelicula.DataBind();
            }
        }
    }
}