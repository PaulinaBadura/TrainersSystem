<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 119px; top: 131px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 205px; top: 132px; position: absolute; width: 49px" Text="No" />
        </div>
        <p>
            <asp:Label ID="lblareyou" runat="server" style="z-index: 1; left: 116px; top: 86px; position: absolute" Text="Are you sure you want to delete your account?"></asp:Label>
        </p>
        <asp:Button ID="btnMainPage" runat="server" OnClick="btnMainPage_Click" style="z-index: 1; left: 285px; top: 133px; position: absolute; bottom: 368px; width: 322px; height: 37px" Text="Go back to the main page" />
    </form>
</body>
</html>
