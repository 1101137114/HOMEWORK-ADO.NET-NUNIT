<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7_HW2.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        美元：
        <asp:TextBox ID="txtUSD" runat="server"></asp:TextBox>
        <asp:DropDownList ID="select" runat="server">
            <asp:ListItem Value="TWD">台幣</asp:ListItem>
            <asp:ListItem Value="JPY">日幣</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnCal" runat="server" Text="計算" OnClick="btnCal_Click" />
        </br>
        </br>
         轉換：
        <asp:Label ID="result" runat="server" Text=""></asp:Label>$
    </div>
    </form>
</body>
</html>
