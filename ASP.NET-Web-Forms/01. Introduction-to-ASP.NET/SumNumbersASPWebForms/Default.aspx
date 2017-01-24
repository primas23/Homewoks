<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SumNumbersASPWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="firNum" Text="First number"></asp:Label>
        <asp:TextBox runat="server" CssClass="form-control" ID="firNum"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="secNum" Text="Second number"></asp:Label>
        <asp:TextBox runat="server" CssClass="form-control" ID="secNum"></asp:TextBox>
    </div>
    <asp:Button runat="server" OnClick="CalcSum"  Text="Calculate sum" CssClass="btn btn-default"/>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="result" Text="Result"></asp:Label>
        <asp:TextBox runat="server" CssClass="form-control" ID="result"></asp:TextBox>
    </div>
</asp:Content>
