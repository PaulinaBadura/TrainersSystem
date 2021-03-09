<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStaffPage.aspx.cs" Inherits="CustomerStaffPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel3" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 733px; top: 299px; position: absolute; height: 411px; width: 470px">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 768px; top: 390px; position: absolute; height: 387px; width: 406px">
        </asp:Panel>
        <asp:ListBox ID="ListBoxCustomers" runat="server" style="z-index: 1; left: 841px; top: 483px; position: absolute; height: 231px; width: 253px"></asp:ListBox>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: 20px; top: 297px; position: absolute; height: 377px; width: 468px" Wrap="False">
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 111px; top: 305px; position: absolute" Text="Manage Customers"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FBEBD8" style="z-index: 1; left: -1071px; top: -31px; position: absolute; height: 258px; width: 2416px">
            <p style="width: 1139px">
                <asp:Image ID="Image1" runat="server" BorderColor="White" BorderStyle="Solid" ImageUrl="~/logo.PNG" style="z-index: 1; left: 251px; top: 21px; position: absolute; height: 192px; width: 786px; margin-top: 0px;" />
            </p>
        </asp:Panel>
    </form>
</body>
</html>
