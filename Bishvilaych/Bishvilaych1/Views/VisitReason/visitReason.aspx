<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Home</h2>

    <% if (ViewBag.auth == 0) //מנהלת
       {%>
    <div><%: Html.ActionLink("מטופלות", "Patiants", "Patiants") %></div>
    <div><%: Html.ActionLink("עובדות", "Workers", "Workers") %></div>
    <div><%: Html.ActionLink("פרויקטים בקהילה", "Customers", "Customers") %></div>
    <div><%: Html.ActionLink("כספי", "Reciepts", "Reciepts") %></div>
    <% } %>

    <% if (ViewBag.auth == 1) //מזכירה
       {%>
    <div><%: Html.ActionLink("מטופלות", "Patiants", "Patiants") %></div>
    <div><%: Html.ActionLink("פרויקטים בקהילה", "Customers", "Customers") %></div>
    <div><%: Html.ActionLink("כספי", "Reciepts", "Reciepts") %></div>
    <% } %>

    <% if (ViewBag.auth == 2 || ViewBag.auth == 3) //רופאה-אחות-תזונאית
       {%>
    <div><%: Html.ActionLink("מטופלות", "Patiants", "Patiants") %></div>
    <% } %>
</asp:Content>
