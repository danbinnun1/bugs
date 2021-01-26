<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="reportforum.aspx.cs" Inherits="bugs.reportforum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="report" runat="server"></asp:Label>
    <asp:Image ID="image" runat="server" />
    <asp:DataList ID="Comments" runat="server">
        <ItemTemplate>
            <asp:Label ID="username" runat="server" Text='<%#Bind("ReporterName") %>'></asp:Label>
            <asp:Label ID="content" runat="server" Text='<%#Bind("Content") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
    <asp:TextBox ID="comment" runat="server"></asp:TextBox>
    <asp:Button ID="submit" runat="server" OnClick="submit_Click" />
</asp:Content>
