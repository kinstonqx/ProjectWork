<%@ Page Title="" Language="C#" MasterPageFile="~/Just4Views.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Button ID="btnLogin" runat="server" style="z-index: 1; " Text="Login" height="26px" width="55px" OnClick="btnLogin_Click"  />
     <asp:Button ID="btnSignup" runat="server" style="z-index: 1; " Text="Sign Up" height="26px" width="65px" OnClick="btnSignup_Click" />
    <div class="outer">
        <div class="inner">
    <img src="Images/black%20panther.jpg" />
</div>
        <table style="width:100%;">
            <tr>
                <td>Product 1</td>
                <td>£2.50</td>
                <td>
                    <a href="Details.aspx?ProductID=1">Details</a>
                </td>
            </tr>
            <tr>
                <td>Product 2</td>
                <td>£33.00</td>
                <td>
                    <a href="Details.aspx?ProductID=2">Details</a>
                </td>
            </tr>
            <tr>
                <td>Product 3</td>
                <td>£14.00</td>
                <td>
                    <a href="Details.aspx?ProductID=3">Details</a>
                </td>
            </tr>
        </table>
    
        
</asp:Content>
