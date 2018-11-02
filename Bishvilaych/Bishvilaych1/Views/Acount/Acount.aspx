<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Acount
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Acount</h2>

</asp:Content>
<%--<div id="name"></div>
<div id="password"></div>--%>
<TextBox id="name">:שם משתמש</TextBox>
<TextBox ID="password">:סיסמה</TextBox>
<Button ID="enter" Text="הכנס" />