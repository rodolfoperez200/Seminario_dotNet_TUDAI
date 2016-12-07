using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            Logger.WriteLog("Se ejecuto Default->Page_Init");
            TextBox1.Text = "Hola mundo";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Logger.WriteLog("Se ejecuto Default->Page_Load");
            if (Page.IsPostBack)
            {
                Logger.WriteLog("IsPostBack");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Se ejecuto Default->Button1_Click");
            Label1.Text = TextBox1.Text;
        }

        protected void ButtonError_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Se ejecuto Default->ButtonError_Click");

            var x = 0;
            var result = 100/x; //Forzar error
        }

        protected void ButtonCleanLogs_Click(object sender, EventArgs e)
        {
            Logger.Clean();
        }


        private void Page_PreRender(object sender, EventArgs e)
        {
            Logger.WriteLog("Se ejecuto Default->Page_PreRender");

        }


    }
}