<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddOrder.aspx.cs" Inherits="AddOrder" %>

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
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 467px; top: 41px; position: absolute; height: 22px" Text="ADD NEW ORDER"></asp:Label>
        <asp:Button ID="OKbtn"  runat="server" style="z-index: 1; left: 638px; top: 409px; position: absolute" Text="OK" Font-Italic="False" Font-Names="Yu Gothic" OnClick="OKbtn_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 752px; top: 409px; position: absolute" Text="Cancel" Font-Italic="False" Font-Names="Yu Gothic" OnClick="btnCancel_Click" />
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 480px; top: 108px; position: absolute" Text="Customer ID: " Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 629px; top: 108px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlCustomerID" runat="server" style="z-index: 1; left: 750px; top: 188px; position: absolute; height: 21px; width: 165px">
        </asp:DropDownList>
        <asp:Panel ID="Panel6" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 49px; top: 217px; position: absolute; height: 176px; width: 373px">
        </asp:Panel>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 76px; top: 243px; position: absolute" Text="Is your delivery address different ?" Font-Names="Yu Gothic"></asp:Label>
        <asp:Button ID="BtnChange" runat="server" style="z-index: 1; left: 70px; top: 301px; position: absolute; height: 34px; width: 335px;" Text="Change you address HERE" Font-Names="Yu Gothic" OnClick="BtnChange_Click" />
        <asp:Label ID="lblDifferent" runat="server" style="z-index: 1; left: 44px; top: 140px; position: absolute; height: 22px; width: 365px;" Text="DIFFERENT THAN REGISTERED?" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 314px; top: 501px; position: absolute" Text="PLEASE write placed into Order Status section when completing an order. Also, put 1 into Value, it will be changed afterwards. " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 861px; width: 308px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 263px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: 334px; top: 595px; position: absolute; height: 263px; width: 828px">
        </asp:Panel>
        
       
        
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 1106px; top: 282px; position: absolute" Text="CONTINUE WITH YOUR ORDER" Font-Names="Yu Gothic" OnClick="btnContinue_Click" />
        
       
        
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1106px; top: 345px; position: absolute" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic" OnClick="btnBack_Click" />
        
       
        
    </form>
</body>
</html>
