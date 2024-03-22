using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YazOkuluDersler
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrID"]);
            Response.Write(x);

            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.ID = x;
            BLLOgrenci.OgrenciSilBLL(Convert.ToInt32(entityOgrenci.ID));
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}