<%@ Page Title="" Language="C#" MasterPageFile="~/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminManageSupplement.aspx.cs" Inherits="GymMe.View.Admin.AdminManageSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br>
    <div>
        <asp:GridView ID="GV_Supplement" runat="server"
            OnRowEditing="GV_Supplement_RowEditing"
            OnRowDeleting="GV_Supplement_RowDeleting">
            <Columns>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="Btn_Update" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Edit"/>
                        <asp:Button ID="Btn_Delete" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br /><br>
    <div>
        <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click"/>
    </div>

</asp:Content>
