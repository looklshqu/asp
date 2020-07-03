<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="server_controll_1.dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="지출항목중 가장 큰 비중은 무엇입니까?"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>식료품비</asp:ListItem>
                <asp:ListItem>세금/공과금</asp:ListItem>
                <asp:ListItem>육아/교육비</asp:ListItem>
                <asp:ListItem>의류비</asp:ListItem>
                <asp:ListItem>경조사비</asp:ListItem>
                <asp:ListItem>외식/문화생활비</asp:ListItem>
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="결과보기" />

        </div>
    </form>
</body>
</html>
