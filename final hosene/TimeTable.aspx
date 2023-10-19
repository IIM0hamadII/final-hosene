<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TimeTable.aspx.cs" Inherits="final_hosene.TimeTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style
>
table, th
{
border: 3px solid #261a0d;

text-align: center;


font-family: Urdu Typesetting;


font-style: oblique;


font-size: 30px;


margin: 0px auto;

}
body
{
direction:initial;


}
td
{
border: 3px solid #392613;

width: 200px;

height: 50px;

}
.col1
{

background-color: #ecd9c6;

}
.col2
{
background-color: #e6ccb3;


}
.col3
{
background-color: #dfbf9f;


}
.col4
{
background-color: #d9b38c;


}
.col5
{
background-color: #d2a679;


}
.col6
{
background-color: #cc9966;


}
.col7
{
background-color: #c68c53;


}
.col8
{
background-color: #bf8040;


}
.col9
{
background-color: #ac7339;


}
.col10
{
background-color: #996633;


}
.col11
{
background-color: #86592d;


}
.col12 {
background-color: #663300;
}
.col13 {
background-color: #ffb366;
}
</style>
<meta charset="utf-8" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 id="top" style="color: #ffdd99; text-align: center; font-family: Urdu Typesetting; font-style: italic; font-size: 50px; "> time table</h1>

<table style="text-align: center;">
<tr>
<th class="col12">Monday</th>
<th class="col12">Tuesday</th>
<th class="col12">Wednesday</th>
<th class="col12">Thursday</th>
<th class="col12">Friday</th>
<th class="col12">Saturday</th>
</tr>
<tr>
<td class="col1"> math</td>
<td class="col2" colspan="2">arabic</td>
<td class="col3" rowspan="2">physics </td>
<td class="col1" rowspan="2">math</td>
<td class="col6" rowspan="2">programing</td>
</tr>
<tr>
<td class="col4"> history</td>
<td class="col5" colspan="2"> sport</td>
</tr>
<tr>
<td class="col6">C#</td>
<td class="col7"> hebrow</td>
<td class="col8">English</td>
<td class="col2"> arabic</td>
<td class="col3" rowspan="2"> physics</td>
<td class="col9"> relegion class</td>
</tr>
<tr>
<td class="col8" rowspan="2">English</td>
<td class="col1"> math </td>
<td class="col6" rowspan="2">HTML</td>
<td class="col7">hebrow</td>
<td class="col10" rowspan="2"> history</td>
</tr>
<tr>
<td class="col6"> programing</td>
<td class="col6" colspan="2">C#</td>
</tr>
<tr>
<td class="col7"> hebrow</td>
<td class="col4" colspan="2">history</td>
<td class="col11">sport</td>
<td class="col7"> hebrow</td>
<td class="col13" rowspan="3">-</td>
</tr>
<tr>
<td class="col2" >arabic</td>
<td class="col3" rowspan="2">physics </td>
<td class="col1" rowspan="2"> math </td>
<td class="col8" rowspan="2">English</td>
<td class="col10">math </td>
</tr>
<tr>
<td class="col13">-</td>
<td class="col13">-</td>
</tr>
</table>


</asp:Content>
