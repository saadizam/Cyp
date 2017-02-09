<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewDetail.aspx.cs" Inherits="WEB.ViewDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 293px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
                  .header
{
              width:50%;
    background-color: #646464;

    font-family: Arial;

    color: White;

    border: none 0px transparent;
    height: 25px;

    text-align: center;

    font-size: 16px;

}
                  h1{
                      text-align:center;
                  }
    </style>
</head>
<body>
       <h1>
        Job Details
    </h1>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" HeaderStyle-CssClass="header">
        </asp:GridView>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="#009900" CssClass="auto-style3" OnClick="Button3_Click" Text="Accept" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" BackColor="#FF3300" OnClick="Button4_Click" Text="Declined" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
