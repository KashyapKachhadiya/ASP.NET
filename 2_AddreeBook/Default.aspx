<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.AddreeBook.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Optionally include jQuery -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <!-- Bootstrap JS CDN -->
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <div class ="row">
                <div class ="col-md-12 text center">
                    <h1> Existing User Login to Address Book</h1>
                </div>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblmsg" EnableViewState="False"/>
                </div>
            </div>

            <div class="row">
               <div class="col-md-4">
                    <label for="txtUserName">User Name :</label>
                    <asp:TextBox ID="txtUserNameLogin" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <label for="txtPassword">Password :</label>
                    <asp:TextBox ID="txtPasswordLogin" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>

            </div>

            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-6">
                    <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn btn-dark" OnClick="btnLogin_Click" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
