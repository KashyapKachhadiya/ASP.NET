<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultCalc.aspx.cs" Inherits="WebApplication1.ResultCalc.ResultCalc" %>

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
                    OS Marks (out of 100) :
                    <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    C++ Marks (out of 100) :
                    <asp:TextBox ID="txtbox2" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    CN Marks (out of 100) :
                    <asp:TextBox ID="txtbox3" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    CO Marks (out of 100) :
                    <asp:TextBox ID="txtbox4" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    Maths Marks (out of 100) :
                    <asp:TextBox ID="txtbox5" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>               
            <div class="row">
                <div class="col-md-3">
                    <asp:Button ID="btngetresult" runat="server" OnClick="btngetresult_Click" Text="Calculate Result" />
                </div>
                <div class="col-md-3">
                    Percentage :
                    <asp:TextBox ID="txtPercentage" runat="server" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                </div>
                <div class="col-md-3">
                    Class :
                    <asp:TextBox ID="txtClass" runat="server" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
                </div>
            </div>

        </div>
        
    </form>
</body>
</html>
