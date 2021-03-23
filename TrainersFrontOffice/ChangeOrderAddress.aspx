<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeOrderAddress.aspx.cs" Inherits="ChangeOrderAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 299px; top: 227px; position: absolute; height: 397px; width: 479px">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 406px; top: 270px; position: absolute; height: 312px; width: 502px">
        </asp:Panel>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 424px; top: 340px; position: absolute" Text="House Number: " Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 581px; top: 340px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblStreet" runat="server" style="z-index: 1; left: 464px; top: 380px; position: absolute" Text="Street: " Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 581px; top: 380px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 469px; top: 420px; position: absolute" Text="Town: " Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 581px; top: 420px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 454px; top: 460px; position: absolute" Text="Postcode: " Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 581px; top: 460px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlCustomer" runat="server" style="z-index: 1; left: 533px; top: 179px; position: absolute; width: 237px">
        </asp:DropDownList>
        <asp:Label ID="lblChoose" runat="server" style="z-index: 1; left: 188px; top: 178px; position: absolute" Text="Please choose your Email Address: " Font-Names="Yu Gothic"></asp:Label>
        <asp:Button ID="btnChange" runat="server" style="z-index: 1; left: 469px; top: 523px; position: absolute; right: 230px;" Text="USE THIS ADDRESS" Font-Names="Yu Gothic" OnClick="btnChange_Click"/>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 744px; top: 523px; position: absolute" Text="CANCEL" Font-Names="Yu Gothic" OnClick="btnCancel_Click"/>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 208px; top: 129px; position: absolute" Text="CHANGE THE DELIVERY ADDRESS" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 214px; top: 625px; position: absolute"></asp:Label>
    </form>
</body>
</html>
