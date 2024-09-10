<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncryptDecryptDemo.aspx.cs" Inherits="WebApplication1.EncryptDecryptDemo.EncryptDecryptDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter txt :
            <asp:TextBox ID="txtencrypt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnencrypt" runat="server" OnClick="btnencrypt_Click" Text="Encrypt" />
            <br />
            <br />
            <asp:Label ID="lblencrypt" runat="server" EnableViewState="False"></asp:Label>
            <br />
            <br />
            Enter Code :&nbsp;
            <asp:TextBox ID="txtdecrypt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btndcrypt" runat="server" OnClick="btndcrypt_Click" Text="Decrypt" />
            <br />
            <br />
            <asp:Label ID="lbldecrypt" runat="server" EnableViewState="False"></asp:Label>
        </div>
    </form>
</body>
</html>
