<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image_controll.aspx.cs" Inherits="server_controll_1.image_controll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="imgBtn" runat="server" AlternateText="배너이미지" ImageUrl="~/image/1.jpg"  OnClick="imgBtn_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" />
        </div>
    </form>
</body>
</html>
