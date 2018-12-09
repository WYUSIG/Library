using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
///Due 的摘要说明
/// </summary>
public class Due
{
	public Due()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    //检查读者是否真的借了该书
    public Boolean check(String ISBN,String card)
    {
        String selectsql = "SELECT * FROM borrow WHERE ISBN='"+ISBN+"' AND bcid='"+card+"' AND dueDate is NULL";
        SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
        if (reader.Read())
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    //还书
    public Boolean Update(String ISBN, String card)
    {
        String date = Time.getDataTime();
        String updatesql = "UPDATE borrow SET dueDate='" + date + "' WHERE ISBN='" + ISBN + "' AND bcid='" + card + "'";
        int flag = SqlHelp.ExecuteNonQueryCount(updatesql);
        if (flag > 0)
        {
            return true;
        }
        return false;
    }
}