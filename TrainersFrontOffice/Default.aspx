<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/logo.PNG" style="z-index: 1; left: -21px; top: 9px; position: absolute; height: 657px; width: 1276px">
                <asp:ListBox ID="lstTrainers" runat="server" style="z-index: 1; left: 940px; top: 225px; position: absolute; height: 244px; width: 290px;" ></asp:ListBox>
                <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 1075px; top: 522px; position: absolute; width: 91px;"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 937px; top: 524px; position: absolute" Text="Enter Brand Name" Font-Names="Book Antiqua" ForeColor="#00005B"></asp:Label>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 951px; top: 587px; position: absolute"></asp:Label>
                <asp:Button ID="btnFilter" runat="server" style="z-index: 1; left: 1186px; top: 519px; position: absolute" Text="Filter" ForeColor="#00006A" />
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1179px; top: 561px; position: absolute" Text="Cancel" ForeColor="#00006A" />
                <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 1076px; top: 486px; position: absolute" Text="Display All" ForeColor="#00006A" />
                <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Names="Bookman Old Style" Font-Overline="False" Font-Size="Large" ForeColor="#00006A" style="z-index: 1; left: 943px; top: 187px; position: absolute" Text="List of Trainers"></asp:Label>
            </asp:Panel>
        </div>
        <asp:Button ID="btnAddOrder" runat="server" style="z-index: 1; left: 57px; top: 258px; position: absolute; bottom: 390px; width: 259px; height: 35px;" Text="ADD NEW ORDER" Font-Names="Yu Gothic" OnClick="btnAddOrder_Click" />
        <asp:Button ID="btnAddTrainer" runat="server" style="z-index: 1; left: 57px; top: 366px; position: absolute; width: 304px;" Text="ADD TRAINERS INTO ORDER" Font-Names="Yu Gothic" OnClick="btnAddTrainer_Click"/>
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 57px; top: 317px; position: absolute; width: 259px; height: 35px;" Text="VIEW ORDER DETAILS" Font-Names="Yu Gothic" OnClick="btnView_Click" />
        <p>
        <asp:Button ID="btnNewCustomer" runat="server" OnClick="btnNewCustomer_Click" style="z-index: 1; left: 560px; top: 268px; position: absolute; right: 439px; width:265px;" Text="Create new acoount" Font-Names="Yu Gothic" />
        </p>
        <p>
        <asp:Button ID="btnExistingCustomer" runat="server" OnClick="btnExistingCustomer_Click" style="z-index: 1; left: 560px; top: 319px; position: absolute; width: 265px; right: 142px;" Text="Manage existing account" Font-Names="Yu Gothic" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 600px; top: 226px; position: absolute" Text="Customer Account"></asp:Label>
    </form>
</body>
</html>
