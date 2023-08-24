using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMI
{
    public partial class BMI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Mesure.Items.Add(new ListItem("cm", "0.01"));
                Mesure.Items.Add(new ListItem("feet","0.3048"));
                Mesure.Items.Add(new ListItem("m", "1"));
            }
        }

        protected void Calc_ServerClick(object sender, EventArgs e)
        {
            ListItem item = Mesure.Items[Mesure.SelectedIndex];
            decimal height = Decimal.Parse(Height.Value) / Decimal.Parse(item.Value);
            decimal weight = Decimal.Parse(Weight.Value);
            decimal BMI = Math.Round(weight / (height * height), 2);
            Result.InnerText = "체질량지수(BMI) : " + BMI.ToString();

            info.InnerHtml = "== Request 정보 == <br> " 
                + Request.PhysicalApplicationPath + "<br>"
                + Request.ApplicationPath + "<br>"
                + Request.Path + "<br>"
                + Request.Url + "<br>"
                + Request.UserHostAddress + "<br>"
                + Request.UserHostName + "<br>"
                + Request.Browser + "<br>"
                + Request.Cookies + "<br>"
                + Request.QueryString;
        }
    }
}





