<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact_Form.aspx.cs" Inherits="WebApplication1.FIle_Upload.Contact_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Contact Details Form<br />
            <br />
            Contact Name : <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
            <br />
            <br />
            Contact Photo :
            <asp:FileUpload ID="fuContactPhotoPath" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server" EnableViewState="False" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
