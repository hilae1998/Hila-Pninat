<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/Site.Master" CodeBehind="AddPatiant.aspx.cs" Inherits="Bishvilaych.Views.AddPatiant" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div dir="rtl">
            <div style="margin-top: 300px">
                <h1>הוספת מטופלת</h1>
                <div>
                    <label>מספר זהות:</label>
                    <input id="Text1" type="text" />
                </div>
                <div>
                    <label>שם פרטי:</label>
                    <input id="Text2" type="text" />
                </div>
                <div>
                    <label>שם משפחה:</label>
                    <input id="Text3" type="text" />
                </div>
                <div>
                    <label>
                        קופות חולים:
                    </label>
                    <select id="select1">
                        <option selected="selected">לאומית</option>
                        <option>כללית</option>
                        <option>מאוחדת</option>
                        <option>מכבי</option>
                    </select>
                </div>
                <button style="margin-right: 200px">הוסף</button>
            </div>
        </div>
    </form>
</body>
</html>