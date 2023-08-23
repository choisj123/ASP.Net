<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PitchRaising.aspx.cs" Inherits="BMI.PitchRaising" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblTitle" runat="server" Font-Size="Large" Text="피치를 올려라!"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnPitchDown" runat="server" Text="한 음 내리기" OnClick="btnPitchDown_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPitch" runat="server" Text="라"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPitchUp" runat="server" OnClick="btnPitchUp_Click" Text="한 음 올리기" />
        </div>
    </form>
</body>
</html>
