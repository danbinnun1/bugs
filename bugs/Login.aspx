﻿<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="bugs.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centering">
        <asp:TextBox runat="server" ID="username" placeholder="username" CssClass="input" />
        <asp:RequiredFieldValidator ErrorMessage="Username is required!" ControlToValidate="username" runat="server" Display="Dynamic"/>
        <asp:TextBox runat="server" ID="password" placeholder="password" TextMode="Password" CssClass="input" />
        <asp:RequiredFieldValidator ErrorMessage="Password is required!" ControlToValidate="password" runat="server" Display="Dynamic"/>

        <asp:Label runat="server" ID="errorBox"></asp:Label>
        <asp:Button Text="Login" runat="server" OnClick="Login_Click" CssClass="button" />
    </div>
</asp:Content>
