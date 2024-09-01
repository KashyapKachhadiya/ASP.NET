<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bulletted_List.aspx.cs" Inherits="WebApplication1.Task_List_Control.Bulletted_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem Value="91">India</asp:ListItem>
                <asp:ListItem Value="92">SriLanka</asp:ListItem>
                <asp:ListItem Value="93">Bangladesh</asp:ListItem>
                <asp:ListItem Value="94">USA</asp:ListItem>
                <asp:ListItem Value="95">Canada</asp:ListItem>
                <asp:ListItem Value="96">Nepal</asp:ListItem>
            </asp:BulletedList>
        </div>
        </div>
    </form>
</body>
</html>
