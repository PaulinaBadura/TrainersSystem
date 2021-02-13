<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ATrainer.aspx.cs" Inherits="ATrainer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 368px; top: 164px; position: absolute" Text="Brand"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 368px; top: 207px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 367px; top: 250px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 367px; top: 291px; position: absolute; height: 19px" Text="Size"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 366px; top: 332px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 367px; top: 376px; position: absolute" Text="Date Added"></asp:Label>
        <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 368px; top: 419px; position: absolute" Text="In Stock"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 463px; top: 164px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 462px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 460px; top: 287px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 461px; top: 332px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 461px; top: 371px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 461px; top: 415px; position: absolute" />
        <asp:DropDownList ID="ddlColour" runat="server" style="z-index: 1; left: 462px; top: 249px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 459px; top: 470px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 458px; top: 515px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 529px; top: 515px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
