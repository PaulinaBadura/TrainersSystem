﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerEdit.aspx.cs" Inherits="CustomerEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 18px;
            width: 1241px;
        }
    </style>
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
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 718px; top: 435px; position: absolute; right: -223px;"></asp:Label>
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
		    <asp:Label ID="Label2" runat="server" Font-Italic="True" style="z-index: 1; left: 257px; top: 203px; position: absolute" Text="Fill in the form with a corect data"></asp:Label>
		</p>
        <asp:Panel ID="Panel6" runat="server" BackColor="#BDDEFF" style="z-index: 1; left: 11px; top: 152px; position: absolute; height: 677px; width: 213px">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BackColor="#FBEAD7" style="z-index: 1; left: 13px; top: -12px; position: absolute; height: 162px; width: 1245px">
            <asp:Panel ID="Panel7" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 27px; width: 1245px; margin-bottom: 0px;">
            </asp:Panel>
            <asp:Panel ID="Panel8" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 27px; width: 1245px">
            </asp:Panel>
            <p>
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 603px; top: 706px; position: absolute; width: 115px;" Text="OK" Font-Names="Yu Gothic" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 452px; top: 706px; position: absolute; width: 115px;" Text="Cancel" Font-Names="Yu Gothic" />
                <asp:Button ID="btnGoback" runat="server" OnClick="btnGoback_Click" style="z-index: 1; left: 910px; top: 345px; position: absolute; width: 205px;" Text="Go to the main page" Font-Names="Yu Gothic" />
                <asp:Button ID="btnGoToAccount" runat="server" OnClick="btnGoToAccount_Click" style="z-index: 1; left: 910px; top: 293px; position: absolute; width:205px;" Text="Go to your account page" Font-Names="Yu Gothic" />
                <asp:Panel ID="Panel9" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: 212px; top: -71px; position: absolute; height: 229px; width: 823px">
                </asp:Panel>
                <p>
                </p>
            </p>
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 248px; top: 155px; position: absolute" Text="Update Your Account Details"></asp:Label>
        </p>
    </form>
</body>
</html>
