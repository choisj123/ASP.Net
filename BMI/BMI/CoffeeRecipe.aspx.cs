using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CoffeeType.Items.Add(new ListItem("밀크커피(설탕+프림)", "0"));
                CoffeeType.Items.Add(new ListItem("프림커피(프림)", "1"));
                CoffeeType.Items.Add(new ListItem("설탕커피(설탕)", "2"));
                CoffeeType.Items.Add(new ListItem("블랙커피", "3"));
            }

        }

        protected void ShowRecipe_ServerClick(object sender, EventArgs e)
        {
            string filePath = Request.PhysicalApplicationPath + @"App_Data\";
            string fileName = "";

            Response.Write("<ol>");

            // 선택한 항목으로 커피 종류 할당
            ListItem item = CoffeeType.Items[CoffeeType.SelectedIndex];
            int coffeeType = int.Parse(item.Value);

            for(int i = 0; i < 4; i++)
            {
                fileName = filePath + i + ".txt";
                Response.WriteFile(fileName);

                if(i != 3 && ((i & coffeeType) == 1 || (i & coffeeType) == 2))
                {
                    Response.Clear();
                }

                Response.Flush();
            }

            Response.Write("</ol>");

            info.InnerHtml = "== Request 정보 == <br> "
                + Server.ScriptTimeout + "<br>"
                + Server.HtmlEncode("x<y and >z") + "<br>";

        }
    }
}