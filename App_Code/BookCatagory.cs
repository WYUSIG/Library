using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
///BookCatagory 的摘要说明
/// </summary>
public class BookCatagory
{
	public BookCatagory()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public Boolean check(String name)
    {
        String selectsql = "SELECT * FROM bookCatagory WHERE name='" + name + "'";
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
    public Boolean insert(String name, String roomName, String demo)
    {
        BookRoom bookRoom = new BookRoom();
        String roomId = bookRoom.getIdByName(roomName);
        if (roomId != "错误")
        {
            String insertsql = "INSERT INTO bookCatagory(name,brid,demo) VALUES('"+name+"',"+roomId+",'"+demo+"')";
            try
            {
                int flag = SqlHelp.ExecuteNonQueryCount(insertsql);
                if (flag > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.InvalidCastException e)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public Boolean update(String id,String name, String roomName, String demo)
    {
        BookRoom bookRoom = new BookRoom();
        String roomId = bookRoom.getIdByName(roomName);
        if (roomId != "错误")
        {
            String updatesql = "UPDATE bookCatagory SET name='"+name+"',brid="+roomId+",demo='"+demo+"' WHERE id="+id;
            try
            {
                int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
                if (flag > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.InvalidCastException e)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public Boolean delete(String id)
    {
        String deletesql = "DELETE FROM bookCatagory WHERE id="+id;
        try
        {
            int flag = SqlHelp.ExecuteNonQueryCount(deletesql);
            if (flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (System.InvalidCastException e)
        {
            return false;
        }
    }

    public String getIdByName(String name)
    {
        String selectsql = "SELECT id FROM bookCatagory WHERE name='"+name+"'";
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
}