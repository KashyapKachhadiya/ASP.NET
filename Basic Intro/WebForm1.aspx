<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            UserName :&nbsp;
            <asp:TextBox ID="txtUserName" runat="server" BackColor="#CCFFFF" BorderColor="#CCFFCC" ></asp:TextBox>
        </p>
        <p>
            Password :&nbsp;&nbsp; <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            Address :
            <asp:TextBox ID="txtAddress" runat="server" Columns="10" MaxLength="200" OnTextChanged="txtAddress_TextChanged" Rows="3" TextMode="MultiLine"></asp:TextBox>
        </p>
    </form>
</body>
</html>
