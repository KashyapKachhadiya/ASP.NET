<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo_DropDownList.aspx.cs" Inherits="WebApplication1.TaskDropDownList.Demo_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="~/Content/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            Country Name:
            <asp:TextBox runat="server" ID="txtCountryName" /><br />
            Country Code:
            <asp:TextBox runat="server" ID="txtCountryCode" /><br />
            <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click"  />
            <asp:Button ID="btnRemove" runat="server" Text="Remove Item" OnClick="btnRemove_Click"  />

            <br />
            --------------------------------------------------------------<br />
            <br />

            <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
           <%-- <asp:ListItem Value="91">India</asp:ListItem>
                <asp:ListItem Value="92">China</asp:ListItem>
                <asp:ListItem Value="93">Sri Lanka</asp:ListItem>
                <asp:ListItem Value="94">Bangladesh</asp:ListItem>
                <asp:ListItem Value="95">Nepal</asp:ListItem>
                <asp:ListItem Value="96">USA</asp:ListItem>
                <asp:ListItem Value="97">Australia</asp:ListItem> --%>
        </asp:DropDownList>

            <br />
            <asp:Button runat="server" ID="btnDisplay" Text="Display" />
            <br />
            <asp:Label runat="server" ID="lblMessage" EnableViewState="False" />


        </div>
    </form>
</body>
</html>
