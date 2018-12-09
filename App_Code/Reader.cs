using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
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
        String selectsql = "SELECT * FROM reader WHERE name='" + name + "' AND phone='" + phone + "'";
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
        String updatesql = "UPDATE reader SET name='"+name+"',sex="+sex+",phone='"+phone+"',password='"+password+"' WHERE id="+id;
        int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }

    public Boolean updateLevel(String readerId,String level)
    {
        String updatesql = "UPDATE borrowCard SET blid="+level+" WHERE readerId=" + readerId;
        int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
    public String returnReaderId(String name,String phone)
    {
        String selectsql = "SELECT * FROM reader WHERE name='" + name + "' AND phone='" + phone + "'";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
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
        String selectsql = "SELECT * FROM borrowCard WHERE readerId="+readerId;
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
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
    public Boolean deleteCardByreaderId(String readerId)
    {
        String deletesql = "DELETE FROM borrowCard WHERE readerId=" + readerId;
        int flag = SqlHelp.ExecuteNonQueryCount(deletesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
    public DataTable UpdateDataTable(DataTable argDataTable)
    {
        DataTable dtResult = new DataTable();
        //克隆表结构
        dtResult = argDataTable.Clone();
        foreach (DataColumn col in dtResult.Columns)
        {
            if (col.ColumnName == "读者性别")
            {
                //修改列类型
                col.DataType = Type.GetType("System.String");
            }
        }
        foreach (DataRow row in argDataTable.Rows)
        {
            DataRow newDtRow = dtResult.NewRow();
            foreach (DataColumn column in argDataTable.Columns)
            {
                if (column.ColumnName == "读者性别")
                {
                    newDtRow[column.ColumnName] = Convert.ToString(row[column.ColumnName]);
                }
                else
                {
                    newDtRow[column.ColumnName] = row[column.ColumnName];
                }
            }
            dtResult.Rows.Add(newDtRow);
        }
        return dtResult;
    }
    public String getReaderId(String readerCard)
    {
        String selectsql = "SELECT * FROM borrowCard WHERE id="+readerCard;
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        while (reader.Read())
        {
            int a = reader.GetInt32(1);
            String id = a.ToString();
            return id;
        }
        return "错误";
    }
}