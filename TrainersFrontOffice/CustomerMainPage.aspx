<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerMainPage.aspx.cs" Inherits="CustomerMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#FBEAD7" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 181px; width: 1245px">
            </asp:Panel>
        </div>
        <asp:Button ID="btnNewCustomer" runat="server" OnClick="btnNewCustomer_Click" style="z-index: 1; left: 684px; top: 328px; position: absolute; right: 316px" Text="Create new acoount" />
        <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 685px; top: 390px; position: absolute; width: 265px;" Text="Manage existing account" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 373px; top: 263px; position: absolute" Text="Order"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 40px; top: 261px; position: absolute" Text="Trainers "></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 736px; top: 262px; position: absolute; height: 25px" Text=" Account"></asp:Label>
        </p>
    </form>
</body>
</html>
