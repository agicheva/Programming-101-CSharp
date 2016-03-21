<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClickCounter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="TextBoxForName" runat="server" Height="16px" Width="121px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="NameRequiredValidator" runat="server" ControlToValidate="TextBoxForName" ErrorMessage="You are supposed to write your name to continue." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit"/>
        </div> 
    </form>
</body>
</html>
