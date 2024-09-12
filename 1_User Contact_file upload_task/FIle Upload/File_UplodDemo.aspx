<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="File_UplodDemo.aspx.cs" Inherits="WebApplication1.FIle_Upload.File_UplodDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select File to Upload<br />
            <br />
            <asp:FileUpload ID="fuFile" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDeleteFile" runat="server" BackColor="Red" ForeColor="White" Text="Delete File" OnClick="btnDeleteFile_Click" />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server" EnableViewState="False"></asp:Label>
        </div>
    </form>
</body>
</html>
