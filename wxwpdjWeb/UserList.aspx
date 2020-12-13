<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="wxwpdjWeb.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="background:#ffffff;padding:50px;">
    <div>
        <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            <asp:TextBox ID="tbCode" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="性别"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>男</asp:ListItem>
                <asp:ListItem>女</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/UserAdd.aspx">新增</asp:HyperLink>
            <hr />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="width:100%">
                <Columns>
                    <asp:BoundField DataField="code" HeaderText="用户名" />
                    <asp:BoundField DataField="name" HeaderText="用户姓名" />
                    <asp:BoundField DataField="sex" HeaderText="用户性别" />
                    <asp:BoundField DataField="birthday" HeaderText="出生日期" DataFormatString="{0:d}"/>


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"UserEdit.aspx?code="+Eval("code")%>'>修改</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"UserDelete.aspx?code="+Eval("code")%>'>删除</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>


                </Columns>
            </asp:GridView>

        </form>
    </div>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
