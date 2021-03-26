<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewOrder.aspx.cs" Inherits="ViewOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 298px; top: 171px; position: absolute; height: 325px; width: 334px">
        </asp:Panel>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 310px; top: 220px; position: absolute" Text="Email address: " Font-Names="Yu Gothic" ></asp:Label>
        <asp:Label ID="lblEmail1" runat="server" style="z-index: 1; left: 470px; top: 220px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 310px; top: 260px; position: absolute" Text="Delivery Town: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblTown1" runat="server" style="z-index: 1; left: 470px; top: 260px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 310px; top: 300px; position: absolute" Text="Date Added: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblDate1" runat="server" style="z-index: 1; left: 470px; top: 300px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 310px; top: 340px; position: absolute" Text="Order Status: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblStatus1" runat="server" style="z-index: 1; left: 470px; top: 340px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblOrderValue" runat="server" style="z-index: 1; left: 310px; top: 380px; position: absolute" Text="Order Value: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblOrderValue1" runat="server" style="z-index: 1; left: 470px; top: 380px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 310px; top: 420px; position: absolute" Text="Customer ID: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblCustomerID1" runat="server" style="z-index: 1; left: 470px; top: 420px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 159px; top: 130px; position: absolute" Text="Please enter your Order Number: " Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 482px; top: 131px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 674px; top: 127px; position: absolute" Text="Find" Font-Names="Yu Gothic" OnClick="btnFind_Click" />
         <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 950px; width: 308px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 684px; position: absolute; height: 263px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: 298px; top: 682px; position: absolute; height: 263px; width: 828px">
        </asp:Panel>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1106px; top: 345px; position: absolute" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic" OnClick="btnBack_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 159px; top: 76px; position: absolute" Text="CHECK YOUR ORDER DETAILS HERE" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 86px; top: 523px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
    </form>
</body>
</html>
