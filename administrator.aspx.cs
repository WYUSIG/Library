using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class administrator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)     //页面第一次载入，向各下拉列表填充值
        {
            BindYear();
            BindMonth();
            BindDay();
        }   
    }
    protected void BindYear()
    {
        ddlYear.Items.Clear();    //清空年份下拉列表中项
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        //向年份下拉列表添加项
        for (int i = startYear; i <= currentYear; i++)
        { ddlYear.Items.Add(new ListItem(i.ToString())); }
        //设置年份下拉列表默认项
        ddlYear.SelectedValue = currentYear.ToString();
    }
    protected void BindMonth()
    {
        ddlMonth.Items.Clear();
        //向月份下拉列表添加项
        for (int i = 1; i <= 12; i++)
        { ddlMonth.Items.Add(i.ToString()); }
    }
    protected void BindDay()
    {
        ddlDay.Items.Clear();     //获取年、月份下拉列表选中值
        string year = ddlYear.SelectedValue;
        string month = ddlMonth.SelectedValue;
        //获取相应年、月对应的天数
        int days = DateTime.DaysInMonth(int.Parse(year),
                          int.Parse(month));
        //向日期下拉列表添加项
        for (int i = 1; i <= days; i++)
        { ddlDay.Items.Add(i.ToString()); }
    }

    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDay();
    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDay();
    }
    protected void ddlDay_SelectedIndexChanged(object sender, EventArgs e)
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
    protected void selectTicket(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        String selectsql = "SELECT reader.name,ticket.ISBN,ticket.fineMoney,ticket.fineDate FROM ticket,borrowCard,reader WHERE ticket.bcid=borrowCard.id AND borrowCard.readerid=reader.id";
        DataTable table = SqlHelp.GetDataTableValue(selectsql);
        table.Columns["name"].ColumnName = "姓名";
        table.Columns["ISBN"].ColumnName = "图书编号";
        table.Columns["fineMoney"].ColumnName = "罚款金额";
        table.Columns["fineDate"].ColumnName = "罚款起始日期";
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    protected void addReader(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 3;
    }
    protected void readerInfo(object sender, EventArgs e)
    {
        
    }
    //借书响应函数
    protected void lend(object sender, EventArgs e)
    {
        String ISBN = bookNumber.Text;
        String card = cardNumber.Text;
        Lend lend = new Lend();
        Boolean flag1 =lend.bookStock(ISBN);
        Boolean flag2=lend.checkReader(card);
        if (lend.checkborrow(ISBN, card) == false)
        {
            Response.Write("<script>alert('该用户已经借阅了该书')</script>");
        }
        else
        {
            if (flag1 == true && flag2 == true)
            {
                Boolean flag3 = lend.insertToBorrow(ISBN, card);
                if (flag3 == true)
                {
                    Response.Write("<script>alert('借阅成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('借阅失败')</script>");
                }
            }
            else
            {
                if (flag1 == false)
                {
                    Response.Write("<script>alert('ISBN错误或者该书库存不足')</script>");
                }
                if (flag2 == false)
                {
                    Response.Write("<script>alert('借阅卡号错误或者读者已达最大借阅数目')</script>");
                }
            }
        }
        
         
         
    }
    //还书响应函数
    protected void Button2_Click(object sender, EventArgs e)
    {
        String ISBN = TextBox3.Text;
        String card = TextBox4.Text;
        Due due=new Due();
        Boolean flag1 = due.check(ISBN,card);
        Boolean flag2;
        if (flag1 == true)
        {
            flag2 = due.Update(ISBN, card);
            if (flag2 == true)
            {
                Response.Write("<script>alert('归还成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('归还失败')</script>");
            }
        }
        else 
        {
            Response.Write("<script>alert('没有符合的借阅记录')</script>");
        }
            

    }
    //罚款查询响应函数  
    protected void Button1_Click(object sender, EventArgs e)
    {
        String a = TextBox1.Text;
        String selectsql = "SELECT reader.name,ticket.ISBN,ticket.fineMoney,ticket.fineDate FROM ticket,borrowCard,reader WHERE ticket.bcid=borrowCard.id AND borrowCard.readerid=reader.id AND reader.name LIKE '%%" + a + "%%' OR ticket.ISBN LIKE '%%" + a + "%%' OR ticket.fineMoney LIKE '%%" + a + "%%' OR ticket.fineDate LIKE '%%" + a + "%%'";
        if (SqlHelp.SqlServerRecordCount(selectsql) > 0)
        {
            DataTable table = SqlHelp.GetDataTableValue(selectsql);
            table.Columns["name"].ColumnName = "姓名";
            table.Columns["ISBN"].ColumnName = "图书编号";
            table.Columns["fineMoney"].ColumnName = "罚款金额";
            table.Columns["fineDate"].ColumnName = "罚款起始日期";
            GridView1.DataSource = table;
            GridView1.DataBind();
            Response.Write("<script>alert('查询成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('没有查询到符合的记录')</script>");
        }
    }
    //添加读者响应函数
    protected void Button13_Click(object sender, EventArgs e)
    {
        String name = TextBox2.Text;
        String sex = DropDownList1.SelectedValue;
        String phone = TextBox6.Text;
        String password = TextBox5.Text;
        String level = DropDownList8.SelectedValue;
        Reader reader=new Reader();
        Boolean flag0 = reader.check(name,phone);
        Boolean flag1;
        Boolean flag2;
        if (flag0 == true)
        {
            flag1 = reader.inserReader(name, sex, phone, password);
            if (flag1 == true)
            {
                
                String id = reader.returnReaderId(name, phone);
                if (id != "错误")
                {
                    flag2 = reader.inserCard(id,level);
                    if (flag2 == true)
                    {
                        String cardId=reader.returnCardId(id);
                        MultiView1.ActiveViewIndex = 4;
                        Label14.Text = id;
                        Label9.Text = name;
                        Label10.Text = sex;
                        Label11.Text = phone;
                        if(cardId!="错误")
                        {
                            Label13.Text=cardId;
                        }
                        Label20.Text = level;
                        Label12.Text = password;
                    }
                    else
                    {
                        reader.deleteReaderById(id);
                    }
                }
           
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
            }

        }
        else
        {
            Response.Write("<script>alert('该电话号码读者已经存在')</script>");
        }
    }
}