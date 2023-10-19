<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="final_hosene.adminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        h1{text-align: center; color:#ee2424; }
        table{margin: 0px auto; direction: rtl; text-align: center;}
        input{text-align: center; }
        h2{text-align:center; direction: ltr;  }
        h3{text-align:center; color:maroon; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form method="post" runat="server">
        <h1>admin login</h1>
        <table>
            <tr>                            
                <td>name:</td>
                <td><input type="text" name="mName" /></td>
            </tr>
            <tr>
                <td>password:</td>
                <td><input type="password" name="mPw" /></td>
            </tr>
            <tr>
                <!-- submit ל- name חשוב! לא לשכוח לתת תגית   -->
                <td colspan="2" style="text-align:center;">
                    <input type="submit" name="submit" value="   login   " />
                </td>
            </tr>
        </table>
          <h2><%= sqlLogin %></h2>
        <h3><%= msg %></h3>

    </form>
</asp:Content>
