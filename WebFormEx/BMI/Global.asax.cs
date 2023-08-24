using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BMI
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 응용 프로그램 시작 시 실행되는 코드
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_EndRequrst(object sender, EventArgs e)
        {
            Response.Write("<hr/>");
            Response.Write("이 페이지는 ");
            Response.Write(DateTime.Now.ToString());
            Response.Write("에 작성되었습니다.");


        }
    }
}