<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.PrintName._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row h1">
        <asp:Label runat="server" ID="Lb_Hello" AssociatedControlID="Txt_Name"></asp:Label>
    </div>
    <div class="row">
        <div class="col-md-6 h3">
            <asp:TextBox runat="server" ID="Txt_Name"></asp:TextBox>
        </div>
        <div class="col-md-6 h3">
            <asp:Button runat="server" Text="Print Name" ID="Btn_PrintName" CssClass="btn btn-default" OnClick="BtnPrintName" />
        </div>
    </div>
</asp:Content>
