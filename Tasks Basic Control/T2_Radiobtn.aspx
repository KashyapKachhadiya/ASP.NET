<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T2_Radiobtn.aspx.cs" Inherits="WebApplication1.Tasks_Basic_Control.T2_Radiobtn" %>

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
            <h1>CHAROTAR UNIVERSITY OF SCIENCE AND TECHNOLOGY</h1>
            <p>&nbsp;</p>

            <h3>Select Your College : </h3>
            <asp:RadioButton ID="rbtnDEPSTAR" runat="server" GroupName="College" Text="DEPSTAR" />
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbtnCSPIT" runat="server" GroupName="College" Text="CSPIT" />
            <br />
            <br />

            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />

            <br />

            <asp:Label ID="lblTest" runat="server"></asp:Label>

            <br />
            <br />

            <h3>Select Your Branch :</h3>
            <asp:RadioButton ID="rbtnBranch1" runat="server" GroupName="Branch" Text="" Visible="False"/>
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbtnBranch2" runat="server" GroupName="Branch" Text="" Visible="False"/>
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbtnBranch3" runat="server" GroupName="Branch" Text="" Visible="False"/>
        </div>
    </form>
</body>
</html>
