<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddOrderLine.aspx.cs" Inherits="AddOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 861px; width: 308px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 263px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: 334px; top: 595px; position: absolute; height: 263px; width: 828px">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 467px; top: 81px; position: absolute; height: 409px; width: 449px">
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 578px; top: 159px; position: absolute; height: 302px; width: 507px">
        </asp:Panel>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 750px; top: 230px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 750px; top: 270px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 610px; top: 230px; position: absolute" Text="Order Number: " Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="Quantitylbl" runat="server" style="z-index: 1; left: 610px; top: 270px; position: absolute" Text="Quantity: " Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="Pricelbl" runat="server" style="z-index: 1; left: 610px; top: 310px; position: absolute" Text="Price: " Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 467px; top: 41px; position: absolute; height: 22px; width: 577px;" Text="ADD TRAINERS INTO YOUR ORDER"></asp:Label>
        <asp:Button ID="OKbtn"  runat="server" style="z-index: 1; left: 638px; top: 409px; position: absolute; height: 34px;" Text="OK" Font-Italic="False" Font-Names="Yu Gothic" OnClick="OKbtn_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 752px; top: 409px; position: absolute" Text="Cancel" Font-Italic="False" Font-Names="Yu Gothic" OnClick="btnCancel_Click" />
        <asp:DropDownList ID="ddlTrainerID" runat="server" style="z-index: 1; left: 751px; top: 312px; position: absolute; height: 21px; width: 165px">
        </asp:DropDownList>
        <asp:Label ID="lblTrainer" runat="server"  style="z-index: 1; left: 610px; top: 350px; position: absolute" Text="Trainer ID: " Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 198px; top: 498px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtTrainerID" runat="server" style="z-index: 1; left: 750px; top: 350px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1106px; top: 345px; position: absolute" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic" OnClick="btnBack_Click" />
    </form>
</body>
</html>
