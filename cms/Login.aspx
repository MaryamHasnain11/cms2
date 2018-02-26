<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="cms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		.b {
			background-image:url("images/log1.jpg");
			background-attachment:fixed;
			
		}
		.f {
			background-color:burlywood;
			width:518px;
			position:relative;
			left:300px;
			top:100px;
			height: 273px;
		}
		.d {background-color:black;
			color:bisque
		}
	</style>
</head>
<body class="b">
	<br />
	<center><h1 class="d" >Login to your Account</h1></center>
	
    <form class="f" id="form1" runat="server" >
		<center>
       
			<p>
				&nbsp;</p>
			<p>
			Username:&nbsp;
			<asp:TextBox ID="TextBox1" runat="server" required ></asp:TextBox>
		</p>
			<p>
				&nbsp;</p>
		<p>
			Password:&nbsp;
			<asp:TextBox ID="TextBox2"   TextMode="Password" runat="server" required></asp:TextBox>
		</p>
			<p>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:ImageButton ImageUrl="images/login1.png" ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Height="47px" Width="138px" />
			</p>
			
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>

		</center></form>
	
</body>
</html>
