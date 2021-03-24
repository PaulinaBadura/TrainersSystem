<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 288px; top: 304px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 374px; top: 303px; position: absolute; width: 49px" Text="No" />
        </div>
        <p>
            <asp:Label ID="lblareyou" runat="server" style="z-index: 1; left: 275px; top: 224px; position: absolute" Text="Are you sure you want to delete your account?"></asp:Label>
        </p>
        <asp:Button ID="btnMainPage" runat="server" OnClick="btnMainPage_Click" style="z-index: 1; left: 455px; top: 299px; position: absolute; bottom: 334px; width: 322px; height: 37px" Text="Go back to the main page" />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 273px; top: 181px; position: absolute"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FBEAD7" style="z-index: 1; left: 10px; top: 3px; position: absolute; height: 150px; width: 1245px">
            <asp:Panel ID="Panel7" runat="server" style="z-index: 1; left: 218px; top: -84px; position: absolute; height: 227px; width: 824px" BackImageUrl="~/logo.PNG">
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel6" runat="server" BackColor="#BDDEFF" style="z-index: 1; left: 7px; top: 141px; position: absolute; height: 607px; width: 213px">
        </asp:Panel>
    </form>
</body>
</html>
