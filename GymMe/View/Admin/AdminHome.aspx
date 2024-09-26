<%@ Page Title="" Language="C#" MasterPageFile="~/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GymMe.View.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Page</h1>

    <asp:GridView ID="GV_Customer" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID"/>
            <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"/>
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail"/>
            <asp:BoundField DataField="UserDOB" HeaderText="DOB" SortExpression="UserDOB"/>
            <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender"/>
        </Columns>
    </asp:GridView>
</asp:Content>

