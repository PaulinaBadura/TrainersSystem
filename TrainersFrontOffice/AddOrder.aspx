﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddOrder.aspx.cs" Inherits="AddOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel4" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 467px; top: 81px; position: absolute; height: 409px; width: 449px">
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 578px; top: 159px; position: absolute; height: 302px; width: 507px">
        </asp:Panel>
        <asp:Label ID="CustomerIDlbl" runat="server"  style="z-index: 1; left: 610px; top: 190px; position: absolute" Text="Email Adress:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtDeliveryTown" runat="server" style="z-index: 1; left: 750px; top: 230px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 750px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderValue" runat="server" style="z-index: 1; left: 750px; top: 310px; position: absolute"></asp:TextBox>
        <asp:Label ID="DeliveryTownlbl" runat="server" style="z-index: 1; left: 610px; top: 230px; position: absolute" Text="Delivery Town:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="OrderDatelbl" runat="server" style="z-index: 1; left: 610px; top: 270px; position: absolute" Text="Order Date:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="OrderValuelbl" runat="server" style="z-index: 1; left: 610px; top: 310px; position: absolute" Text="Order Value:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="OrderStatuslbl" runat="server" style="z-index: 1; left: 610px; top: 350px; position: absolute" Text="Order Status:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 750px; top: 350px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 468px; top: 505px; position: absolute"></asp:Label>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 467px; top: 41px; position: absolute; height: 22px" Text="ADD NEW ORDER"></asp:Label>
        <asp:Button ID="OKbtn"  runat="server" style="z-index: 1; left: 638px; top: 409px; position: absolute" Text="OK" Font-Italic="False" Font-Names="Yu Gothic" OnClick="OKbtn_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 752px; top: 409px; position: absolute" Text="Cancel" Font-Italic="False" Font-Names="Yu Gothic" />
        <asp:Button ID="btnFind" runat="server"  style="z-index: 1; left: 830px; top: 105px; position: absolute" Text="Find" Font-Italic="False" Font-Names="Yu Gothic" OnClick="btnFind_Click"/>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 480px; top: 108px; position: absolute" Text="Order Number:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 629px; top: 108px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlCustomerID" runat="server" style="z-index: 1; left: 750px; top: 188px; position: absolute; height: 21px; width: 165px">
        </asp:DropDownList>
    </form>
</body>
</html>