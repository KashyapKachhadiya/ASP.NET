<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxDemo1.aspx.cs" Inherits="WebApplication1.ServeraControlsDemo.TextBoxDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/bootstrapcontent/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/bootstrapcontent/css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="~/bootstrapcontent/js/bootstrap.min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4">txtbox1 :
                    <asp:TextBox ID="txtNo1" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Button ID="btnCopy" runat="server" OnClick="btnCopy_Click" Text="Copy" />
                </div>
                <div class="col-md-4">txtbox2 :
                    <asp:TextBox ID="txtNo2" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
