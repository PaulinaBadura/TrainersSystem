<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerEdit.aspx.cs" Inherits="CustomerEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
		<asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 250px; top: 450px; position: absolute" Text="DateOfBirth"></asp:Label>
    	<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 250px; top: 250px; position: absolute; right: 799px;" Text="First Name"></asp:Label>
		<asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 250px; top: 300px; position: absolute" Text="Last Name"></asp:Label>
		<asp:Label ID="lblEmail" runat="server" style="z-index: 1; left:250px; top: 350px; position: absolute" Text="Email"></asp:Label>
		<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 250px; top: 400px; position: absolute" Text="Password"></asp:Label>
		<asp:Label ID="lblHousNo" runat="server" style="z-index: 1; left: 250px; top: 500px; position: absolute" Text="House No"></asp:Label>
		<asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 250px; top: 550px; position: absolute" Text="Street"></asp:Label>
		<asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 250px; top: 600px; position: absolute" Text="Town"></asp:Label>
		</p>
        <p>
		<asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 250px; top: 650px; position: absolute" Text="PostCode"></asp:Label>
		</p>
        <p>
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 248px; top: 724px; position: absolute; right: 247px;"></asp:Label>
    	</p>
        <p>
		<asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 458px; top: 250px; position: absolute"></asp:TextBox>
    	<asp:TextBox ID="txtLAstName" runat="server" style="z-index: 1; left: 458px; top: 300px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 458px; top: 350px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 458px; top: 400px; position: absolute; height: 26px"></asp:TextBox>
		<asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 458px; top: 450px; position: absolute; height: 29px;"></asp:TextBox>
		<asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 458px; top: 500px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 458px; top: 550px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 458px; top: 600px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 458px; top: 650px; position: absolute"></asp:TextBox>
		</p>
        <p>
        	<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 596px; top: 791px; position: absolute; width: 115px;" Text="OK" OnClick="btnOK_Click1" />
    	<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 430px; top: 791px; position: absolute; width: 115px;" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnGoback" runat="server" OnClick="btnGoback_Click" style="z-index: 1; left: 914px; top: 358px; position: absolute" Text="Go to the main page" />
            <asp:Button ID="btnGoToAccount" runat="server" OnClick="btnGoToAccount_Click" style="z-index: 1; left: 910px; top: 293px; position: absolute" Text="Go to your account page" />
        </p>
    </form>
</body>
</html>
