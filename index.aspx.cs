using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String account1 = account.Text;
        if (RadioButtonList1.SelectedValue != "用户" && RadioButtonList1.SelectedValue != "管理员")
        {
            Response.Write("<script>alert('请选择登录角色！')</script>");
        }
        else if (RadioButtonList1.SelectedValue == "用户")
        {
            String selectSql = "SELECT * FROM reader Where id=" + account1;
            Boolean flag = login(selectSql, 1);
            if (flag == true)
            {
                //跳转页面
<<<<<<< Updated upstream
                Response.Redirect("reader.aspx?id="+account.Text+"&Mode=reader");
=======
                Response.Redirect("reader.aspx?id=" + account.Text + "&Mode=reader");
>>>>>>> Stashed changes
            }

        }
        else
        {
            String selectSql = "SELECT * FROM administrator Where id=" + account1;
            Boolean flag = login(selectSql, 0);
            if (flag == true)
            {
                //跳转页面
            }
        }

    }

    private Boolean login(String selectSql, int flag)
    {
        String account1 = account.Text;
        String password1 = password.Text;
        //String selectSql = "SELECT * FROM administrator Where id=" + account1;
        SqlHelp sqlHelper = new SqlHelp();
        int count = sqlHelper.SqlServerRecordCount(selectSql);//返回符合的结果数量
        if (count > 0)//如果信息>0则说明匹配成功
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectSql);
            while (reader.Read())
            {
                //int a = reader.GetInt32(0);
                try
                {
                    String b;
                    if (flag == 0)  //管理员
                    {
                        b = reader.GetString(4);
                    }
                    else      //用户
                    {
                        b = reader.GetString(5);
<<<<<<< Updated upstream
                       
=======

>>>>>>> Stashed changes
                    }
                    if (b.Equals(password1))
                    {
                        Response.Write("<script>alert('登陆成功')</script>");
                        return true;
                    }
                    else
                    {
                        Response.Write("<script>alert('密码错误')</script>");
                        return false;
                    }
                }
                catch (System.InvalidCastException e)
                {
                    Response.Write("<script>alert('系统出错')</script>");
                    return false;
                }
            }
            reader.Close();
            SqlHelp.CloseConn();
        }
        else
        {
            Response.Write("<script>alert('账号不存在')</script>");
            return false;
        }
        return false;
    }
}