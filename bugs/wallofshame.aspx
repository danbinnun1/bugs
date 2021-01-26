<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="wallofshame.aspx.cs" Inherits="bugs.wallofshame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>wall of shame to B.U.Gs</h1>
    <asp:DataList ID="reports" runat="server" OnItemCommand="reports_ItemCommand">
       <ItemTemplate>
           <asp:Image ID="image" ImageUrl='<%#Bind("image")%>' runat="server" />
           <asp:Label ID="description" runat="server" Text='<%#Bind("StartOfContent")%>'></asp:Label>
           <asp:Label ID="date" runat="server" Text='<%#Bind("date")%>'></asp:Label>
           <asp:Button ID="readmore" runat="server" Text="read mode" CommandName="readmore" />
       </ItemTemplate>
   </asp:DataList>
</asp:Content>
