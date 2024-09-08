<%@ Page Title="" Language="C#" MasterPageFile="~/AddreeBook/Content/AddressBook.Master" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="WebApplication1.AddreeBook.AdmilPanel.City.CityList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    City List
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="row mt-4">
        <div class="col-md-8">
            <h2>List of City</h2>
        </div>
        <div class="col-md-4 text-right">
            <asp:HyperLink ID="hlCountryAdd" runat="server" CssClass="btn btn-dark" NavigateUrl ="~/AddreeBook/AdmilPanel/City/CityAddEdit.aspx" Target="_self">Add</asp:HyperLink>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 m-2">
            <asp:Label ID="lblTemp" runat="server" EnableViewState="false"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 m-2 text-Black">
            <asp:GridView ID="gvCity" runat="server" OnRowCommand="gvCountry_RowCommand">
                <Columns>

                    <asp:TemplateField HeaderText="Modify Data">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDelete" CssClass="btn btn-danger btn-sm mr-3" runat="server" Text="Delete"
                                CommandName="DeleteRecord" CommandArgument='<%# Eval("CityID").ToString() %>' />
                            <asp:HyperLink ID="hlEdit" CssClass="btn btn-primary btn-sm mr-0" runat="server" Text="Edit"
                                NavigateUrl='<%# "~/AddreeBook/AdmilPanel/Country/CountryAddEdit.aspx?CountryID=" + Eval("CityID").ToString().Trim()  %>'
                                CommandName="EditRecord" CommandArgument='<%# Eval("CityID").ToString() %>'></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="CityID" HeaderText="City ID" />
                    <asp:BoundField DataField="CityName" HeaderText="City Name" />
                    <asp:BoundField DataField="StateID" HeaderText="State ID" />
                    <asp:BoundField DataField="CountryID" HeaderText="Country ID" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
