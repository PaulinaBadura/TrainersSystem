<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAddOrder" runat="server" style="z-index: 1; left: 16px; top: 186px; position: absolute" Text="ADD NEW ORDER" Font-Names="Yu Gothic" OnClick="btnAddOrder_Click" />
        <asp:Button ID="btnAddTrainer" runat="server" style="z-index: 1; left: 16px; top: 304px; position: absolute; width: 304px;" Text="ADD TRAINERS INTO ORDER" Font-Names="Yu Gothic" OnClick="btnAddTrainer_Click"/>
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 11px; top: 250px; position: absolute; width: 259px;" Text="VIEW ORDER DETAILS" Font-Names="Yu Gothic" OnClick="btnView_Click" />
        <p>
        <asp:Button ID="btnNewCustomer" runat="server" OnClick="btnNewCustomer_Click" style="z-index: 1; left: 632px; top: 234px; position: absolute; right: 368px; width:265px;" Text="Create new acoount" Font-Names="Yu Gothic" />
        </p>
        <p>
        <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 634px; top: 290px; position: absolute; width: 265px;" Text="Manage existing account" Font-Names="Yu Gothic" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 675px; top: 177px; position: absolute" Text="Customer Account"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FBEAD7" style="z-index: 1; left: 13px; top: 19px; position: absolute; height: 140px; width: 1245px">
        </asp:Panel>
    </form>
</body>
</html>
