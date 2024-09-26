﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSupplementUpdate.aspx.cs" Inherits="GymMe.View.Admin.AdminSupplementUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Supplement</h1>

            <div>
                <asp:Label ID="Lbl_SuppName" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TB_SuppName" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_SuppExpiryDate" runat="server" Text="Expiry Date"></asp:Label>
                <asp:TextBox ID="TB_ExpiryDate" runat="server" ReadOnly="true"></asp:TextBox>
                <asp:Calendar ID="Cldr_Expiry" runat="server"></asp:Calendar>
            </div>

            <div>
                <asp:Label ID="Lbl_SuppPrice" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TB_SuppPrice" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_SuppTypeID" runat="server" Text="Type ID"></asp:Label>
                <asp:TextBox ID="TB_SuppTypeID" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Lbl_status" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button ID="Btn_Back" runat="server" Text="Back" OnClick="Btn_Back_Click" />
                <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click"/>
            </div>

        </div>
    </form>
</body>
</html>
