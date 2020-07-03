<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsweMsg.aspx.cs" Inherits="UserDefinition.UsweMsg" %>
<%@ Register TagPrefix="UC1" Src="~/UserMsg.ascx" TagName="Mess" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Message.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <UC1:Mess ID="MessageBox" runat="server" />
        <div>

            <asp:Label ID="Label1" runat="server" Text="주문수량을 입력하세요"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="결과보기" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
