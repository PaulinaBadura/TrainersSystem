<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExisitngCustomer.aspx.cs" Inherits="ExisitngCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 430px; top: 234px; position: absolute" Text="Your CustomerID"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 626px; top: 239px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 833px; top: 235px; position: absolute" Text="Find" Font-Names="Yu Gothic" />
        <asp:Label ID="lblDetails" runat="server" style="z-index: 1; left: 278px; top: 368px; position: absolute" Text="Account Details"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 287px; top: 415px; position: absolute" Text="ID"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 286px; top: 489px; position: absolute; height: 30px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 287px; top: 527px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 287px; top: 452px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 432px; top: 405px; position: absolute; bottom: 64px;" Text="____"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 432px; top: 527px; position: absolute">____</asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 433px; top: 448px; position: absolute" Text="____"></asp:Label>
        <asp:Label ID="lblLatName" runat="server" style="z-index: 1; left: 431px; top: 490px; position: absolute" Text="____"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 628px; top: 281px; position: absolute"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BorderColor="#FBEBD8" BorderStyle="Double" BorderWidth="10px" style="z-index: 1; left: 246px; top: 343px; position: absolute; height: 239px; width: 352px">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FCECDA" style="z-index: 1; left: 12px; top: 15px; position: absolute; height: 182px; width: 1245px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: 215px; top: -57px; position: absolute; height: 245px; width: 828px">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BorderColor="#D5BAE9" BorderStyle="Ridge" BorderWidth="8px" style="z-index: 1; left: 681px; top: 366px; position: absolute; height: 149px; width: 330px">
        </asp:Panel>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 228px; top: 207px; position: absolute" Text="Home" Font-Names="Yu Gothic" />
        <asp:Button ID="btnEdit1" runat="server" OnClick="btnEdit1_Click" style="z-index: 1; left: 756px; top: 395px; position: absolute; width: 183px" Text="Edit Account" Font-Names="Yu Gothic" />
        <asp:Button ID="btnDelete1" runat="server" OnClick="btnDelete1_Click" style="z-index: 1; left: 757px; top: 447px; position: absolute; width: 183px" Text="Delete Account" Font-Names="Yu Gothic" />
        <asp:Panel ID="Panel6" runat="server" BackColor="#BDDEFF" style="z-index: 1; left: 8px; top: 201px; position: absolute; height: 607px; width: 213px">
        </asp:Panel>
    </form>
</body>
</html>
