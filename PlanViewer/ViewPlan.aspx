<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlan.aspx.cs" Inherits="PlanViewer.ViewPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="PlansDataSource" DataTextField="res" DataValueField="res" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="PlansDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TeamProjectDB2ConnectionString %>" OnSelecting="PlansDataSource_Selecting" SelectCommand="SELECT CAST([Plan].Id AS nchar) + ' ' + Contractor.Name + ' ' + Customer.Name AS res FROM [Plan] INNER JOIN Contractor ON [Plan].Contractor = Contractor.ID INNER JOIN Customer ON [Plan].Customer = Customer.ID"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server" >
        <asp:TableHeaderRow BorderStyle="Dashed">
            <asp:TableHeaderCell BorderStyle="Double">ID </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Заказчик </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Подрядчик </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Объект работ </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Вид работ </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Наимменование единичной расценки </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Единица измерения </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Трудозатраты </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Материалы </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Механизмы </asp:TableHeaderCell>            
        </asp:TableHeaderRow>
        <asp:TableRow BorderStyle="Dashed">
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
