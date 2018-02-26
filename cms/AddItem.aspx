<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="cms.AddItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Label5,#Label6,#Label7,#Label4,#Button1{

        
        font-family:Arial;
        font-size:25px;
        color:white;
      


      }
        #Label7
        {
            font-size:35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            </p>
        <asp:Panel ID="Panel1" runat="server" Height="319px" BackColor="Maroon">
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Add Item"></asp:Label>
            </div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 57px; margin-top: 0px;" Width="170px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="21px" style="margin-left: 68px; margin-top: 0px" Width="172px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Quantity:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="19px" style="margin-left: 38px; margin-top: 0px" Width="173px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#666666" ForeColor="White" Height="39px" style="margin-left: 245px" Text="Add" Width="113px" OnClick="Button1_Click" />
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
