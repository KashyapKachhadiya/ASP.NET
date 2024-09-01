<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task_ListBox.aspx.cs" Inherits="WebApplication1.TaskDropDownList.Task_ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="~/Content/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 70px;
        }
        .auto-style2 {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <table>

                <tr>
                    <td colspan="3">
                        
                        Country Name:
                        <asp:TextBox runat="server" ID="txtCountryName" /><br /><br />
                        Country Code:
                        <asp:TextBox runat="server" ID="txtCountryCode" /><br /> <br />
                        <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="btnRemove" runat="server" Text="Remove Item" OnClick="btnRemove_Click" />
                        &nbsp;&nbsp;
                        <br /> <br />

                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="libCountry" runat="server" SelectionMode="Multiple">
                            <asp:ListItem Value="91">India</asp:ListItem>
                            <asp:ListItem Value="92">China</asp:ListItem>
                        </asp:ListBox>
                    </td>

                    <td class="auto-style1">
                        <asp:Button runat="server" ID="btnAddselected" Text=">" OnClick="btnAddSelected_Click" /><br />
                        <asp:Button runat="server" ID="btnAddAll" Text=">>" OnClick="btnAddAll_Click" /><br />
                        <asp:Button runat="server" ID="btnRemoveSelected" Text="<" OnClick="btnRemoveSelected_Click" /><br />
                        <asp:Button runat="server" ID="btnRemoveAll" Text="<<" OnClick="btnRemoveAll_Click" /><br />
                    </td>

                    <td>
                        <asp:ListBox ID="libox2" runat="server" SelectionMode="Multiple">

                        </asp:ListBox>
                    </td>
                </tr>


                <tr>
                    <td class="auto-style2">



                        <br />
                        <asp:Button runat="server" ID="btnDisplay" Text="Display" OnClick="btnDisplay_Click" />
                        <br />
                        <asp:Label runat="server" ID="lblMessage" EnableViewState="False" />

                        <br />

                    </td>

                </tr>


            </table>

            
           


        </div>
        <p>
            Here You Can Change The Value Of the Country :</p>
        <p>
            Enter Old Value :-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country Name :&nbsp;
            <asp:TextBox ID="txtOldCname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country Code :&nbsp;
            <asp:TextBox ID="txtOldCcode" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter New Value :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country Name :&nbsp;
            <asp:TextBox ID="txtNewCname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country Code :&nbsp;
            <asp:TextBox ID="txtNewCcode" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnChangeValue" runat="server" Text="Change Value" OnClick="btnChangeValue_Click" />
        </p>
        <p>
            <asp:Label ID="lblcmsg" runat="server" EnableViewState="False"></asp:Label>
        </p>
    </form>
</body>
</html>
