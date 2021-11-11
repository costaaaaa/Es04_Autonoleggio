using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es04_Autonoleggio
{
    public partial class login : System.Web.UI.Page
    {
        clsDB db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new clsDB("AppData\\Autonoleggio.mdf");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}