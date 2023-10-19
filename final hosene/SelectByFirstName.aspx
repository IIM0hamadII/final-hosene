<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SelectByFirstName.aspx.cs" Inherits="final_hosene.SelectByFirstName" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
h1{text-align:center;color:#d74141;}
h2{direction:ltr;text-align:center;}
h3{text-align:center; color:maroon;}
table, th, td{border: 1px solid black;}
table {margin: 0px auto;}
th, td{text-align:center;}
.right {text-align: right; }
.left{text-align:left}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>all the namees that contain r</h2>
    <h2><%= sqlSelect %></h2>
<table style="border: 1px solid black; margin: 0px auto;">
<%= st %>
</table>
<h3><%= msg %></h3>
</asp:Content>
