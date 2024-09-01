<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radiobtn_List.aspx.cs" Inherits="WebApplication1.Task_List_Control.Radiobtn_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h1>CHARUSAT UNIVERSITY</h1>
            <p>&nbsp;</p>

            <h3>Select Your College : </h3>

            <asp:RadioButtonList ID="rblCollegeName" runat="server" ></asp:RadioButtonList>
            
            <br />
            <br />

            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />

            <br />
            <br />

            <h3>Select Your Branch :</h3>
            
            <asp:RadioButtonList ID="rblBranchName" runat="server"></asp:RadioButtonList>

            <br />
            <br />

            <asp:Button ID="btnDispaly" runat="server" Text="Result" OnClick="btnDispaly_Click" />

            <br />
            <br />

            <asp:Label ID="lblTest" runat="server" EnableViewState="False"></asp:Label>

        </div>
        </div>
    </form>
</body>
</html>
