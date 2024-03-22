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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrID"].ToString());
            TxtID.Text = x.ToString();
            TxtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);

                TxtAd.Text = OgrList[0].AD.ToString();
                TxtSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].NUMARA.ToString();
                TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
                TxtSifre.Text = OgrList[0].SIFRE.ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();

            entityOgrenci.AD = TxtAd.Text;
            entityOgrenci.SOYAD = TxtSoyad.Text;
            entityOgrenci.SIFRE = TxtSifre.Text;
            entityOgrenci.NUMARA = TxtNumara.Text;
            entityOgrenci.FOTOGRAF = TxtNumara.Text;
            entityOgrenci.ID = Convert.ToInt32(TxtID.Text);

            BLLOgrenci.OgrenciGuncelleBLL(entityOgrenci);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}