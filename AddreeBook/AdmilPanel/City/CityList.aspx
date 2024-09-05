<%@ Page Title="" Language="C#" MasterPageFile="~/AddreeBook/Content/AddressBook.Master" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="WebApplication1.AddreeBook.AdmilPanel.City.CityList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    City List
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="row">
    <div class="col-md-12 m-2">
        <h2>List of City</h2>
    </div>
</div>
<div class="row">
    <div class="col-md-12 m-2 text-Black">
        <asp:GridView ID="gvCity" runat="server" ></asp:GridView>
    </div>
</div>
</asp:Content>
