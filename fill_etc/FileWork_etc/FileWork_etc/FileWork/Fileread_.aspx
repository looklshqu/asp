<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fileread_.aspx.cs" Inherits="FileWork_etc.FileWork.Fileread_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="파일읽기" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Rows="6" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
