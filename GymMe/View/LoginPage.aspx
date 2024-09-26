<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="GymMe.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>
                <asp:Label ID="Lbl_Username" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="TB_Username" runat="server"></asp:TextBox>
            </div>
            
            <div>
                <asp:Label ID="Lbl_pass" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TB_pass" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:CheckBox ID="CB_RememberMe" runat="server" Text="Remember Me"/>
            </div>

            <div>
                <asp:Label ID="Lbl_errorMsg" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button ID="Btn_login" runat="server" Text="Login" OnClick="Btn_login_Click"/>
            </div>
            <div>
                <p>Doesn't Have an Account? 
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Register</asp:LinkButton></p>
            </div>

        </div>
    </form>
</body>
</html>
