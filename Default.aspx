<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>Compiler Online</h2>
            </hgroup>
            <p>
                Your Great Ideas will be Born here</p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>
        <asp:TextBox ID="tb_code" runat="server" Height="395px" TextMode="MultiLine" ToolTip="This is the place for your code" Width="919px"></asp:TextBox>
        <asp:Button ID="b_clear" runat="server" OnClick="b_clear_Click" Text="Clear" ToolTip="Click here to clear" Width="116px" />
        <asp:Button ID="b_submit" runat="server" OnClick="b_submit_Click" Text="Submit" ToolTip="Click here to submit your code" />
</h3>
<h3>
        &nbsp;</h3>
    </asp:Content>