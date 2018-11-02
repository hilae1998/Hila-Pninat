<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>קבלה</h2>
    <div>
        <label>תאריך:</label><input type="text" /><br />
        <br />
        <label>סכום:</label><input type="text" /><br />
        <label>אופן התשלום: </label>
        <select>
            <option>מזומן</option>
            <option>שיק</option>
            <option>אשראי</option>
        </select>

        <label>שיק מספר: </label>
        <input type="text" /><br />
        <label>בנק: </label>
        <select>
            <option>a</option>
            <option>b</option>
            <option>c</option>
        </select><br />
        <label>סניף: </label>
        <input type="text" /><br />
        <label>מספר חשבון:  </label>
        <input type="text" /><br />


        <label>סוג כרטיס: </label>
        <select id="Select1">
            <option>a</option>
            <option>b</option>
            <option>c</option>
        </select><br />


        <label>מספר כרטיס: </label>
        <input type="text" /><br />

        <label>בתוקף: </label>
        <input type="text" /><br />

        <label>שם בעל הכרטיס: </label>
        <input type="text" /><br />

        <input id="Button1" type="button" value="הוסף תשלום" />
        <input id="Button1" type="button" value="הדפס קבלה" />

    </div>





</asp:Content>
