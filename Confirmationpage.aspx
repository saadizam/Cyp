<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmationpage.aspx.cs" Inherits="WEB.Confirmationpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?key=AIzaSyCLOv4XXeiLHi0SUzW0O3ZNCiq4jGiVHFI&sensor=false&libraries=places"></script>

    <link rel="stylesheet" href="AR/css/css.css">

    <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>

    <link rel="stylesheet" href="AR/css/style.css">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #a{
            background-color:#3d356f;
        }
        #HyperLink1{
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
    <div id="a">
    
       <%-- <asp:Button ID="Button1" runat="server" Text="Back to Mainpage" class="buthover" OnClick="Button1_Click" PostBackUrl="www.stationcarslondon.com/" />
   --%> 
         <asp:HyperLink ID="HyperLink1" NavigateUrl="http://www.stationcarslondon.com/" runat="server">Back to Mainpage</asp:HyperLink>

        <br />
    
        <br />
    
    </div>
    
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066FF" Text="For any query Contact Us(02087787878)" CssClass="auto-style4"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <br class="auto-style4" />
    
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#33CC33" Text="Your details successfully stored" CssClass="auto-style4"></asp:Label>
            <br />
            <br class="auto-style4" />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066FF" Text="Check your Email" CssClass="auto-style4"></asp:Label>
            <br class="auto-style4" />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066FF" Text="Thank you" CssClass="auto-style4"></asp:Label>
            </div>
    </form>
</body>
</html>
