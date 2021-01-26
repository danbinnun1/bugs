<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="bugs.report" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centering">
        <asp:TextBox runat="server" ID="description" placeholder="description" CssClass="input" required="true" />
        <asp:FileUpload ID="image" runat="server" />
        <asp:Button Text="submit" runat="server" OnClick="submit" CssClass="button" />
    </div>
</asp:Content>
