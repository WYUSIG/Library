using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
///Lend 的摘要说明
/// </summary>
public class Lend
{
	public Lend()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    //检查该书是否还有库存
    public Boolean bookStock(String ISBN)
    {
        String selectsql = "SELECT * FROM book WHERE ISBN='" + ISBN + "'";
        //Response.Write(selectsql);
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        try
        {
            while (reader.Read())
            {
                int inNumber = reader.GetInt32(9);
                //Response.Write("inNumber="+inNumber);
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

    //检查用户是否超出最大借阅数量
    public Boolean checkReader(String card)
    {
        String selectsql = "SELECT borrowCard.quantity,borrowlevel.quantity FROM borrowCard,borrowlevel WHERE borrowCard.blid=borrowlevel.id AND borrowCard.id=" + card;
        //Response.Write("\n"+selectsql);
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        try
        {
            while (reader.Read())
            {
                int a = reader.GetInt32(0);
                int b = reader.GetInt32(1);
                //Response.Write("a="+a);
                //Response.Write("b=-"+b);
                if (a < b)
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

    public Boolean checkborrow(String ISBN, String card)
    {
        //String selectsql = String.Format("SELECT * FROM borrow WHERE ISBN='%s' AND bcid='%s' AND dueDate is NULL", ISBN, card);
        String selectsql = "SELECT * FROM borrow WHERE ISBN='"+ISBN+"' AND bcid='"+card+"' AND dueDate is NULL";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        if (reader.Read())
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public Boolean insertToBorrow(String ISBN, String card)
    {
        String date = Time.getDataTime();
        String insertsql = "INSERT INTO borrow(bcid,ISBN,borrowDate) VALUES('" + card + "','" + ISBN + "','" + date + "')";
        //Response.Write(insertsql);
        int flag = SqlHelp.ExecuteNonQueryCount(insertsql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
}