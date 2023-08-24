<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoffeeRecipe.aspx.cs" Inherits="BMI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="CoffeeForm" runat="server">
        <div>
            커피 종류 선택 :
            <select id="CoffeeType" runat="server">
                <option></option>
            </select>
            <input id="ShowRecipe" type="submit" value="레시피 보기" onserverclick="ShowRecipe_ServerClick" runat="server" />
        </div>
        <p id="info" runat="server"></p>
    </form>
</body>
</html>
