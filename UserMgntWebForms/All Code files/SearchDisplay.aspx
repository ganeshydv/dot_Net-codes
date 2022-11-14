<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMgmtAdmin.Master" AutoEventWireup="true" CodeBehind="SearchDisplay.aspx.cs" Inherits="UserMgmtWebForms.Admin.SearchDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 417px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h5 class="smallHeading">Search and Display users</h5>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/EditUser.aspx">Edit user</asp:HyperLink>
    <br />
    <div>
        <asp:HyperLink ID="hl1" runat="server" 
            NavigateUrl="~/admin/newuser.aspx" Text="Add New User"></asp:HyperLink>


    </div>
    <div>
        <table width="40%" align="center">
            <tr>
                <td>
                    <span>Enter name</span>
                    <asp:TextBox ID="NameSearch" 
                        runat="server"></asp:TextBox>
                    <asp:Button ID="SaerchBtn" runat="server"
                        Text="Search" OnClick="SaerchBtn_Click"  />
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div>
        <asp:GridView ID="GridView1" runat="server" OnLoad="GridView1_Load"></asp:GridView>
        <asp:Button ID="delUsr" runat="server" CssClass="auto-style1" OnClick="delUsr_Click" Text="Delete User" />
        <br />
    </div>
</asp:Content>
