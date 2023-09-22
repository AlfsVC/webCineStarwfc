using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCineStar.dao;

namespace webCineStar
{
    public partial class Cines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptCines.DataSource = new CinesDAO().getCines();
            rptCines.DataBind();
        }
    }
}