<%@ Page Title="" Language="C#" MasterPageFile="~/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminProfilePage.aspx.cs" Inherits="GymMe.View.Admin.AdminProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Profile</h1>
    </div>
    <div>
        <div>
            <asp:Label ID="Label_Username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TB_Username" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Email" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TB_Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_UserDOB" runat="server" Text="UserDOB : "></asp:Label>
            <asp:Label ID="Label_UserDOBnOW" runat="server" Text=""></asp:Label>
            <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="Label_Gender" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="GenderBTN" runat="server">
                <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>



    <asp:Panel ID="PasswordSection" runat="server" Visible="false">
        <div>
            <div>
                <asp:Label ID="LBL_OldPass" runat="server" Text="OldPass"></asp:Label>
                <asp:TextBox ID="TB_OldPass" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_NewPass" runat="server" Text="Newpass"></asp:Label>
                <asp:TextBox ID="TB_NewPass" runat="server"></asp:TextBox>
            </div>

        </div>
    </asp:Panel>

    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_ErorMsg" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
        <asp:Button ID="Btn_ChangePass" runat="server" Text="ChangePassword" OnClick="Btn_ChangePass_Click" />
    </div>
</asp:Content>
