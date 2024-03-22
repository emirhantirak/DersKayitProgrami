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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            EntityBasvuruForm entityForm = new EntityBasvuruForm();

            entityForm.BASOGRID = int.Parse(TextBox1.Text);
            entityForm.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(entityForm);
        }
    }
}