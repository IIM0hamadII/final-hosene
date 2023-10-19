<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="final_hosene.adminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        h1{text-align: center;
           color:#6914f5;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>admin page</h1>

    <div style="text-align:center;"><%=msg%></div>
</asp:Content>

