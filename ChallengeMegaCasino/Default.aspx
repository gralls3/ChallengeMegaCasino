<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeMegaCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Player 1&#39;s Name:
            <asp:TextBox ID="player1TextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Player 2&#39;s Nname:
            <asp:TextBox ID="player2TextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Play" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
