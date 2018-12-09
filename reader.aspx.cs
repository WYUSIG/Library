using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class reader : System.Web.UI.Page
{
    private string readerID;
    //SqlHelp sqlhelper = new SqlHelp();
    protected void Page_Load(object sender, EventArgs e)
    {
       readerID = Request.QueryString["id"];
        //Response.Write(readerID);
      // MultiView1.ActiveViewIndex = 0;
       /*string sql = "SELECT * FROM book";
       GridView1.DataSource = SqlHelp.GetDataTableValue(sql);
       GridView1.DataBind();*/
    }
    protected void notReturn_Click(object sender, EventArgs e)
    {
       
        MultiView1.ActiveViewIndex = 0;
        //SqlHelp sqlHelper = new SqlHelp();
        string sql = "SELECT borrow.id as 借阅编号,bcid as 借阅卡号,borrowDate as 借阅日期,expireDate as 到期日期,book.name as 书名,borrow.ISBN FROM borrow,borrowCard,book WHERE borrow.bcid = borrowCard.id AND borrow.dueDate IS  NULL AND borrow.ISBN=book.ISBN AND borrowCard.readerid=" + readerID;
        int count = SqlHelp.SqlServerRecordCount(sql);
        if (count > 0)
        {
            GridView1.DataSource = SqlHelp.GetDataTableValue(sql);
            GridView1.DataBind();
        }
        else
        {
            Label1.Text = "无记录！";
        }

      
    }
    protected void alreadyReturn_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        string sql = "SELECT borrow.id as 借阅编号, bcid as 借阅卡号,borrowDate as 借阅日期,expireDate as 到期日期,dueDate as 归还日期,book.name as 书名,borrow.ISBN FROM borrow,borrowCard,book WHERE borrow.bcid = borrowCard.id AND borrow.dueDate IS NOT NULL AND borrow.ISBN=book.ISBN AND borrowCard.readerid=" + readerID;
        int count = SqlHelp.SqlServerRecordCount(sql);
        if (count > 0)
        {
            GridView2.DataSource = SqlHelp.GetDataTableValue(sql);
            GridView2.DataBind();
        }
        else
        {
            Label2.Text = "无记录！";
        }
    }

    protected void ticket_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        string sql = "SELECT ticket.id AS 罚款单编号,ticket.bcid AS 借阅证编号,book.name AS 书名,ticket.ISBN,ticket.fineMoney AS 罚款金额,ticket.fineDate AS 罚款日期 FROM ticket,borrowCard,book WHERE ticket.bcid = borrowCard.id AND book.ISBN = ticket.ISBN AND borrowCard.readerId =" + readerID;
        int count = SqlHelp.SqlServerRecordCount(sql);
        if (count > 0)
        {
            GridView3.DataSource = SqlHelp.GetDataTableValue(sql);
            GridView3.DataBind();
            string totalFine = "SELECT SUM(fineMoney) AS 总罚金 FROM ticket GROUP BY bcid HAVING bcid = (SELECT id FROM borrowCard WHERE readerId = " + readerID + " )";
            DetailsView1.DataSource = SqlHelp.GetDataTableValue(totalFine);
            DetailsView1.DataBind();
        }
        else
        {
            Label3.Text = "无记录！";
        }
        

    }
    protected void level_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 3;
        string sql = "SELECT id AS 借阅等级,quantity AS 借阅数量上限,days AS 借阅天数,fine AS 日罚金,demo AS 说明 FROM borrowLevel";
        GridView4.DataSource = SqlHelp.GetDataTableValue(sql);
        GridView4.DataBind();
    }
    protected void message_Click(object sender, EventArgs e)
    {
       
        MultiView1.ActiveViewIndex = 4;
        DataTable dt = new DataTable();
        DataTable dtnew = new DataTable();
        dtnew.Columns.Add("账号", Type.GetType("System.String"));
        dtnew.Columns.Add("姓名", Type.GetType("System.String"));
        dtnew.Columns.Add("性别", Type.GetType("System.String"));
        dtnew.Columns.Add("电话", Type.GetType("System.String"));
        dtnew.Columns.Add("借阅证号", Type.GetType("System.String"));
        dtnew.Columns.Add("已借阅数量", Type.GetType("System.String"));
        dtnew.Columns.Add("借阅等级", Type.GetType("System.String"));
        DataRow row = dtnew.NewRow();
        string sql = "SELECT reader.id AS 账号,reader.name AS 姓名,reader.sex AS 性别,reader.phone AS 电话, borrowCard.id AS 借阅证号,borrowCard.quantity AS 已借阅数量,borrowCard.blid AS 借阅等级 FROM reader,borrowCard WHERE reader.id = borrowCard.readerId AND reader.id =" + readerID;
        dt = SqlHelp.GetDataTableValue(sql);
        row[0] = dt.Rows[0][0].ToString();
        row[1] = dt.Rows[0][1].ToString();


        if (dt.Rows[0][2].ToString()=="0")
        {
            row[2] = "男";
        }
        else 
        {
            row[2] = "女";
        }
        row[3] = dt.Rows[0][3].ToString();
        row[4] = dt.Rows[0][4].ToString();
        row[5] = dt.Rows[0][5].ToString();
        row[6] = dt.Rows[0][6].ToString();
        dtnew.Rows.Add(row);
        DetailsView2.DataSource = dtnew;
        DetailsView2.DataBind();
    }
    protected void search_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 5;
    }
    protected void searchBtn_Click(object sender, EventArgs e)
    {
        string sql;
        string searchmsg = searchBox.Text;
        if (RadioButtonList1.SelectedValue == "书名")
        {

            sql = "SELECT book.name AS 书名,ISBN,author AS 作者,publish AS 出版社,publishDate AS 出版日期,book.catagoryId AS 图书分类编号,bookCatagory.name AS 图书分类名称,price AS 价格,inNumber AS 库存 FROM book,bookCatagory WHERE book.catagoryId=bookCatagory.id AND book.name LIKE '%%"+searchmsg+"%%'";
        }
        else
        {
            sql = "SELECT book.name AS 书名,ISBN,author AS 作者,publish AS 出版社,publishDate AS 出版日期,book.catagoryId AS 图书分类编号,bookCatagory.name AS 图书分类名称,price AS 价格,inNumber AS 库存 FROM book,bookCatagory WHERE book.catagoryId=bookCatagory.id AND book.ISBN='"+searchmsg+"'";
        }
        GridView5.DataSource = SqlHelp.GetDataTableValue(sql);
        GridView5.DataBind();
    }
    
}