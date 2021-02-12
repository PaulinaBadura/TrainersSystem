<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 607px; top: 750px; position: absolute; width: 115px;" Text="OK" OnClick="btnOK_Click1" />
        </div>
    	<asp:TextBox ID="txtLAstName" runat="server" style="z-index: 1; left: 458px; top: 300px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 458px; top: 250px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 458px; top: 350px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 458px; top: 450px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 458px; top: 500px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 458px; top: 550px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 458px; top: 600px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 458px; top: 650px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 458px; top: 400px; position: absolute; height: 26px"></asp:TextBox>
    	<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 250px; top: 250px; position: absolute" Text="First Name"></asp:Label>
		<asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 250px; top: 300px; position: absolute" Text="Last Name"></asp:Label>
		<asp:Label ID="lblEmail" runat="server" style="z-index: 1; left:250px; top: 350px; position: absolute" Text="Email"></asp:Label>
		<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 250px; top: 400px; position: absolute" Text="Password"></asp:Label>
		<asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 250px; top: 450px; position: absolute" Text="DateOfBirth"></asp:Label>
		<asp:Label ID="lblHousNo" runat="server" style="z-index: 1; left: 250px; top: 500px; position: absolute" Text="House No"></asp:Label>
		<asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 250px; top: 550px; position: absolute" Text="Street"></asp:Label>
		<asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 250px; top: 600px; position: absolute" Text="Town"></asp:Label>
		<asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 250px; top: 650px; position: absolute" Text="PostCode"></asp:Label>
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 250px; top: 720px; position: absolute; right: 2107px;"></asp:Label>
    	<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 427px; top: 750px; position: absolute; width: 115px;" Text="Cancel" />
    </form>
</body>
</html>
