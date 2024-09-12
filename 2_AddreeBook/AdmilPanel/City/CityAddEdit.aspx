<%@ Page Title="" Language="C#" MasterPageFile="~/AddreeBook/Content/AddressBook.Master" AutoEventWireup="true" CodeBehind="CityAddEdit.aspx.cs" Inherits="WebApplication1.AddreeBook.AdmilPanel.City.CityAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="row">
        <div class="col-md-12 m-2">
            <h2>City Add / Edit</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="lblMsg" runat="server" EnableViewState="false"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:Label ID="lblCityName" runat="server" Text="City Name : "></asp:Label>
            <asp:RequiredFieldValidator ID="rfvCityName" runat="server" ErrorMessage="**" ControlToValidate="txtCityName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCityName" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="col-md-3">
            <asp:Label ID="lblStateID" runat="server" Text="StateID : "></asp:Label>
            <asp:RequiredFieldValidator ID="rfvStateID" runat="server" ErrorMessage="**" ControlToValidate="ddlStateID" Display="Dynamic" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlStateID" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>

        <div class="col-md-3">
            <asp:Label ID="lblCountryID" runat="server" Text="CountryID : "></asp:Label>
            <asp:RequiredFieldValidator ID="rfvCountryID" runat="server" ErrorMessage="**" ControlToValidate="ddlCountryID" Display="Dynamic" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlCountryID" CssClass="form-control" runat="server" AutoPostBack="True" ></asp:DropDownList>
        </div>
        
        
    </div>
    <div class="row">
        <div class="col-md-12 text-center mt-5">
            <asp:Button ID="btnSave" CssClass=" btn btn-dark" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </div>
</asp:Content>
