<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radioBtn.aspx.cs" Inherits="server_controll_1.radioBtn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="소식지를 받아보시겠습니까?"></asp:Label>
            <br />
            <asp:RadioButton ID="r1" runat="server" AutoPostBack="True" GroupName="aa" OnCheckedChanged="r1_CheckedChanged" Text="네" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="r2" runat="server" AutoPostBack="True" GroupName="aa" OnCheckedChanged="r2_CheckedChanged" Text="아니오" />
        </div>
    </form>
</body>
</html>
