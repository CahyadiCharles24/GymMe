<%@ Page Title="" Language="C#" MasterPageFile="~/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminOrderQueue.aspx.cs" Inherits="GymMe.View.Admin.AdminOrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_Order" runat="server" AutoGenerateColumns="false"
        OnRowDataBound="GV_Order_RowDataBound"
        OnRowCommand="GV_Order_RowCommand">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="ID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="Btn_Handle" runat="server" Text="Handle" UseSubmitBehavior="false" CommandName="Handle" CommandArgument='<%# Eval("TransactionID") %>'/>
                    <asp:Button ID="Btn_View" runat="server" Text="View" UseSubmitBehavior="false" CommandName="View" CommandArgument='<%# Eval("TransactionID") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
