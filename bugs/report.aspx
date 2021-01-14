<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="bugs.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centering">
        <asp:TextBox runat="server" ID="description" placeholder="description" CssClass="input" />
        <asp:RequiredFieldValidator ErrorMessage="description is required!" ControlToValidate="username" runat="server" Display="Dynamic"/>
        <asp:TextBox runat="server" ID="name" placeholder="name" CssClass="input" />
        <asp:RequiredFieldValidator ErrorMessage="name is required!" ControlToValidate="password" runat="server" Display="Dynamic"/>

        <asp:Label runat="server" ID="errorBox"></asp:Label>
        <asp:Button Text="submit" runat="server" OnClick="submit" CssClass="button" />
    </div>
</asp:Content>
