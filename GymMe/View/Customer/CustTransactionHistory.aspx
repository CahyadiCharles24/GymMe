<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="CustTransactionHistory.aspx.cs" Inherits="GymMe.View.Customer.CustTransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_History" runat="server" OnSelectedIndexChanged="GV_History_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="Btn_View" runat="server" Text="View" UseSubmitBehavior="false" CommandName="Select"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>