<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="DangerList.aspx.cs" Inherits="wxwpdjWeb.DangerList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="background:#ffffff;padding:50px;">
    <div>
        <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="危险物品"></asp:Label>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="携带者"></asp:Label>
            <asp:TextBox ID="tbXdzName" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="身份证号"></asp:Label>
            <asp:TextBox ID="tbXdzSfzh" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="分类"></asp:Label>
            <asp:TextBox ID="tbCatagory" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DangerAdd.aspx">新增</asp:HyperLink>
            <hr />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="width:100%">
                <Columns>
                    <asp:BoundField DataField="djrq" HeaderText="登记日期" DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="name" HeaderText="用户名" />
                    <asp:BoundField DataField="xdz_name" HeaderText="携带者" />
                    <asp:BoundField DataField="xdz_sex" HeaderText="性别" />
                    <asp:BoundField DataField="xdz_phone" HeaderText="电话" />
                    <asp:BoundField DataField="xdz_sfzh" HeaderText="身份证号" />
                    <asp:BoundField DataField="catagory" HeaderText="分类" />
                    <asp:BoundField DataField="remark" HeaderText="备注" />


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"DangerEdit.aspx?id="+Eval("id")%>'>修改</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"DangerDelete.aspx?id="+Eval("id")%>'>删除</asp:HyperLink>
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
