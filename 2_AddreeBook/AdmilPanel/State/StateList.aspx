<%@ Page Title="" Language="C#" MasterPageFile="~/AddreeBook/Content/AddressBook.Master" AutoEventWireup="true" CodeBehind="StateList.aspx.cs" Inherits="WebApplication1.AddreeBook.AdmilPanel.State.StateList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    State List
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="row mt-4">
        <div class="col-md-8">
            <h2>List of States</h2>
        </div>
        <div class="col-md-4 text-right">
            <asp:HyperLink ID="hlStateAdd" runat="server" CssClass="btn btn-dark" NavigateUrl="~/AddreeBook/AdmilPanel/State/StateAddEdit.aspx" Target="_self">Add Data</asp:HyperLink>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 m-2 text-Black">
            <asp:GridView ID="gvState" runat="server" OnRowCommand="gvState_RowCommand" >

                <Columns>
                    <asp:TemplateField HeaderText="Modify Data">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDelete"  CssClass="btn btn-danger btn-sm mr-3" runat="server" Text="Delete"
                                CommandName="DeleteRecord" CommandArgument='<%# Eval("StateID").ToString() %>' />
                            <asp:HyperLink ID="hlEdit" CssClass="btn btn-primary btn-sm mr-0" runat="server" Text="Edit"
                                NavigateUrl='<%# "~/AddreeBook/AdmilPanel/State/StateAddEdit.aspx?StateID=" + Eval("StateID").ToString().Trim()  %>'
                                CommandName="EditRecord" CommandArgument='<%# Eval("StateID").ToString() %>'>

                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="StateID" HeaderText="State ID" />
                    <asp:BoundField DataField="StateName" HeaderText="State Name" />
                    <asp:BoundField DataField="StateCode" HeaderText="State Code" />
                    <asp:BoundField DataField="CountryID" HeaderText="Country ID" />
                    <asp:BoundField DataField="StateCapital" HeaderText="State Capital" />
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
