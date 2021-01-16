<%@ Page Title="" Language="C#" MasterPageFile="~/matser.Master" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="bugs.adminpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:DataList ID="reports" runat="server">
       <ItemTemplate>
           <asp:Image ID="image" ImageUrl='<%#Bind("image")%>' runat="server" />
           <asp:Label ID="description" runat="server" Text='<%#Bind("description")%>'></asp:Label>
           <asp:Label ID="id" runat="server" Text='<%#Bind("ID")%>'></asp:Label>
           <asp:TextBox ID="response" runat="server"></asp:TextBox>
           <asp:RadioButtonList ID="status" runat="server">
               <asp:ListItem>accept</asp:ListItem>
               <asp:ListItem>deny</asp:ListItem>
           </asp:RadioButtonList>
           <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="submit" />
       </ItemTemplate>
   </asp:DataList>
</asp:Content>
