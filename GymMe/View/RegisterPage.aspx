<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="GymMe.View.RegisterPage" %>

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
                <asp:Label ID="Lbl_Email" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="TB_Email" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_Gender" runat="server" Text="Gender"></asp:Label>
                <asp:RadioButtonList ID="genderradiobuttonlist" runat="server">
                    <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div>
                <asp:Label ID="Lbl_Pass" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TB_Pass" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_Cpass" runat="server" Text="Confirm Password"></asp:Label>
                <asp:TextBox ID="TB_Cpass" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_DOB" runat="server" Text="Date of Birth"></asp:Label>
                <asp:Calendar ID="calender" runat="server"></asp:Calendar>
            </div>

            <div>
                <asp:Label ID="Lbl_errorMsg" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button ID="Btn_Regis" runat="server" Text="Register" OnClick="Btn_Regis_Click" />
            </div>

            <div>
                <p>
                    Already Have an Account? 
                     <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >Login</asp:LinkButton>
                </p>
            </div>

        </div>
    </form>
</body>
</html>
