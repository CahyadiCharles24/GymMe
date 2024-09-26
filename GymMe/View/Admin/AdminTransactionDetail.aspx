<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTransactionDetail.aspx.cs" Inherits="GymMe.View.Admin.AdminTransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GV_TransactionDetail" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="Btn_Back" runat="server" Text="Back" OnClick="Btn_Back_Click" />
        </div>
    </form>
</body>
</html>
