<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.HelloAsp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello, ASP.NET</h1>
    <asp:Label runat="server" ID="lb_Hello" CssClass="h1"></asp:Label>
    <asp:Label runat="server" ID="lb_assembly_location" CssClass="h3"></asp:Label>
</asp:Content>
