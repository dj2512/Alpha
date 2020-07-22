<%@ Page Title="" Language="C#" MasterPageFile="~/depthead.master" AutoEventWireup="true" CodeFile="D_internalmarks.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <asp:DropDownList ID="Year" runat="server" Height="40px" AutoPostBack="True" OnSelectedIndexChanged="Year_SelectedIndexChanged" >
                <asp:ListItem>Select Year</asp:ListItem>
                <asp:ListItem Value="2018">1st Year</asp:ListItem>
                <asp:ListItem Value="2017">2nd Year</asp:ListItem>
                <asp:ListItem Value="2016">3rd Year</asp:ListItem>
                <asp:ListItem Value="2015">4th Year</asp:ListItem>
            </asp:DropDownList><br />
    <br />
            <asp:DropDownList ID="students" Height="40px" runat="server">
    </asp:DropDownList><br /><br />
     <asp:DropDownList ID="reY" Height="40px" runat="server" Visible="False">
                <asp:ListItem Value="1">1st Year</asp:ListItem>
                <asp:ListItem Value="2">2nd Year</asp:ListItem>
                <asp:ListItem Value="3">3rd Year</asp:ListItem>
                <asp:ListItem Value="4">4th Year</asp:ListItem>
               
    </asp:DropDownList><br /><br />
          <asp:Button ID="get_result" runat="server" Text="Get Result"  Class="login100-form-btn" OnClick="get_result_Click" />
</asp:Content>

