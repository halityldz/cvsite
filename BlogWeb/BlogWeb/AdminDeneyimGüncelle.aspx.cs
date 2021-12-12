using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGüncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
            TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
            TxtAltbaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
            TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
            TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
        dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltbaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminDeneyimler.Aspx");
    }
}