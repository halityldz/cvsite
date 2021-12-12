<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimler.aspx.cs" Inherits="AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">

        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>BAŞLIK</th>
                <th>ALT BAŞLIK</th>
                <th>AÇIKLAMA</th>
                <th>TARİH</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:repeater id="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("ID")%></th>
                        <td><%# Eval("BASLIK")%></td>
                        <td><%# Eval("ALTBASLIK")%></td>
                        <td><%# Eval("ACIKLAMA")%></td>
                        <td><%# Eval("TARIH")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimSil.Aspx?ID=" + Eval("ID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimGüncelle.Aspx?ID=" + Eval("ID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:repeater>
            </tbody>
        </table>
        <asp:hyperlink navigateurl="~/AdminDeneyimEkle.aspx" id="HyperLink3" runat="server" cssclass="btn btn-info">Deneyim Ekle</asp:hyperlink>
    </form>

</asp:Content>

