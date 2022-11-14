<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMgmtAdmin.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="UserMgmtWebForms.Admin.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 73px;
        }
        .auto-style2 {
            width: 173px;
            height: 37px;
        }
        .auto-style3 {
            width: 205px;
            height: 37px;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            width: 205px;
            height: 32px;
        }
        .auto-style6 {
            width: 173px;
            height: 32px;
        }
        .auto-style7 {
            height: 32px;
            width: 206px;
        }
        .auto-style8 {
            width: 206px;
            height: 37px;
        }
        .auto-style9 {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    Edit User Details<br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
    <asp:DropDownList ID="NameDropDown" runat="server" OnLoad="nameDropDown_Load">
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" OnClick="SearchButton_Click" Text="Search" />
    <div _designerregion="0">
        <table class="auto-style1" id="updtUsrTbl" runat="server" >
            <tr>
                <td class="auto-style5">Id</td>
                <td class="auto-style5">Name</td>
                <td class="auto-style6">Dob</td>
                <td class="auto-style4">Mob</td>
                <td class="auto-style7">Email</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                </td>
                <td class="auto-style9">Role</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="selectRole" runat="server" OnLoad="selectRole_Load">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
