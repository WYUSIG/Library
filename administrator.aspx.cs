using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class administrator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //点击左侧菜单借书响应函数
    protected void lendBook(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void returnBook(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void readerInfo(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    //借书响应函数
    protected void lend(object sender, EventArgs e)
    {
        String ISBN = bookNumber.Text;
        String card = cardNumber.Text;
        String selectSql = "SELECT * FROM book,borrowCard WHERE borrowCard.id=" + ISBN + " AND book.ISBN='" + card + "'";
        
        String insertSql = "INSERT INTO ";
        //Response.Write(selectSql);
        
        SqlHelp sqlHelper = new SqlHelp();
        int count = sqlHelper.SqlServerRecordCount(selectSql);//返回符合的结果数量
        if (count > 0)
        { 
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectSql);
            while (reader.Read())
            {
                //int a = reader.GetInt32(0);
                try
                {
                    
                }
                catch (System.InvalidCastException ee)
                {
                
                }
                reader.Close();
                SqlHelp.CloseConn();
            }
        }
        else
        {
            Response.Write("没有数据");
        }
    }
    private Boolean bookStock(String ISBN)
    {
        String selectsql = "SELECT * FROM book WHERE ISBN='" + ISBN + "'";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        try
        {
            while (reader.Read())
            {
                int inNumber = reader.GetInt16(9);
                if (inNumber > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        catch (System.InvalidCastException ee)
        {
            return false;
        }
        reader.Close();
        SqlHelp.CloseConn();
        return false;
    }

    private Boolean check(String ISBN,String card)
    {
        String selectSql = "SELECT * FROM book,borrowCard WHERE borrowCard.id=" + card + " AND book.ISBN='" + ISBN + "'";
        SqlHelp sqlHelper = new SqlHelp();
        int count = sqlHelper.SqlServerRecordCount(selectSql);//返回符合的结果数量
        if (count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private Boolean checkReader(String card)
    {
        String selectsql = "SELECT borrowCard.quantity,borrowlevel.quantity FROM borrowCard,borrowlevel WHERE borrowCard.blid=borrowlevel.id AND id=" + card;
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        try
        {
            while (reader.Read())
            {
                int a = reader.GetInt16(0);
                int b = reader.GetInt16(1);
                if (a<b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        catch (System.InvalidCastException ee)
        {
            return false;
        }
        reader.Close();
        SqlHelp.CloseConn();
        return false;
    }

}