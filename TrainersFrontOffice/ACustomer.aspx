<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 590px; top: 709px; position: absolute; width: 115px;" Text="OK" OnClick="btnOK_Click1" />
        </div>
    	<asp:TextBox ID="txtLAstName" runat="server" style="z-index: 1; left: 458px; top: 300px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 458px; top: 250px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 458px; top: 350px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 458px; top: 450px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 458px; top: 500px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 458px; top: 550px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 458px; top: 600px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 461px; top: 652px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 458px; top: 400px; position: absolute; height: 26px"></asp:TextBox>
    	<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 250px; top: 250px; position: absolute" Text="First Name"></asp:Label>
		<asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 250px; top: 300px; position: absolute" Text="Last Name"></asp:Label>
		<asp:Label ID="lblEmail" runat="server" style="z-index: 1; left:250px; top: 350px; position: absolute" Text="Email"></asp:Label>
		<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 250px; top: 400px; position: absolute" Text="Password"></asp:Label>
		<asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 250px; top: 450px; position: absolute" Text="DateOfBirth"></asp:Label>
		<asp:Label ID="lblHousNo" runat="server" style="z-index: 1; left: 250px; top: 500px; position: absolute" Text="House No"></asp:Label>
		<asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 250px; top: 550px; position: absolute" Text="Street"></asp:Label>
		<asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 250px; top: 600px; position: absolute" Text="Town"></asp:Label>
		<asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 247px; top: 658px; position: absolute" Text="PostCode"></asp:Label>
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 709px; top: 342px; position: absolute; right: -214px;"></asp:Label>
    	<asp:Panel ID="Panel5" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 27px; width: 1245px">
        </asp:Panel>
    	<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 458px; top: 706px; position: absolute; width: 115px;" Text="Cancel" />
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 251px; top: 143px; position: absolute" Text="Create a new account" Font-Size="X-Large"></asp:Label>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 774px; top: 196px; position: absolute; width: 293px;" Text="Go back to the  main page" />
            <asp:Label ID="Label2" runat="server" Font-Italic="True" ForeColor="Black" style="z-index: 1; left: 247px; top: 200px; position: absolute" Text="Fill in the form to create new account "></asp:Label>
        </p>
        <asp:Panel ID="Panel4" runat="server" BackColor="#FBEAD7" style="z-index: 1; left: 13px; top: -12px; position: absolute; height: 154px; width: 1245px">
            <asp:Panel ID="Panel7" runat="server" style="z-index: 1; left: 227px; top: -84px; position: absolute; height: 235px; width: 820px" BackImageUrl="~/logo.PNG">
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel6" runat="server" BackColor="#BDDEFF" style="z-index: 1; left: 7px; top: 141px; position: absolute; height: 607px; width: 213px">
        </asp:Panel>
    </form>
</body>
</html>
