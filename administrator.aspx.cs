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
    //管理读者信息
    protected void alterReader(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 5;
        String selectsql = "SELECT reader.id,reader.name,reader.sex,reader.phone,borrowCard.id,borrowCard.blid,reader.password FROM borrowCard,reader WHERE  borrowCard.readerid=reader.id";
        DataTable table = SqlHelp.GetDataTableValue(selectsql);
        table.Columns["id"].ColumnName = "读者编号";
        table.Columns["name"].ColumnName = "读者姓名";
        table.Columns["sex"].ColumnName = "读者性别";
        table.Columns["phone"].ColumnName = "读者电话";
        table.Columns["id1"].ColumnName = "借阅卡号";
        table.Columns["blid"].ColumnName = "借阅等级";
        table.Columns["password"].ColumnName = "读者密码";
        //table.Columns["读者性别"].DataType = Type.GetType("System.String");
        Reader reader=new Reader();
        DataTable table1 = reader.UpdateDataTable(table);
        foreach (DataRow dr in table1.Rows)  //对特定的行添加限制条件
        {
            if (dr[2].Equals("0"))
            {
                dr[2] = "男";
            }
            else
            {
                dr[2] = "女";
            }
        }
        GridView4.DataSource = table1;
        GridView4.DataBind();
    }
    protected void addbookCatagory(object sender, EventArgs e)
    {
        
    }
    protected void alterbookCatagory(object sender, EventArgs e)
    {

    }
    protected void addBook(object sender, EventArgs e)
    {

    }
    protected void alterBook(object sender, EventArgs e)
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
        String sex;
        if (DropDownList1.SelectedValue == "男")
        {
            sex="0";
        }
        else
        {
            sex = "1";
        }
        //String sex = DropDownList1.SelectedValue;
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
                        if (sex == "0")
                        {
                            Label10.Text = "男";
                        }
                        else
                        {
                            Label10.Text = "女";
                        }
                        
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

    //管理读者查询响应函数
    protected void Button18_Click(object sender, EventArgs e)
    {
        String readerCard = TextBox18.Text;
        Reader reader = new Reader();
        String id = reader.getReaderId(readerCard);
        
        if (id != "错误")
        {
            MultiView1.ActiveViewIndex = 10;
            String selectsql = "SELECT reader.name,reader.sex,reader.phone,borrowCard.blid,reader.password,reader.id,borrowCard.id FROM borrowCard,reader WHERE  borrowCard.readerid=reader.id AND reader.id="+id;
            SqlDataReader reader1 = SqlHelp.GetDataReaderValue(selectsql);
            if (reader1.Read())
            {
                String name = reader1.GetString(0);
                int temp = reader1.GetInt32(1);
                String sex;
                if (temp == 0)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                String phone = reader1.GetString(2);
                int temp1 = reader1.GetInt32(3);
                String level = temp1.ToString();
                String password = reader1.GetString(4);
                int temp2 = reader1.GetInt32(5);
                String readerId = temp2.ToString();
                int temp3 = reader1.GetInt32(6);
                String card = temp3.ToString();
                Label22.Text = readerId;
                TextBox7.Text = name;
                this.DropDownList2.ClearSelection(); 
                DropDownList2.Items.FindByText(sex).Selected = true;
                TextBox8.Text = phone;
                Label23.Text = card;
                this.DropDownList9.ClearSelection();
                DropDownList9.Items.FindByText(level).Selected = true;
                TextBox9.Text = password;
            }
        }
        else
        {
            Response.Write("<script>alert('查询不到该读者')</script>");
        }
    }
    //删除读者
    protected void Button17_Click(object sender, EventArgs e)
    {
        Reader reader = new Reader();
        String readerId = Label22.Text;
        Boolean flag1 = reader.deleteCardByreaderId(readerId);
        Boolean flag2 = reader.deleteReaderById(readerId);
        if (flag1 == true && flag2 == true)
        {
            Response.Write("<script>alert('删除成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('删除失败')</script>");
        }
    }
    //修改读者
    protected void Button14_Click(object sender, EventArgs e)
    {
        Reader reader=new Reader();
        String name = TextBox7.Text;
        String a = DropDownList2.SelectedValue;
        String sex;
        if (a == "男")
        {
            sex = "0";
        }
        else 
        {
            sex = "1";
        }
        String readerId = Label22.Text;
        String phone = TextBox8.Text;
        String level = DropDownList9.SelectedValue;
        String password = TextBox9.Text;
        Boolean flag1=reader.update(readerId,name,sex,phone,password);
        Boolean flag2=reader.updateLevel(readerId,level);
        if (flag1 == true && flag2 == true)
        {
            Response.Write("<script>alert('修改成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败')</script>");
        }
    }
}