using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Logger.WriteLog("Global->Application_Start");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Logger.WriteLog("Global->Application_End");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();

            Logger.WriteLog("Global->Application_Error");
            Logger.WriteLog("HResult: " + error.HResult);
            Logger.WriteLog("Message:" + error.Message);
            if (error.InnerException != null)
            {
                Logger.WriteLog("InnerException HResult: " + error.InnerException.HResult);
                Logger.WriteLog("InnerException Message:" + error.InnerException.Message);
            }

        }

        protected void Application_LogRequest(object sender, EventArgs e)
        {
            Logger.WriteLog("Global->Application_LogRequest");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Logger.WriteLog("Global->Session_Start:" + Session.SessionID);
            //Guardo un valor en session para que luego se ejecute Session_End
            Session["starttime"] = DateTime.Now;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Logger.WriteLog("Global->Session_End:" + Session.SessionID);
        }



    }
}