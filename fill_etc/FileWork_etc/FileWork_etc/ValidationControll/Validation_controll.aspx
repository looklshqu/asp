<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation_controll.aspx.cs" Inherits="FileWork_etc.ValidationControll.Validation_controll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
            <asp:Label ID="Label1" runat="server" Text="아이디"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="(아이디는 반드시 입력해야 합니다.)"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="(아이디는 영소문자, 숫자 13자 이하여야 합니다.)" ValidationExpression="[a-z0-9]{6,13}"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="비밀번호"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" TextMode="Password" runat="server" ></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="(공백 제외한 8-16자 이내여야 합니다.)" ValidationExpression="[^\s]{8,16}"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="비밀번호 확인"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" TextMode="Password" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="(비밀번호가 일치하지 않습니다.)"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="나이"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="(18-80세만 가능합니다.)" MaximumValue="80" MinimumValue="18"></asp:RangeValidator>
            <br />
        </div>
    </form>
</body>
</html>
