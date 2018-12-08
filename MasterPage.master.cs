using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void updatePw_Click(object sender, EventArgs e)
    {
        string idstr = Request.QueryString["id"];
        string modestr = Request.QueryString["Mode"];
        Response.Redirect("updatePW.aspx?id="+idstr+"&Mode=" + modestr);
    }
    protected void exit_Click(object sender, EventArgs e)
    {

    }
}
