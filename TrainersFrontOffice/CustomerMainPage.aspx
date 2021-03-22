<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerMainPage.aspx.cs" Inherits="CustomerMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnNewCustomer" runat="server" OnClick="btnNewCustomer_Click" style="z-index: 1; left: 223px; top: 244px; position: absolute; right: 539px" Text="New Customer" />
        <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 497px; top: 244px; position: absolute" Text="Existing Customer" />
    </form>
</body>
</html>
