<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="cms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		.g {
			margin-left:auto;
			margin-right:auto;
		}
		.d {
			background-image:url("images/mm.png");
			background-repeat:repeat-x;
			color:aliceblue;
			width:1100px;
			height:200px;
		}
		.gg {
		position:absolute;
		left:100px;
		}

		.button {
  display: inline-block;
  border-radius: 4px;
  background-color: #f4511e;
  border: none;
  color: #FFFFFF;
  text-align: center;
  font-size: 28px;
  padding: 20px;
  width: 200px;
  transition: all 0.5s;
  cursor: pointer;
  margin: 5px;
}

.button span {
  cursor: pointer;
  display: inline-block;
  position: relative;
  transition: 0.5s;
}

.button span:after {
  content: '\00bb';
  position: absolute;
  opacity: 0;
  top: 0;
  right: -20px;
  transition: 0.5s;
}



.button:hover  {
  opacity: 1;
  right: 0;
}

	</style>

	<script type="text/javascript">
		function deli() {
			var a = prompt("Please enter your address" );
		if(a!=""){
			alert("Click on order now to confirm your order.")
		}
			else{
			alert("Invalid Address");
		}
		}
		function p(){
		var b=prompt("Enter a pickup time between 12:00 and 20:00 hours");
			if(b>20 || b<12) {
			alert("Sorry we are not open at these hours!");
			//var b=prompt("Enter a pickup time between 12:00 and 20:00 hours");
			}
			else{
			alert("Click on order now to confirm your order.")}
		}

		</script>
</head>
<body style="background-image:url(images/bgf.jpg);background-repeat:round">
	<center>
	<div class="d"></div>
		<br /><br />
    <form id="form1" runat="server">
        <div>


</div>
		<center>
<div>
<asp:GridView ID="grid1" DataKeyNames="ItemID"  AutoGenerateColumns="False" 
CellPadding="3" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
BorderWidth="1px" OnSelectedIndexChanged="grid1_SelectedIndexChanged" Height="232px" style="margin-right: 80px;"  Width="685px" CellSpacing="2">
<Columns>
	 <asp:templatefield HeaderText="Select Item">
                    <itemtemplate>
                        <asp:checkbox OnCheckedChanged="cbSelect_CheckedChanged" ID="cbSelect" autopostback="true"

                        CssClass="gridCB" runat="server"></asp:checkbox>
                    </itemtemplate>
                </asp:templatefield>


<asp:BoundField HeaderText="Item Name" DataField="ItemName"  />
<asp:BoundField HeaderText="Price" DataField="Price" />

	 <asp:templatefield HeaderText="Enter Quantity">
                    <itemtemplate>
                       
<asp:TextBox CssClass="gridCB" Width="50px" runat="server" ID="tb" Text="0" autopostback="true" required></asp:TextBox>
                       
                    </itemtemplate>
                </asp:templatefield>
</Columns>
    
	<FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
	<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
	<PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
	<RowStyle ForeColor="#8C4510" BackColor="#FFF7E7" />
	<SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
	<SortedAscendingCellStyle BackColor="#FFF1D4" />
	<SortedAscendingHeaderStyle BackColor="#B95C30" />
	<SortedDescendingCellStyle BackColor="#F1E5CE" />
	<SortedDescendingHeaderStyle BackColor="#93451F" />
    
</asp:GridView>
	<br />
<asp:Button ID="Button1" runat="server" Text="Generate Bill" OnClick="Button1_Click" class="button" style="vertical-align:middle" Height="70px" Width="202px"></asp:Button>
	<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

	<br />

	</div>
<div>

	<asp:ImageButton ImageUrl="images/del4.png" ID="ImageButton2" OnClientClick="javascript:return deli();" runat="server" Width="108px" Height="88px" />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:ImageButton ImageUrl="images/pick.png" ID="ImageButton3" OnClientClick="javascript:return p();" runat="server" Height="88px" style="margin-top: 39px" Width="108px" />

</div>
<asp:ImageButton ImageUrl="images/order.png" ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />

			</center>
    	
		
    </form>
		
	
</body>
</html>
