<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact_AddEdit.aspx.cs" Inherits="WebApplication1.FIle_Upload.Contact_AddEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <h1>Contact Add Edit Form</h1>
        <p>&nbsp;</p>
        <p>
            <asp:Label ID="lblMsg" runat="server" EnableViewState="False"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>Contact Name : <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>Upload Photo : <asp:FileUpload ID="fuContactPhoto" runat="server" />
        </p>
        <p>&nbsp;</p>
        <p>Contact Category :
            <asp:CheckBoxList ID="cblContactCategory" runat="server">
            </asp:CheckBoxList>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="btnSave" runat="server" BackColor="#000000" ForeColor="White" OnClick="btnSave_Click" Text="Save" />
        </p>
    </form>
</body>
</html>
