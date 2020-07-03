<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application_object.aspx.cs" Inherits="Object_and_Status.Application_object" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="상품명"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="주문량"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Application_object_result.aspx">계산결과보기</asp:HyperLink>
        </div>
    </form>
</body>
</html>
