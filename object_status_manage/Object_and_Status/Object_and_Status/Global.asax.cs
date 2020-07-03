using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Object_and_Status
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 응용 프로그램 시작 시 실행되는 코드
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 방문자 수 초기화
            Application["visit"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            // 방문자 카운트 작업
            Application["visit"] = Convert.ToInt32((Application["visit"].ToString())) + 1;
        }
    }
}