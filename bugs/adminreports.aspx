<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="adminreports.aspx.cs" Inherits="bugs.adminreports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="reports" runat="server" OnItemCommand="reports_ItemCommand">
       <ItemTemplate>
           <asp:Image ID="image" ImageUrl='<%#Bind("AppealedImage")%>' runat="server" />
           <asp:Label ID="description" runat="server" Text='<%#Bind("AppealedReason")%>'></asp:Label>
           <asp:TextBox ID="response" runat="server"></asp:TextBox>
           <asp:RadioButtonList ID="status" runat="server">
               <asp:ListItem>accept</asp:ListItem>
               <asp:ListItem>deny</asp:ListItem>
           </asp:RadioButtonList>
           <asp:Button ID="submit" runat="server" Text="submit"  CommandName="submit"/>
       </ItemTemplate>
   </asp:DataList>
</asp:Content>
