using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MicwayTechTest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings =
                  new JsonSerializerSettings
                  {
                      Culture = CultureInfo.GetCultureInfo("en-AU"),
                      DateFormatString = "dd/MM/yyyy"
                  };
        }
    }
}
