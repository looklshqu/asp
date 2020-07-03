<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hyperlink_conttroll.aspx.cs" Inherits="server_controll_1.hyperlink_conttroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.com">구글 바로가기</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/image/2.jpg" NavigateUrl="http://www.expedia.co.kr"></asp:HyperLink>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">바로가기</asp:LinkButton>
        </div>
    </form>
</body>
</html>
