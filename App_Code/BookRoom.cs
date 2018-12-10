using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
/// <summary>
///BookRoom 的摘要说明
/// </summary>
public class BookRoom
{
	public BookRoom()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public Boolean check(String name)
    {
        String selectsql = "SELECT * FROM bookRoom WHERE name='"+name+"'";
        try
        {
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
        catch (System.InvalidCastException e)
        {
            return false;
        }
    }
    public Boolean insert(String name,String address,String phone)
    {
        String insertsql = "INSERT INTO bookRoom(name,address,phone) VALUES('"+name+"','"+address+"','"+phone+"')";
        try
        { 
            int flag = SqlHelp.ExecuteNonQueryCount(insertsql);
            if (flag > 0)
            {
                return true;
            }
            return false;
        }
        catch (System.InvalidCastException e)
        {
            return false;
        }
    }
    public Boolean update(String id,String name, String address, String phone)
    {
        String updatesql = "UPDATE bookRoom SET name='"+name+"',address='"+address+"',phone='"+phone+"' WHERE id="+id;
        try
        {
            int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
            if (flag > 0)
            {
                return true;
            }
            return false;
        }
        catch (System.InvalidCastException e)
        {
            return false;
        }
    }
    public Boolean delete(String id)
    {
        String deletesql = "DELETE FROM bookRoom WHERE id="+id;
        try
        {
            int flag = SqlHelp.ExecuteNonQueryCount(deletesql);
            if (flag > 0)
            {
                return true;
            }
            return false;
        }
        catch (System.InvalidCastException e)
        {
            return false;
        }
    }
    public String getIdByName(String name)
    {
        String selectsql = "SELECT id FROM bookRoom WHERE name='"+name+"'";
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            if (reader.Read())
            {
                String id = reader.GetInt32(0).ToString();
                return id;
            }
            else
            {
                return "错误";
            }
        }
        catch (System.InvalidCastException e)
        {
            return "错误";
        }
    }
    public ArrayList getName()
    {
        String selectsql = "SELECT name FROM bookRoom";
        ArrayList name = new ArrayList();
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            while (reader.Read())
            {
                name.Add(reader.GetString(0));
            }
            return name;
        }
        catch (System.InvalidCastException e)
        {
            return name;
        }
    }

    public String getNameById(String id)
    {
        String selectsql = "SELECT name FROM bookRoom WHERE id=" + id;
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            if (reader.Read())
            {
                String name = reader.GetString(0);
                return name;
            }
            return "错误";
        }
        catch (System.InvalidCastException e)
        {
            return "错误";
        }
    }
}