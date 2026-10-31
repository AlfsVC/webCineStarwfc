using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCineStar.dao;

namespace webCineStar
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idPelicula = Request.QueryString["idPeliculas"];
            if (!string.IsNullOrEmpty(idPelicula))
            {
                PeliculasDAO peliculasDAO = new PeliculasDAO();
              
                rptPeliculas.DataSource = peliculasDAO.getPeliculas(idPelicula);
                rptPeliculas.DataBind();
            }
            else
            {
                Response.Redirect("inicio.aspx");
            }
        }
    }
}