<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="final_hosene.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
h1{text-align: center; color:white }
table{margin: 0px auto; direction: rtl; text-align: center;}
input{text-align: center; }
h2{text-align:center; direction: ltr; }
h3{text-align:center; color:maroon; }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form method="post" runat="server">
        <h1> user login</h1>
        <table>
<tr> 
<td>username</td>
    <td><input type="text" name="uName" /></td>
</tr>
<tr>
<td>password</td>
    <td><input type="password" name="pass" /></td>
</tr>
<tr>
<td colspan="2" style="text-align:center;">
<input type="submit" name="submit" value="connect " />
    </td>
</tr>
</table>
<h2><%= sqlLogin %></h2>
<h3><%= msg %></h3>

    </form>

</asp:Content>
