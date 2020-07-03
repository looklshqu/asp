<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userDef.aspx.cs" Inherits="server_controll_1.userDef" %>
<%@ Register TagPrefix="U1" TagName="TopTheme" Src="~/userTopTheme.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <U1:TopTheme ID="TopTheme" runat="server" />
        <div>

            여러분의 성원으로 호텔 앱을 개발했습니다.

        </div>
    </form>
</body>
</html>
