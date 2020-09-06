<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ex16_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>歌唱比賽</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="jquery-1.11.3.min.js"></script>
    <link href="jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <script src="jquery.mobile-1.4.5.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div data-role="page">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT 參賽者.編號, 參賽者.姓名, 成積一.音色50, 成積二.技巧30, 成積三.儀態20 FROM 成積一 INNER JOIN 參賽者 ON 成積一.編號 = 參賽者.編號 INNER JOIN 成積二 ON 參賽者.編號 = 成積二.編號 INNER JOIN 成積三 ON 參賽者.編號 = 成積三.編號"></asp:SqlDataSource>
        <div data-role="header"><h3>比賽成績</h3></div>
        <div data-role="content">
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="編號" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <div data-role="collapsible-set">
                        <div data-role="collapsible">
                            <h3><%# Eval("姓名") %></h3>
                            <h5>編號：<%# Eval("編號") %></h5>
                            <h5>音色：<%# Eval("音色50") %></h5>
                            <h5>技巧：<%# Eval("技巧30") %></h5>
                            <h5>儀態：<%# Eval("儀態20") %></h5>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div data-role="footer" data-position="fixed"><h3>美聲獎歌唱比賽</h3></div>
    </form>
</body>
</html>
