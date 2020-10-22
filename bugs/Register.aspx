<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="bugs.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centering">

        <asp:TextBox runat="server" ID="username" placeholder="username" CssClass="input" required="true" />
        <asp:RequiredFieldValidator Display="Dynamic" ErrorMessage="Username is required!" ControlToValidate="username" runat="server" />
        <asp:RegularExpressionValidator Display="Dynamic" ErrorMessage="Username must be between 3 and 16 characters, with no special characters" ControlToValidate="username" runat="server" ValidationExpression="^\w{3,16}$" />
        
        <asp:TextBox runat="server" CssClass="input" ID="password" placeholder="password" required="true" />
        <asp:RequiredFieldValidator Display="Dynamic" ErrorMessage="Password is required!" ControlToValidate="password" runat="server" />
        <asp:RegularExpressionValidator Display="Dynamic" ErrorMessage="Password must be at least 6 letters, with at least one capital letter, lowercase letter and one number" ControlToValidate="password" runat="server" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{6,}$" />
        
        <asp:Label runat="server" ID="errorBox"></asp:Label>
        <asp:Button Text="Register" runat="server" OnClick="Register_Click" CssClass="button" />
    </div>
</asp:Content>
