<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileSearch.aspx.cs" Inherits="BMI.FileSearch" %>

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
        <h1>검색어를 포함하는 파일 검색</h1>
        <br />
        <br />
        검색어 :
        <asp:TextBox ID="txtKeyWord" runat="server"></asp:TextBox>
        <br />
        <br />
        파일형 :&nbsp;
        <asp:DropDownList ID="ddFileType" runat="server">
            <asp:ListItem Value="0">워드(*.doc)</asp:ListItem>
            <asp:ListItem Value="1">파워포인트(*.ppt)</asp:ListItem>
            <asp:ListItem Value="2">한글(*.hwp)</asp:ListItem>
            <asp:ListItem Value="3">어도비(*.pdf)</asp:ListItem>
            </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" PostBackUrl="~/FileSearchResult.aspx" Text="검색어 보기" />
        </div>
    </form>
</body>
</html>
