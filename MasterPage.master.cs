using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MasterPage : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null || Session["pwd"] == null||Session["Mode"] == null)        
        {
            Response.Redirect("index.aspx", true);
        }

    }
    protected void updatePw_Click(object sender, EventArgs e)
    {
        Response.Redirect("updatePW.aspx?id=" + Session["id"] + "&Mode=" + Session["Mode"]);
    }
    protected void exit_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Request.Cookies.Clear();
        Session.Clear();
        Response.Write("<script>alert('退出成功！');top.window.location.href='index.aspx'</script>");
    }
}
