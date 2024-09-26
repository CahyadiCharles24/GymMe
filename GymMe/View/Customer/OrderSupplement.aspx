<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="OrderSupplement.aspx.cs" Inherits="GymMe.View.Customer.OrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <h1>
                Order Supplement
            </h1>
        </div>
        <div>
            <asp:GridView ID="GV_Supplement" runat="server" AutoGenerateColumns="false"
                OnSelectedIndexChanged="GV_Supplement_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="SupplementID"></asp:BoundField>
                    <asp:BoundField HeaderText="Supplement Name" DataField="SupplementName"></asp:BoundField>
                    <asp:BoundField HeaderText="Supplement Price" DataField="SupplementPrice"></asp:BoundField>
                    <asp:BoundField HeaderText="Supplement Price" DataField="SupplementExpiryDate"></asp:BoundField>
                    <asp:BoundField HeaderText="Type" DataField="TypeName" />
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID="TB_Quantity" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Btn_Order" runat="server" UseSubmitBehavior="false" Text="Order" CommandName="Select"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
        <div>
            <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        </div>

        <br />

        <asp:Panel ID="Pnl_Cart" runat="server" Visible="false">
            <div>
                <div>
                    <asp:GridView ID="GV_Cart" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="SupplementID" HeaderText="Supplement ID" SortExpression="SupplementID"></asp:BoundField>
                            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                        </Columns>

                    </asp:GridView>
                </div>
                <div>
                    <asp:Button ID="Btn_Clear" runat="server" Text="Clear cart" OnClick="Btn_Clear_Click" Visible="false"/>
                    <asp:Button ID="Btn_Orders" runat="server" Text="Check Out" OnClick="Btn_Orders_Click" Visible="false"/>
                </div>
            </div>
        </asp:Panel>
        

    </div>
</asp:Content>
