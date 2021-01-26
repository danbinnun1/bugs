<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="myreports.aspx.cs" Inherits="bugs.myreports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="reports" runat="server" OnItemCommand="reports_ItemCommand">
       <ItemTemplate>
           <asp:Label ID="status" runat="server" Text='<%#Bind("statusMessage") %>'></asp:Label>
           <asp:Image ID="image" ImageUrl='<%#Bind("image")%>' runat="server" />
           <asp:Label ID="description" runat="server" Text='<%#Bind("description")%>'></asp:Label>
           <asp:Label ID="date" runat="server" Text='<%#Bind("date")%>'></asp:Label>
           <asp:TextBox ID="appealReason" runat="server" Visible='<%#Bind("canBeAppealed") %>'></asp:TextBox>
           <asp:Button ID="appeal" runat="server" Text="appeal" Visible='<%#Bind("canBeAppealed") %>' CommandName="submit" />
       </ItemTemplate>
   </asp:DataList>
</asp:Content>
