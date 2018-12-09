using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
///Reader 的摘要说明
/// </summary>
public class Reader
{
	public Reader()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public Boolean check(String name, String phone)
    {
        String seletesql = "SELETE * FROM reader WHERE name='" + name + "' AND phone='" + phone + "'";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(seletesql);
        if (reader.Read())
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public Boolean inserReader(String name,String sex,String phone,String password)
    {
        String insertsql = "INSERT INTO reader(name,sex,phone,password) VALUES('"+name+"',"+sex+",'"+phone+"','"+password+"')";
        int flag = SqlHelp.ExecuteNonQueryCount(insertsql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }

    public Boolean inserCard(String readerId,String level)
    {
        String insertsql = "INSERT INTO borrowCard(readerId,blid) VALUES("+readerId+","+level+")";
        int flag = SqlHelp.ExecuteNonQueryCount(insertsql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }

    public Boolean update(String id,String name, String sex, String phone, String password)
    {
        String updatesql = "UPDATE reader SET name='"+name+"' AND sex="+sex+" AND phone='"+phone+"' AND password='"+password+"' WHERE id="+id;
        int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
    public String returnReaderId(String name,String phone)
    {
        String seletesql = "SELETE * FROM reader WHERE name='" + name + "' AND phone='" + phone + "'";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(seletesql);
        if (reader.Read())
        {
            int a = reader.GetInt32(0);
            String id = a.ToString();
            return id;
        }
        else
        {
            return "错误";
        }
    }

    public String returnCardId(String readerId)
    {
        String seletesql = "SELETE * FROM borrowCard WHERE readerId="+readerId;
        SqlDataReader reader = SqlHelp.GetDataReaderValue(seletesql);
        if (reader.Read())
        {
            int a = reader.GetInt32(0);
            String id = a.ToString();
            return id;
        }
        else
        {
            return "错误";
        }
    }

    public Boolean deleteReaderById(String readerId)
    {
        String deletesql = "DELETE FROM reader WHERE id="+readerId;
        int flag = SqlHelp.ExecuteNonQueryCount(deletesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
}