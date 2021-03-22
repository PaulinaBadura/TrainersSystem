<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExisitngCustomer.aspx.cs" Inherits="ExisitngCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 31px; top: 217px; position: absolute" Text="Your CustomerID"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 225px; top: 219px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 524px; top: 528px; position: absolute" Text="Delete Account" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 526px; top: 460px; position: absolute; width: 198px" Text="Edit account" OnClick="btnEdit_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 441px; top: 215px; position: absolute" Text="Find" />
        <asp:Label ID="lblDetails" runat="server" style="z-index: 1; left: 125px; top: 333px; position: absolute" Text="Account Details"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 138px; top: 384px; position: absolute" Text="ID"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 136px; top: 457px; position: absolute; height: 30px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 138px; top: 501px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 138px; top: 422px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 287px; top: 376px; position: absolute" Text="Label"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 282px; top: 495px; position: absolute"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 285px; top: 419px; position: absolute" Text="Label"></asp:Label>
        <asp:Label ID="lblLatName" runat="server" style="z-index: 1; left: 285px; top: 456px; position: absolute" Text="lblLastName"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 170px; top: 272px; position: absolute" Text="Label"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BorderColor="#FBEBD8" BorderStyle="Double" BorderWidth="10px" style="z-index: 1; left: 103px; top: 319px; position: absolute; height: 239px; width: 325px">
        </asp:Panel>
    </form>
</body>
</html>
