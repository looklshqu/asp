<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Response_object.aspx.cs" Inherits="Object_and_Status.Response_object" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="고객님의 한 마디"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="결과" />
        </div>
    </form>
</body>
</html>
