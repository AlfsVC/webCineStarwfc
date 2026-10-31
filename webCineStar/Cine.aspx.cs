using System;
using webCineStar.dao;

namespace webCineStar
{
    public partial class Cine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idCine = Request.QueryString["idCine"];
            if (!string.IsNullOrEmpty(idCine))
            {
                CineDAO cineDAO = new CineDAO();

                fvCine.DataSource = cineDAO.getCine(idCine);
                fvCine.DataBind();
         
                rptTarifas.DataSource = cineDAO.getTarifas(idCine);
                rptTarifas.DataBind();

                rptPeliculas.DataSource = cineDAO.getCinePeliculas(idCine);
                rptPeliculas.DataBind();
            
                imgCine.ImageUrl = "~/img/cine/" + idCine + ".2.jpg";
            }
            else
            {
              
                Response.Redirect("inicio.aspx");
            }
        }
    }
}