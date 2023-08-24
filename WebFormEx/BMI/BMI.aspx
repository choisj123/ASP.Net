<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="BMI.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>체질량지수(BMI) 산출기</title>
</head>
<body>
    <form id="webForm" runat="server">
        <table>
            <tr>
                <td>신장</td>
                <td><input id="Height" type="text" runat="server"/></td>
                <td>
                    <select id="Mesure" runat="server"></select>
                </td>
            </tr>
            <tr>
                <td>몸무게</td>
                <td><input id="Weight" type="text" runat="server"/></td>
                <td>kg</td>
            </tr>
            <tr style="text-align:center;">
                <td colspan="3">
                    <input id="Calc" type="submit"  value="산출하기" onserverclick="Calc_ServerClick" runat="server"/>
                </td>
            </tr>
        </table>
        <p id="Result" runat="server"></p>

        <br />
        
        <p id="info" runat="server"></p>
    </form>
</body>
</html>
