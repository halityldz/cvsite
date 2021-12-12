using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KonferansGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int s = Convert.ToInt16(Request.QueryString["ID"]);
        txtid.Text = s.ToString();
        txtid.Enabled = false;

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLKONFERANSLARTableAdapter dt = new DataSetTableAdapters.TBLKONFERANSLARTableAdapter();
            txtkonferans.Text = dt.KonferansGetir(Convert.ToInt16(s))[0].KONFERANS;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLKONFERANSLARTableAdapter dt = new DataSetTableAdapters.TBLKONFERANSLARTableAdapter();
        dt.KonferansGuncelle(txtkonferans.Text, Convert.ToInt16(txtid.Text));
        Response.Redirect("KonferansListesi.aspx");
    }
}