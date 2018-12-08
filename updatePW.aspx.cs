using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updatePW : System.Web.UI.Page
{
    string modestr;
    string idstr;
    SqlHelp sqlHelper = new SqlHelp();
    string updateSql;
    protected void Page_Load(object sender, EventArgs e)
    {
        modestr = Request.QueryString["Mode"];
        idstr = Request.QueryString["id"];
    }
    protected void change_Click(object sender, EventArgs e)
    {
        if (modestr == "reader")
        {
            if (checkExist(accountBox.Text, 0))
            {
                if (checkpw(accountBox.Text, 0))
                {
                    updateSql = "UPDATE reader SET password = " + "'" + newpw.Text + "'" + "WHERE id = " + "'" + accountBox.Text + "'";
                    sqlHelper.ExecuteNonQuery(updateSql);
                    Response.Write("<script>alert('已成功修改密码！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('输入的密码错误！')</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('账号不存在！')</script>");
            }
        }
        else if (modestr == "admin")
        {
            if (checkExist(accountBox.Text, 1))
            {
                if (checkpw(accountBox.Text, 1))
                {
                    updateSql = "UPDATE administrator SET password = " + "'" + newpw.Text + "'" + "WHERE id = " + "'" + accountBox.Text + "'";
                    sqlHelper.ExecuteNonQuery(updateSql);
                    Response.Write("<script>alert('已成功修改密码！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('输入的密码错误！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('账号不存在！')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('系统错误！')</script>");
        }
    }
    protected Boolean checkExist(string account, int flag)
    {
        string selectSql;
        int count;
        if (flag == 0)
        {
            selectSql = "SELECT id FROM reader WHERE id="+"'"+account+"'";
            count = sqlHelper.SqlServerRecordCount(selectSql);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            selectSql = "SELECT id FROM administrator WHERE id="+"'"+account+"'";
            count = sqlHelper.SqlServerRecordCount(selectSql);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    protected Boolean checkpw(string account,int flag)
    {
        account = accountBox.Text;
        string password = oldpw.Text;
        string selectac;
        int count;
        if (flag == 0)
        {
            selectac = "SELECT id FROM reader WHERE password = "+password+" AND "+"id = "+account;
            count = sqlHelper.SqlServerRecordCount(selectac);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else 
        {
            selectac = "SELECT id FROM administrator WHERE password = " + password + " AND " + "id = " + account;
            count = sqlHelper.SqlServerRecordCount(selectac);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
    }

}