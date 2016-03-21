<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="ClickCounter.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID ="WelcomeLabel" runat="server" Font-Italic="true" Font-Size="X-Large">
            Welcome, <%: Session["clickerName"] %>!
        </asp:Label>
        <br />
        <asp:Button ID="ButtonClicker" runat="server" OnClick="ButtonClicker_Click" Text="Click me" Font-Bold ="true" Font-Italic="true"/>
        <br />
        <asp:Label ID="CountingLabel" runat="server">
            Number of clicks is <%: Application[(string)Session["clickerName"]] %>
        </asp:Label>
    </div>
    </form>
</body>
</html>
