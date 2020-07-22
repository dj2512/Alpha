<%@ Page Title="" Language="C#" MasterPageFile="~/depthead.master" AutoEventWireup="true" CodeFile="D_allstudent.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<asp:DropDownList ID="Year" runat="server" AutoPostBack="true" Height="40px" OnTextChanged="Year_TextChanged">
    <asp:ListItem Value="0">Select Year</asp:ListItem>
    <asp:ListItem Value="2018">1st Year</asp:ListItem>
    <asp:ListItem Value="2017">2nd Year</asp:ListItem>
    <asp:ListItem Value="2016">3rd Year</asp:ListItem>
    <asp:ListItem Value="2015">4th Year</asp:ListItem>
</asp:DropDownList>
<asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>

