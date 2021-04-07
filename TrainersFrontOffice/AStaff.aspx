<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

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
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 250px; top: 200px; position: absolute" Text="Staff ID"></asp:Label>
            </p>
        <p>
    	<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 250px; top: 250px; position: absolute" Text="First Name"></asp:Label>
		</p>
        <p>
		<asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 250px; top: 300px; position: absolute" Text="Last Name"></asp:Label>
		</p>
        <p>
		<asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left:250px; top: 350px; position: absolute" Text="Date Of Birth"></asp:Label>
		<asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 250px; top: 400px; position: absolute" Text="Department"></asp:Label>
		<asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 250px; top: 450px; position: absolute" Text="Email"></asp:Label>
		<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 250px; top: 500px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 458px; top: 200px; position: absolute; right: 680px;"></asp:TextBox>
		<asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 458px; top: 250px; position: absolute"></asp:TextBox>
    	<asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 458px; top: 300px; position: absolute; bottom: 235px;"></asp:TextBox>
		<asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 458px; top: 350px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 458px; top: 400px; position: absolute; height: 19px"></asp:TextBox>
		<asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 458px; top: 450px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 458px; top: 500px; position: absolute"></asp:TextBox>
    	<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 243px; top: 598px; position: absolute; width: 115px;" Text="Cancel" />
        	<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 529px; top: 598px; position: absolute; width: 115px;" Text="OK" OnClick="btnOK_Click1" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 253px; top: 556px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 408px; top: 599px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>
