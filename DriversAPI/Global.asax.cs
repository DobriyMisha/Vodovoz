using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DriversAPI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// ������ ����������
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// ��� ��� xsp4, ������� ������ ��������� Content-Length
        /// ��� ������������� ��� ���������� ������� ������� - �������
        /// </summary>
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Response.Headers.Remove("Content-Length");
        }
    }
}
