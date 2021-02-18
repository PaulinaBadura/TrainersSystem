<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="CustomerIDlbl" runat="server" style="z-index: 1; left: 14px; top: 58px; position: absolute; height: 18px; width: 107px; right: 881px;" Text="Customer ID:"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 134px; top: 56px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="DeliveryTownlbl" runat="server" style="z-index: 1; left: 30px; top: 85px; position: absolute" Text="Delivery Town:"></asp:Label>
        <asp:TextBox ID="txtDeliveryTown" runat="server" style="z-index: 1; left: 135px; top: 84px; position: absolute"></asp:TextBox>
        <asp:Label ID="OrderDatelbl" runat="server" style="z-index: 1; left: 42px; top: 115px; position: absolute" Text="Order Date:"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 135px; top: 111px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="OrderStatuslbl" runat="server" style="z-index: 1; left: 34px; top: 144px; position: absolute" Text="Order Status:"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 135px; top: 142px; position: absolute"></asp:TextBox>
        <asp:Label ID="OrderNolbl" runat="server" style="z-index: 1; left: 45px; top: 300px; position: absolute; margin-bottom: 0px" Text="Order Number:"></asp:Label>
        <asp:TextBox ID="txtOrderValue" runat="server" style="z-index: 1; left: 136px; top: 172px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 50px; top: 213px; position: absolute"></asp:Label>
        <asp:Button ID="OKbtn" runat="server" OnClick="OKbtn_Click" style="z-index: 1; left: 57px; top: 251px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 131px; top: 252px; position: absolute" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 222px; top: 251px; position: absolute" Text="Find" />
        </p>
        <p>
        <asp:Label ID="OrderValuelbl0" runat="server" style="z-index: 1; left: 38px; top: 175px; position: absolute; margin-bottom: 0px" Text="Order Value:"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 155px; top: 298px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
