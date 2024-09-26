<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustHistoryDetail.aspx.cs" Inherits="GymMe.View.Customer.CustHistoryDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Transaction Detail
            </h1>
            <div>
                <asp:GridView ID="GV_detail" runat="server"></asp:GridView>
            </div>

            <div>
                <asp:Button ID="Btn_Back" runat="server" Text="Back" OnClick="Btn_Back_Click"/>
            </div>

        </div>
    </form>
</body>
</html>
