<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: -21px; top: 9px; position: absolute; height: 657px; width: 1276px">
            </asp:Panel>
        </div>
        <asp:Button ID="btnAddOrder" runat="server" style="z-index: 1; left: 57px; top: 258px; position: absolute; bottom: 390px; width: 259px; height: 35px;" Text="ADD NEW ORDER" Font-Names="Yu Gothic" OnClick="btnAddOrder_Click" />
        <asp:Button ID="btnAddTrainer" runat="server" style="z-index: 1; left: 57px; top: 366px; position: absolute; width: 304px;" Text="ADD TRAINERS INTO ORDER" Font-Names="Yu Gothic" OnClick="btnAddTrainer_Click"/>
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 57px; top: 317px; position: absolute; width: 259px; height: 35px;" Text="VIEW ORDER DETAILS" Font-Names="Yu Gothic" OnClick="btnView_Click" />
        <p>
        <asp:Button ID="btnNewCustomer" runat="server" OnClick="btnNewCustomer_Click" style="z-index: 1; left: 560px; top: 268px; position: absolute; right: 439px; width:265px;" Text="Create new acoount" Font-Names="Yu Gothic" />
        </p>
        <p>
        <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 560px; top: 319px; position: absolute; width: 265px;" Text="Manage existing account" Font-Names="Yu Gothic" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 600px; top: 226px; position: absolute" Text="Customer Account"></asp:Label>
    </form>
</body>
</html>
