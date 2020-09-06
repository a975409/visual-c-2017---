<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ex16_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [參賽者] WHERE [編號] = @編號" InsertCommand="INSERT INTO [參賽者] ([編號], [姓名], [性別], [電話]) VALUES (@編號, @姓名, @性別, @電話)" SelectCommand="SELECT * FROM [參賽者]" UpdateCommand="UPDATE [參賽者] SET [姓名] = @姓名, [性別] = @性別, [電話] = @電話 WHERE [編號] = @編號">
            <DeleteParameters>
                <asp:Parameter Name="編號" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="編號" Type="String" />
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="性別" Type="String" />
                <asp:Parameter Name="電話" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="性別" Type="String" />
                <asp:Parameter Name="電話" Type="String" />
                <asp:Parameter Name="編號" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="編號" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="編號" HeaderText="編號" ReadOnly="True" SortExpression="編號" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="性別" HeaderText="性別" SortExpression="性別" />
                <asp:BoundField DataField="電話" HeaderText="電話" SortExpression="電話" />
            </Columns>
        </asp:GridView>
        <br />
        新增資料<br />
        <br />
        編號 :&nbsp;
        <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
        <br />
        姓名 :&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        性別 :&nbsp;
        <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
        <br />
        電話 :&nbsp;
        <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="新增" />
&nbsp;&nbsp;
        <asp:Button ID="btnCls" runat="server" OnClick="btnCls_Click" Text="清除" />
    
    </div>
    </form>
</body>
</html>
