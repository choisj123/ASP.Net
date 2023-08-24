<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileSearchResult.aspx.cs" Inherits="BMI.FileSearchResult" %>

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
        <div>
            <h1 class="auto-style1">검색어를 포함하는 파일 검색</h1>
            <p class="auto-style1">
                <asp:HyperLink ID="lnkSearchString" Target="_blank" runat="server">HyperLink</asp:HyperLink>
            &nbsp;&nbsp;
                <asp:Button ID="btnGoBack" runat="server" PostBackUrl="~/FileSearch.aspx" Text="이전페이지로 가기" />
            </p>
        </div>
    </form>
</body>
</html>
