<%@ Page Title="" Language="C#" MasterPageFile="~/AddreeBook/Content/AddressBook.Master" AutoEventWireup="true" CodeBehind="StateList.aspx.cs" Inherits="WebApplication1.AddreeBook.AdmilPanel.State.StateList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    State List
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="row">
        <div class="col-md-12 m-2">
            <h2>List of States</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 m-2 text-Black">
            <asp:GridView ID="gvState" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
