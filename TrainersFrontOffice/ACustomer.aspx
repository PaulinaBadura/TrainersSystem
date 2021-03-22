<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 596px; top: 791px; position: absolute; width: 115px;" Text="OK" OnClick="btnOK_Click1" />
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
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 248px; top: 724px; position: absolute; right: 247px;"></asp:Label>
    	<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 430px; top: 791px; position: absolute; width: 115px;" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 680px; top: 200px; position: absolute" Text="Find" />
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 250px; top: 200px; position: absolute" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 458px; top: 200px; position: absolute; right: 680px;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 249px; top: 110px; position: absolute" Text="Create a new account"></asp:Label>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 962px; top: 113px; position: absolute" Text="Go back to main page" />
            <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 962px; top: 159px; position: absolute; width: 293px" Text="Go to existing customer page" />
        </p>
    </form>
</body>
</html>
