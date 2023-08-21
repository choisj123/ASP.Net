<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CircleAreaCalculator.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            height: 24px;
            width: 346px;
        }
        .auto-style3 {
            height: 24px;
            width: 138px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:450px; height: 70px; text-align: center; border-collapse: collapse;">
                <tr style=""height: 70px;">
                    <td colspan="3" style="border: 1px solid #C0C0C0">원의 넓이 구하기</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="border: 1px solid #C0C0C0">반지름</td>
                    <td class="auto-style2" style="border: 1px solid #C0C0C0">
                        <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>&nbsp;cm</td>
                    <td class="auto-style1" style="border: 1px solid #C0C0C0">
                        <asp:Button ID="btnArea" runat="server" Text="넓이 구하기" OnClick="btnArea_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="border: 1px solid #C0C0C0">
                        <asp:Label ID="lblOutput" runat="server" Text="-"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
