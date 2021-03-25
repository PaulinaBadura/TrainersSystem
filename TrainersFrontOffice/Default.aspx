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
        <asp:Button ID="btnAddOrder" runat="server" style="z-index: 1; left: 95px; top: 192px; position: absolute" Text="ADD NEW ORDER" Font-Names="Yu Gothic" OnClick="btnAddOrder_Click" />
        <asp:Button ID="btnAddTrainer" runat="server" style="z-index: 1; left: 363px; top: 192px; position: absolute" Text="ADD TRAINERS INTO ORDER" Font-Names="Yu Gothic" OnClick="btnAddTrainer_Click"/>
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 236px; top: 273px; position: absolute" Text="VIEW ORDER DETAILS" Font-Names="Yu Gothic" OnClick="btnView_Click" />
    </form>
</body>
</html>
