﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
///Book 的摘要说明
/// </summary>
public class Book
{
	public Book()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public Boolean check(String ISBN)
    {
        String selectsql = "SELECT * FROM book WHERE ISBN='"+ISBN+"'";
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

    public Boolean insert(String ISBN, String catagoryName, String name, String publish, String author, String publishDate, String price, String storagedate, String stockNumber)
    {
        BookCatagory bookCatagory = new BookCatagory();
        String catagoryId = bookCatagory.getIdByName(catagoryName);
        if (catagoryId != "错误")
        {
            String insertsql = "INSERT INTO book(ISBN,catagoryId,name,publish,author,publishDate,price,storagedate,stockNumber,inNumber) VALUES('" + ISBN + "'," + catagoryId + ",'" + name + "','" + publish + "','" + author + "','" + publishDate + "'," + price + ",'" + storagedate + "'," + stockNumber + ","+stockNumber+")";
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
    public Boolean update(String ISBN, String catagoryName, String name, String publish, String author, String publishDate, String price, String storagedate, String stockNumber, String inNumber)
    {
        BookCatagory bookCatagory = new BookCatagory();
        String catagoryId = bookCatagory.getIdByName(catagoryName);
        if (catagoryId != "错误")
        {
            String updatesql = "UPDATE book SET catagoryId="+catagoryId+",name='"+name+"',publish='"+publish+"',author='"+author+"',publishDate='"+publishDate+"',price="+price+",storagedate='"+storagedate+"',stockNumber="+stockNumber+",inNumber="+inNumber+" WHERE ISBN='"+ISBN+"'";
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
    public Boolean delete(String ISBN)
    {
        String deletesql = "DELETE FROM book WHERE ISBN='"+ISBN+"'";
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
}