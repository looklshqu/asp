<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_1.aspx.cs" Inherits="server_controll_1.test_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" /><br /><br />
            <asp:Button ID="btn_1" text="현재시간" runat="server" OnClick="btn_1_Click" />
        </div>
    </form>
</body>
</html>
