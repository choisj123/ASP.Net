using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnArea_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txtRadius.Text);

            double area = CalculateCircleArea(radius);

            lblOutput.Text = "반지름이 " + txtRadius.Text + "cm인 원의 넓이는 " + Math.Round(area,3).ToString() + "cm<sup>2</sup>입니다.";


        }

        protected double CalculateCircleArea(double radius)
        {
            double circleArea = radius * radius * Math.PI;
            return circleArea;
        }
    }
}