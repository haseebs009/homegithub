<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_TestProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link rel="stylesheet" href="asp.css">
    <title></title>
</head>
<body>
   <h1> Calculator</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;<br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="Add"       Value="%2B"></asp:ListItem>
            <asp:ListItem Text="Multiply"  Value="*"></asp:ListItem>
            <asp:ListItem Text="Subtract"  Value="-"></asp:ListItem>
            <asp:ListItem Text="Divide"    Value="/"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click1" onClientClick="return check()" Text="Calculate" />
&nbsp;&nbsp;
    </form>
     <script>
         function check() {
             try {
                // console.log("Hello");
                 if (isNaN(document.getElementById("TextBox1").value)) throw "Please enter number only" ;
                 if (isNaN(document.getElementById("TextBox2").value)) throw "Please enter number only" ;
                 if ((document.getElementById("TextBox1").value) == "") throw "Value can not be empty" ;
                 if ((document.getElementById("TextBox2").value) == "") throw "Value can not be empty" ;
             }
             catch (err) {
                 alert(err);
                 return false;
             }
         }
    </script>
</body>
</html>
