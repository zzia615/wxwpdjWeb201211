<%@ Page Title="" Language="C#" MasterPageFile="~/EditSite.Master" AutoEventWireup="true" CodeBehind="DangerAdd.aspx.cs" Inherits="wxwpdjWeb.DangerAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #form1{
            margin: 100px auto;
            width:300px;
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
                <td><asp:Label ID="Label1" runat="server" Text="物品名称"></asp:Label></td>
                <td><asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="物品名称不能为空" ControlToValidate="tbName" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="携带者"></asp:Label></td>
                <td><asp:TextBox ID="tbXdzName" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="携带者不能为空" ControlToValidate="tbXdzName" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="性别"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="tbXdzSex" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="性别不能为空" ControlToValidate="tbXdzSex" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Text="电话"></asp:Label></td>
                <td><asp:TextBox ID="tbXdzPhone" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="电话不能为空" ControlToValidate="tbXdzPhone" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label15" runat="server" Text="身份证号"></asp:Label></td>
                <td><asp:TextBox ID="tbXdzSfzh" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label16" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="身份证号不能为空" ControlToValidate="tbXdzSfzh" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>

            <tr>
                <td><asp:Label ID="Label11" runat="server" Text="分类"></asp:Label></td>
                <td><asp:TextBox ID="tbCatagory" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label12" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="分类不能为空" ControlToValidate="tbCatagory" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label13" runat="server" Text="备注"></asp:Label></td>
                <td><asp:TextBox ID="tbRemark" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click"/>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DangerList.aspx">返回危险物品列表</asp:HyperLink>
                </td>
                <td></td>
            </tr>
        </table>
    </form>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
