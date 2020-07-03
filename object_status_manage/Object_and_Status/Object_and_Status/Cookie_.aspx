<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie_.aspx.cs" Inherits="Object_and_Status.Cookie_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="관심 영역을 선택하세요"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>뮤지컬</asp:ListItem>
                <asp:ListItem>영화</asp:ListItem>
                <asp:ListItem>연극</asp:ListItem>
                <asp:ListItem>콘서트</asp:ListItem>
                <asp:ListItem>문화체험</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="새로고침" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
