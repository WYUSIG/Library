using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
public partial class administrator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)     //页面第一次载入，向各下拉列表填充值
        {
            BindYear();
            BindMonth();
            BindDay();
            BindYear1();
            BindMonth1();
            BindDay1();
            BindYear2();
            BindMonth2();
            BindDay2();
            BindYear3();
            BindMonth3();
            BindDay3();
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
    protected void BindYear1()
    {
        ddlYear1.Items.Clear();    //清空年份下拉列表中项
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        //向年份下拉列表添加项
        for (int i = startYear; i <= currentYear; i++)
        { ddlYear1.Items.Add(new ListItem(i.ToString())); }
        //设置年份下拉列表默认项
        ddlYear1.SelectedValue = currentYear.ToString();
    }
    protected void BindMonth1()
    {
        ddlMonth1.Items.Clear();
        //向月份下拉列表添加项
        for (int i = 1; i <= 12; i++)
        { ddlMonth1.Items.Add(i.ToString()); }
    }
    protected void BindDay1()
    {
        ddlDay1.Items.Clear();     //获取年、月份下拉列表选中值
        string year = ddlYear1.SelectedValue;
        string month = ddlMonth1.SelectedValue;
        //获取相应年、月对应的天数
        int days = DateTime.DaysInMonth(int.Parse(year),
                          int.Parse(month));
        //向日期下拉列表添加项
        for (int i = 1; i <= days; i++)
        { ddlDay1.Items.Add(i.ToString()); }
    }
    protected void BindYear2()
    {
        ddlYear2.Items.Clear();    //清空年份下拉列表中项
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        //向年份下拉列表添加项
        for (int i = startYear; i <= currentYear; i++)
        { ddlYear2.Items.Add(new ListItem(i.ToString())); }
        //设置年份下拉列表默认项
        ddlYear2.SelectedValue = currentYear.ToString();
    }
    protected void BindMonth2()
    {
        ddlMonth2.Items.Clear();
        //向月份下拉列表添加项
        for (int i = 1; i <= 12; i++)
        { ddlMonth2.Items.Add(i.ToString()); }
    }
    protected void BindDay2()
    {
        ddlDay2.Items.Clear();     //获取年、月份下拉列表选中值
        string year = ddlYear2.SelectedValue;
        string month = ddlMonth2.SelectedValue;
        //获取相应年、月对应的天数
        int days = DateTime.DaysInMonth(int.Parse(year),
                          int.Parse(month));
        //向日期下拉列表添加项
        for (int i = 1; i <= days; i++)
        { ddlDay2.Items.Add(i.ToString()); }
    }
    protected void BindYear3()
    {
        ddlYear3.Items.Clear();    //清空年份下拉列表中项
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        //向年份下拉列表添加项
        for (int i = startYear; i <= currentYear; i++)
        { ddlYear3.Items.Add(new ListItem(i.ToString())); }
        //设置年份下拉列表默认项
        ddlYear3.SelectedValue = currentYear.ToString();
    }
    protected void BindMonth3()
    {
        ddlMonth3.Items.Clear();
        //向月份下拉列表添加项
        for (int i = 1; i <= 12; i++)
        { ddlMonth3.Items.Add(i.ToString()); }
    }
    protected void BindDay3()
    {
        ddlDay3.Items.Clear();     //获取年、月份下拉列表选中值
        string year = ddlYear3.SelectedValue;
        string month = ddlMonth3.SelectedValue;
        //获取相应年、月对应的天数
        int days = DateTime.DaysInMonth(int.Parse(year),
                          int.Parse(month));
        //向日期下拉列表添加项
        for (int i = 1; i <= days; i++)
        { ddlDay3.Items.Add(i.ToString()); }
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
    protected void ddlYear_SelectedIndexChanged1(object sender, EventArgs e)
    {
        BindDay1();
    }
    protected void ddlMonth_SelectedIndexChanged1(object sender, EventArgs e)
    {
        BindDay1();
    }
    protected void ddlDay_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void ddlYear_SelectedIndexChanged2(object sender, EventArgs e)
    {
        BindDay2();
    }
    protected void ddlMonth_SelectedIndexChanged2(object sender, EventArgs e)
    {
        BindDay2();
    }
    protected void ddlDay_SelectedIndexChanged2(object sender, EventArgs e)
    {

    }
    protected void ddlYear_SelectedIndexChanged3(object sender, EventArgs e)
    {
        BindDay3();
    }
    protected void ddlMonth_SelectedIndexChanged3(object sender, EventArgs e)
    {
        BindDay3();
    }
    protected void ddlDay_SelectedIndexChanged3(object sender, EventArgs e)
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
    protected void addbookRoom(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 13;
    }
    protected void alterbookRoom(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 14;
        String selectsql = "SELECT * FROM bookRoom";
        DataTable table = SqlHelp.GetDataTableValue(selectsql);
        table.Columns["id"].ColumnName = "书库编号";
        table.Columns["name"].ColumnName = "书库名称";
        table.Columns["address"].ColumnName = "书库地址";
        table.Columns["phone"].ColumnName = "联系电话";
        GridView5.DataSource = table;
        GridView5.DataBind();
    }
    protected void addbookCatagory(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 6;
        BookRoom bookroom = new BookRoom();
        ArrayList name = new ArrayList();
        name = bookroom.getName();
        this.DropDownList3.DataSource = name;
        this.DropDownList3.DataBind();
    }
    protected void alterbookCatagory(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 7;
        String selectsql = "SELECT bookCatagory.id,bookCatagory.name,bookRoom.name,bookCatagory.demo FROM bookCatagory,bookRoom WHERE bookRoom.id=bookCatagory.brid";
        DataTable table = SqlHelp.GetDataTableValue(selectsql);

        table.Columns["id"].ColumnName = "类别编号";
        table.Columns["name"].ColumnName = "类别名称";
        table.Columns["name1"].ColumnName = "所属书库";
        table.Columns["demo"].ColumnName = "描述";

        GridView2.DataSource = table;
        GridView2.DataBind();
    }
    protected void addBook(object sender, EventArgs e)
    {
        BookCatagory bookCatagory = new BookCatagory();
        MultiView1.ActiveViewIndex = 8;
        ArrayList name = new ArrayList();
        name = bookCatagory.getName();
        this.DropDownList4.DataSource = name;
        this.DropDownList4.DataBind();
    }
    protected void alterBook(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 9;
        String selectsql = "SELECT book.ISBN,book.name,bookCatagory.name,book.publish,book.author,book.publishDate,book.price,book.storagedate,book.stockNumber,book.inNumber FROM book,bookCatagory WHERE bookCatagory.id=book.catagoryId";
        DataTable table = SqlHelp.GetDataTableValue(selectsql);
        table.Columns["name"].ColumnName = "图书名称";
        table.Columns["name1"].ColumnName = "类别";
        table.Columns["publish"].ColumnName = "出版社";
        table.Columns["author"].ColumnName = "作者";
        table.Columns["publishDate"].ColumnName = "出版日期";
        table.Columns["price"].ColumnName = "定价";
        table.Columns["storagedate"].ColumnName = "入库日期";
        table.Columns["stockNumber"].ColumnName = "入库数量";
        table.Columns["inNumber"].ColumnName = "库存数量";
        GridView3.DataSource = table;
        GridView3.DataBind();
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
        //reader.name,ticket.ISBN,ticket.fineMoney,ticket.fineDate
        String selectsql = "SELECT DISTINCT reader.name,ticket.ISBN,ticket.fineMoney,ticket.fineDate FROM ticket,borrowCard,reader WHERE ticket.bcid=borrowCard.id AND borrowCard.readerid=reader.id AND reader.name LIKE '%%" + a + "%%' OR ticket.ISBN LIKE '%%" + a + "%%' OR ticket.fineMoney LIKE '%%" + a + "%%' OR ticket.fineDate LIKE '%%" + a + "%%'";
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
    //添加书库响应函数
    protected void Button27_Click(object sender, EventArgs e)
    {
        BookRoom bookroom = new BookRoom();
        String name = TextBox29.Text;
        String address = TextBox31.Text;
        String phone = TextBox30.Text;
        Boolean flag1 = bookroom.check(name);
        Boolean flag2;
        if (flag1 == true)
        {
            flag2 = bookroom.insert(name, address, phone);
            if (flag2 == true)
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('该书库名已经存在')</script>");
        }
    }
    //书库查询响应函数
    protected void Button28_Click(object sender, EventArgs e)
    {
        String id = TextBox32.Text;
        MultiView1.ActiveViewIndex = 15;
        String selectsql = "SELECT * FROM bookRoom WHERE id="+id;
        Label30.Text = id;
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            while (reader.Read())
            {
                TextBox33.Text = reader.GetString(1);
                TextBox34.Text = reader.GetString(2);
                TextBox35.Text = reader.GetString(3);
            }
        }
        catch (System.InvalidCastException ee)
        {
            Response.Write("<script>alert('系统出错')</script>");
        }
    }
    //书库修改响应函数
    protected void Button29_Click(object sender, EventArgs e)
    {
        BookRoom bookroom = new BookRoom();
        String id = Label30.Text;
        String name = TextBox33.Text;
        String address = TextBox34.Text;
        String phone = TextBox35.Text;
        Boolean flag = bookroom.update(id,name,address,phone);
        if(flag==true)
        {
            Response.Write("<script>alert('修改成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败')</script>");
        }
    }
    //书库删除响应函数
    protected void Button30_Click(object sender, EventArgs e)
    {
        BookRoom bookroom = new BookRoom();
        String id = Label30.Text;
        Boolean flag = bookroom.delete(id);
        if (flag == true)
        {
            Response.Write("<script>alert('删除成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('删除失败，可能存在图书类别与之关联')</script>");
        }
    }
    //添加图书类别响应函数
    protected void Button15_Click(object sender, EventArgs e)
    {
        BookCatagory bookCatagory = new BookCatagory();
        String name = TextBox10.Text;
        String bookRoom = DropDownList3.SelectedValue;
        String demo = TextBox11.Text;
        Boolean flag = bookCatagory.insert(name, bookRoom, demo);
        if (flag == true)
        {
            Response.Write("<script>alert('添加成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败')</script>");
        }
    }
    //查询类别响应函数
    protected void Button19_Click(object sender, EventArgs e)
    {
        BookRoom bookRoom = new BookRoom();
        String id = TextBox19.Text;
        
        String selectsql = "SELECT * FROM bookCatagory WHERE id=" + id;
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            if (reader.Read())
            {
                MultiView1.ActiveViewIndex = 11;
                Label25.Text = id;
                TextBox21.Text = reader.GetString(1);
                String bookRoomId = reader.GetInt32(2).ToString();
                ArrayList name = bookRoom.getName();
                this.DropDownList10.DataSource = name;
                this.DropDownList10.DataBind();
                String bookRoomName = bookRoom.getNameById(bookRoomId);
                if (bookRoomName != "错误")
                {
                    this.DropDownList10.ClearSelection();
                    DropDownList10.Items.FindByText(bookRoomName).Selected = true;
                }
                //TextBox22.Text = reader.GetString(3);
                if (!(reader.IsDBNull(3)))
                {
                    TextBox22.Text = reader.GetString(3);
                }

            }
            else
            {
                Response.Write("<script>alert('查询失败')</script>");
            }

        }
        catch (System.InvalidCastException ee)
        {
            Response.Write("<script>alert('查询失败')</script>");
        }
    }
    //修改类别响应函数
    protected void Button21_Click(object sender, EventArgs e)
    {
        BookCatagory bookCatagory = new BookCatagory();
        String id = Label25.Text;
        String name = TextBox21.Text;
        String bookRoomName = DropDownList10.SelectedValue;
        String demo = TextBox22.Text;
        Boolean flag = bookCatagory.update(id,name,bookRoomName,demo);
        if(flag==true)
        {
            Response.Write("<script>alert('修改成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败')</script>");
        }
    }
    //删除类别响应函数
    protected void Button22_Click(object sender, EventArgs e)
    {
        BookCatagory bookCatagory = new BookCatagory();
        String id = Label25.Text;
        Boolean flag = bookCatagory.delete(id);
        if (flag == true)
        {
            Response.Write("<script>alert('删除成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('删除失败')</script>");
        }
    }
    //添加图书响应函数
    protected void Button16_Click(object sender, EventArgs e)
    {
        String ISBN = TextBox12.Text;
        String name = TextBox15.Text;
        String catagoryName = DropDownList4.SelectedValue;
        String publish = TextBox13.Text;
        String author = TextBox14.Text;
        String publishDate = ddlYear.SelectedValue + "/" + ddlMonth.SelectedValue + "/" + ddlDay.SelectedValue;
        String price = TextBox16.Text;
        String storagedate = ddlYear1.SelectedValue + "/" + ddlMonth1.SelectedValue + "/" + ddlDay1.SelectedValue;
        String stockNumber = TextBox17.Text;
        Book book = new Book();
        Boolean flag1 = book.check(ISBN);
        Boolean flag2 = book.insert(ISBN,catagoryName,name,publish,author,publishDate,price,storagedate,stockNumber);
        
        if (flag1 == true)
        {
            flag2 = book.insert(ISBN, catagoryName, name, publish, author, publishDate, price, storagedate, stockNumber);
            if (flag2 == true)
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('ISBN重复')</script>");
        }
    }
    //查询图书响应函数
    protected void Button20_Click(object sender, EventArgs e)
    {
        Book book = new Book();
        String ISBN = TextBox20.Text;
        String selectsql = "SELECT book.ISBN,book.name,bookCatagory.name,book.publish,book.author,book.publishDate,book.price,book.storagedate,book.stockNumber,book.inNumber FROM book,bookCatagory WHERE bookCatagory.id=book.catagoryId AND book.ISBN='"+ISBN+"'";
        try
        {
            SqlDataReader reader = SqlHelp.GetDataReaderValue(selectsql);
            if (reader.Read())
            {
                MultiView1.ActiveViewIndex = 12;
                ///////////////
                BookCatagory bookCatagory = new BookCatagory();
                
                ArrayList name = new ArrayList();
                name = bookCatagory.getName();
                this.DropDownList11.DataSource = name;
                this.DropDownList11.DataBind();
                ////////////////
                Label31.Text = ISBN;
                TextBox24.Text = reader.GetString(1);
                String catagoryName = reader.GetString(2);
                this.DropDownList11.ClearSelection();
                DropDownList11.Items.FindByText(catagoryName).Selected = true;
                if (!(reader.IsDBNull(3)))
                {
                    TextBox25.Text = reader.GetString(3);
                }
                if (!(reader.IsDBNull(4)))
                {
                    TextBox26.Text = reader.GetString(4);
                }
                if (!(reader.IsDBNull(5)))
                {
                    DateTime publishDate = reader.GetDateTime(5);
                    this.ddlYear2.ClearSelection();
                    ddlYear2.Items.FindByText(publishDate.Year.ToString()).Selected = true;
                    this.ddlMonth2.ClearSelection();
                    ddlMonth2.Items.FindByText(publishDate.Month.ToString()).Selected = true;
                    this.ddlDay2.ClearSelection();
                    ddlDay2.Items.FindByText(publishDate.Day.ToString()).Selected = true;
                }
                if (!(reader.IsDBNull(6)))
                {
                    TextBox27.Text = reader.GetDecimal(6).ToString();
                }
                if (!(reader.IsDBNull(7)))
                {
                    DateTime publishDate1 = reader.GetDateTime(7);
                    this.ddlYear3.ClearSelection();
                    ddlYear3.Items.FindByText(publishDate1.Year.ToString()).Selected = true;
                    this.ddlMonth3.ClearSelection();
                    ddlMonth3.Items.FindByText(publishDate1.Month.ToString()).Selected = true;
                    this.ddlDay3.ClearSelection();
                    ddlDay3.Items.FindByText(publishDate1.Day.ToString()).Selected = true;
                }
                if (!(reader.IsDBNull(8)))
                {
                    TextBox28.Text = reader.GetInt32(8).ToString();
                }
                if (!(reader.IsDBNull(9)))
                {
                    TextBox23.Text = reader.GetInt32(9).ToString();
                }
                
            }
            else
            {
                Response.Write("<script>alert('查询失败')</script>");
            }

        }
        catch (System.InvalidCastException ee)
        {
            Response.Write("<script>alert('查询失败')</script>");
        }
    }
    //修改图书响应函数
    protected void Button23_Click(object sender, EventArgs e)
    {
        String ISBN = Label31.Text;
        String name = TextBox24.Text;
        String catagoryName = DropDownList11.SelectedValue;
        String publish = TextBox25.Text;
        String author = TextBox26.Text;
        String publishDate = ddlYear2.SelectedValue + "/" + ddlMonth2.SelectedValue + "/" + ddlDay2.SelectedValue;
        String price = TextBox27.Text;
        String storagedate = ddlYear3.SelectedValue + "/" + ddlMonth3.SelectedValue + "/" + ddlDay3.SelectedValue;
        String stockNumber = TextBox28.Text;
        String inNumber = TextBox23.Text;
        Book book = new Book();
        Boolean flag = book.update(ISBN,catagoryName,name,publish,author,publishDate,price,storagedate,stockNumber,inNumber);
        if (flag == true)
        {
            Response.Write("<script>alert('修改成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败')</script>");
        }
    }
    //删除图书响应函数
    protected void Button24_Click(object sender, EventArgs e)
    {
        String ISBN = Label31.Text;
        Book book = new Book();
        Boolean flag = book.delete(ISBN);
        if (flag == true)
        {
            Response.Write("<script>alert('删除成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('删除失败')</script>");
        }
    }
}