<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserMsg.ascx.cs" Inherits="UserDefinition.UserMsg" %>
<asp:Panel ID="pnlMessage" Visible="false" runat="server">
    <div id="msgIcon" class="message-icon" runat="server">

    </div>
    <div class="message-text">
        <asp:Literal ID="litMsg" runat="server" />
    </div>
    <asp:Button ID="tbnOk" class="message-button" Text="확인" onclick="btnOk_click" runat="server" />
</asp:Panel>
