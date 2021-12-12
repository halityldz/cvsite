using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HobiGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtid.Text = x.ToString();
        txtid.Enabled = false;

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLHOBILERTableAdapter dt = new DataSetTableAdapters.TBLHOBILERTableAdapter();
            txthobi.Text= dt.HobiGetir(Convert.ToInt16(txtid.Text))[0].HOBI;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLHOBILERTableAdapter dt = new DataSetTableAdapters.TBLHOBILERTableAdapter();
        dt.HobiGuncelle(txthobi.Text, Convert.ToInt16(txtid.Text));
        Response.Redirect("HobiListesi.aspx");
    }
}