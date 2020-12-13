<%@ Page Title="" Language="C#" MasterPageFile="~/EditSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wxwpdjWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #form1{
            margin: 100px auto;
            width:280px;
            padding:20px;
            background:rgba(165, 165, 165, 0.83);

        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label></td>
                <td><asp:TextBox ID="tbCode" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="tbCode" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="密码"></asp:Label></td>
                <td><asp:TextBox ID="tbPwd" type="password" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="用户密码不能为空" ControlToValidate="tbPwd" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click"/>
                    <button type="reset" style="margin-left:20px">重置</button>
                </td>
                <td></td>
            </tr>
        </table>
    </form>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
