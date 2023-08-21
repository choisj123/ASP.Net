<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>반갑습니다! ASP.NET </title>
    <script runat="server">
        void Page_Load(object sender, System.EventArgs e)
        {
            timeMessage.Text = "현재시각 : " + DateTime.Now.ToString();
        }
    </script>
</head>
<body>
    <center>
        <h3>반갑습니다! ASP.NET</h3>
        <hr width="300" />
        <asp:Label id="timeMessage" runat="server"></asp:Label>
        <hr width="300" />
    </center>
</body>
</html>
