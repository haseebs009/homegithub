<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="WebApplication4.Item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="login.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.6.0.slim.min.js"></script>
    <link href="jquery.min.js" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/css/jquery.dataTables.css" />
    <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js"></script>
    <script type="text/javascript" charset="utf8" src="http://ajax.aspnetcdn.com/ajax/jquery.dataTables/1.9.4/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%=gvitemslist.ClientID%>').DataTable();

        }
            
            )

    </script>
    <script>
        $(document).ready(function () {
            $.ajax({
                url: 'CustomerList.aspx/GetTables',
                method: 'POST',
                datatype: 'json',
                contentType: 'application/json',
                async: false,
                success: function (data) {

                    $('#gvitemslist').dataTable({

                        data: JSON.parse(data.d),

                        columns: [

                            { 'data': 'FirstName' },
                            { 'data': 'LastName' },
                            { 'data': 'Contact' },
                            { 'data': 'Email' }

                        ]
                    });
                }
            });
        });
    </script>
    </head>
<body>

    <form id="form1" runat="server">
         <h2 class="form-signin-heading">
        Item List</h2> 

        <div>

            <asp:GridView ID="gvitemslist" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="ID"
                ShowHeaderWhenEmpty="true"

                OnRowCommand="gvitemslist_RowCommand" OnRowEditing="gvitemslist_RowEditing" OnRowCancelingEdit="gvitemslist_RowCancelingEdit"
                OnRowUpdating="gvitemslist_RowUpdating" OnRowDeleting="gvitemslist_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <%-- Theme Properties --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                
                <Columns>
                    <asp:TemplateField HeaderText="Item Number">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("ItemNumber") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtItemNumber" Text='<%# Eval("ItemNumber") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtItemNumberFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Item Name">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("ItemName") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtItemName" Text='<%# Eval("ItemName") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtItemNameFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Vendor">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Vendor") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtVendor" Text='<%# Eval("Vendor") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtVendorFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                        <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtVendor" Text='<%# Eval("Price") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtPriceFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/Images/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" Width="107px" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" Width="107px" />
    </form>
</body>
</html>
