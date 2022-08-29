<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajax1.aspx.cs" Inherits="ajax1.ajax1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">

        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
    DropDownList1.DataSource = StudentList;
</body>
</html>
