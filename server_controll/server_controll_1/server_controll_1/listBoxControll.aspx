<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listBoxControll.aspx.cs" Inherits="server_controll_1.listBoxControll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem>식품 </asp:ListItem>
                <asp:ListItem>피혁/잡화 </asp:ListItem>
                <asp:ListItem>의류 </asp:ListItem>
                <asp:ListItem>아웃도어/스포츠 </asp:ListItem>
                <asp:ListItem>인테리어/소품 </asp:ListItem>
            </asp:ListBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="결과" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="선택항목"></asp:Label>

        </div>
    </form>
</body>
</html>
