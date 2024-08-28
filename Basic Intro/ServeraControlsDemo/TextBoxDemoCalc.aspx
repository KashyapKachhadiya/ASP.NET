<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxDemoCalc.aspx.cs" Inherits="WebApplication1.ServeraControlsDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/bootstrapcontent/css/bootstrap.min.css" rel="stylesheet" />
<link href="~/bootstrapcontent/css/bootstrap-theme.min.css" rel="stylesheet" />
<script src="~/bootstrapcontent/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox ID="txtNo1" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtNo2" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Button ID="btnAdd" runat="server" Text="Add (+)" OnClick="btnAdd_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lblAnswer" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
