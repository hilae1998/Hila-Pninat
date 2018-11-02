<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1 dir="rtl">בדיקות עזר</h1>

    <table  dir="rtl">
        <tr>
            <td><h2>תאריך</h2></td>
            <td><h2>בדיקה</h2></td>
            <td><h2>ערך</h2></td>
            
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
           
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            
        </tr>
    </table>

    <button  style="background-color:white;border-color:black">מחק</button> <button  style="background-color:white;border-color:black">ערוך</button> <button  style="background-color:white;border-color:black;">חדש</button>
    <br /><br /><br />

    <h1 dir="rtl">חיסונים</h1>

    <table dir="rtl">
        <tr>
            <td><h2>תאריך</h2></td>
            <td><h2>חיסון</h2></td>
            <td><h2>הערות</h2></td>
           
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
           
        </tr>
    </table>

    <button style="background-color:white;border-color:black">מחק</button> <button style="background-color:white;border-color:black">ערוך</button> <button style="background-color:white;border-color:black;">חדש</button>


   
</asp:Content>

