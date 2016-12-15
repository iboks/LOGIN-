<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGPAGE.aspx.cs" Inherits="LOGINSYSTEM.LOGPAGE" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            color: #000066;
        }
        #Password1 {
            width: 297px;
        }
    </style>
</head>
<body style="background-color: #CCCCCC">
    <form id="form1" runat="server">
        <div style="background-color: #000066">
            <br />
            <h1 style="color: #CCCCCC; background-color: #000066"> ELECTRONIC COURSEWORK SYSTEM</h1>
            <br />
        </div>
    <div class="auto-style1" style="height: 676px; background-color: #CCCCCC; font-size: large;">
        <div style="font-size: x-large; font-weight: 700">
            <br />
            <span class="auto-style2">L<strong style="color: #000066">OGIN<br />
            <asp:Label ID="Label1" runat="server" style="font-size: medium; color: #800000" Visible="false" Text="PLEASE ENTER THE CORRECT USERNAME AND PASSWORD"></asp:Label>
        </strong></span>
       
            </div>
    
        <br />
        <span class="auto-style2"><strong>USERNAME&nbsp; </strong></span>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsername" runat="server" Width="296px"></asp:TextBox>
        <br />
        <br style="background-color: #CCCCCC" />
        <span class="auto-style2"><strong>PASSWORD </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="298px"></asp:TextBox>
&nbsp;<br />
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" style="color: #000066; font-weight: 700" Text="LOGIN" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
