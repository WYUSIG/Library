<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="administrator.aspx.cs" Inherits="administrator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .styleTable
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
    <table class="styleTable">
        <tr>
            <td style="width:18%" valign="top">
                <div class="panel-group" id="accordion">
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu1" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseOne" onclick="a(this);">
					                <img id="next1" alt="" style="width:30px; height:30px;" src="res/向下.png" /> 借书与还书
				                </a>
			                </h4>
		                </div>
		                <div id="collapseOne" class="panel-collapse collapse in">
			                <div class="panel-body" style="margin:0 auto">
				                <asp:Button ID="Button3" Class="noborderButton" runat="server" Text="借   书" OnClick="lendBook"/><br /><br />
                                <asp:Button ID="Button5" Class="noborderButton" runat="server" Text="还   书" OnClick="returnBook"/>
			                </div>
		                </div>
	                </div>
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu2" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseTwo" onclick="a(this);">
                                    <img id="next2" alt="" style="width:30px; height:30px;"src="res/下一步.png" /> 罚款管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseTwo" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="Button4" Class="noborderButton" runat="server" Text="罚款查看" onclick="selectTicket"/>
                                
			                </div>
		                </div>
	                </div>
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu3" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseThree" onclick="a(this);">
					                <img id="next3" alt="" style="width:30px; height:30px;" src="res/下一步.png" /> 读者信息管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseThree" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="Button7" Class="noborderButton" runat="server" Text="添加读者" onclick="addReader"/><br /><br />
                                <asp:Button ID="Button8" Class="noborderButton" runat="server" Text="管理读者信息" onclick="alterReader"/>

			                </div>
		                </div>
	                </div>
                    <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="A1" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseFour" onclick="a(this);">
					                <img id="Img1" alt="" style="width:30px; height:30px;" src="res/下一步.png" /> 图书类别管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseFour" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="Button6" Class="noborderButton" runat="server" Text="添加图书类别" onclick="addbookCatagory"/><br /><br />
                                <asp:Button ID="Button10" Class="noborderButton" runat="server" Text="修改图书类别" onclick="alterbookCatagory"/>

			                </div>
		                </div>
	                </div>
                    <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="A2" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseFive" onclick="a(this);">
					                <img id="Img2" alt="" style="width:30px; height:30px;" src="res/下一步.png" /> 图书信息管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseFive" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="Button11" Class="noborderButton" runat="server" Text="录入图书" onclick="addBook"/><br /><br />
                                <asp:Button ID="Button12" Class="noborderButton" runat="server" Text="修改图书" onclick="alterBook"/>

			                </div>
		                </div>
	                </div>
                </div>
                
            </td>
            <td style="height:500px;">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex = "-1">  
                        <asp:View ID="View1" runat="server">  
                          <div style="border:1px solid red;">
                              <div style="width:40%; margin: 0 auto;" align="center">
                                    <img alt="" src="res/借书.png" style="width:150px; height:150px;"/><br />
                                    <br />
                                    <br />
                                    <asp:Label ID="Label1" runat="server" Text="图书编号："></asp:Label><asp:TextBox ID="bookNumber" runat="server"></asp:TextBox><br />
                                    <br />
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Text="借阅卡号："></asp:Label><asp:TextBox ID="cardNumber" runat="server"></asp:TextBox><br />
                                    <br />
                                    <br />
                                    <asp:Button ID="Button9" Class="commandButton" runat="server" Text="借   出" onclick="lend"/>
                                    <br />
                                    <br />
                                  <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                              </div>
                          </div>
                        </asp:View>  
                        <asp:View ID="View2" runat="server">  
                            <div style="border:1px solid red;">
                                  <div style="width:40%; margin: 0 auto;" align="center">
                                        <img alt="" src="res/还书.png" style="width:150px; height:150px;"/><br />
                                        <br />
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text="图书编号："></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                                        <br />
                                        <br />
                                        <asp:Label ID="Label4" runat="server" Text="借阅卡号："></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                                        <br />
                                        <br />
                                        <asp:Button ID="Button2" Class="commandButton" runat="server" Text="还   回" 
                                            onclick="Button2_Click" />
                                  </div>
                            </div> 
                        </asp:View>     
                        <asp:View ID="View3" runat="server">  
                             <div style="border:1px solid red;" >
                                  <div style="color:#FFFFFF; background-color:#483D8B; padding:10px;">
                                    &nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="罚款管理"></asp:Label>
                                  </div>
                                  <div style="width:40%; margin: 2px auto;" align="center">
                                      <br /><br /><br />
                                      <asp:TextBox ID="TextBox1" runat="server" style="width:50%"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                      <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" />
                                      <br />
                                      <br />
                                      <asp:GridView ID="GridView1" runat="server" >
                                          <EmptyDataRowStyle BorderStyle="Solid" />
                                          <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" 
                                              Wrap="True" />
                                      </asp:GridView>
                                      <br />
                                      <br />
                                      <br />
                                  </div>
                            </div> 
                        </asp:View>       
                        <asp:View ID="View4" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label7" runat="server" Text="添 加 读 者 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        请输入读者姓名:&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        请选择读者性别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                                                 <asp:ListItem Selected="True">男</asp:ListItem>
                                                 <asp:ListItem>女</asp:ListItem>
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        请输入电话号码:&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        请选择读者借阅级别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList8" runat="server">
                                                 <asp:ListItem Selected="True">1</asp:ListItem>
                                                 <asp:ListItem>2</asp:ListItem>
                                                 <asp:ListItem>3</asp:ListItem>
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        请输入密码:&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button13" runat="server" Text="添  加" onclick="Button13_Click" />
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>
                        <asp:View ID="View5" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label8" runat="server" Text="读 者 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             添加成功！读者的借阅卡号为：<asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者姓名:&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者性别:&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                                                 
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者电话号码:&nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                                        </div>    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者借阅卡号:&nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者借阅级别:&nbsp;&nbsp;<asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者密码:&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                                        </div>  
                                     </td>
                                 </tr>
                                 
                             </table>
                        </asp:View>   
                        <asp:View ID="View6" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label15" runat="server" Text="修 改 读 者 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                         <asp:GridView ID="GridView4" runat="server">
                                            
                                         </asp:GridView>
                                     </div>
                                    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             读者借阅卡号：<asp:TextBox ID="TextBox18" runat="server" Style="width:40%"></asp:TextBox>
                                             <br />
                                             <br />
                                             <br />
                                             <asp:Button ID="Button18" runat="server" Text="查  询" onclick="Button18_Click" />
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 
                             </table>
                        </asp:View> 
                        <asp:View ID="View7" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label16" runat="server" Text="添 加 图 书 类 别" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书类别名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请选择所属书库:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书类别描述:&nbsp;&nbsp;<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button15" runat="server" Text="添  加"/>
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>
                        <asp:View ID="View8" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label17" runat="server" Text="修 改 图 书 类 别" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                         <asp:GridView ID="GridView2" runat="server">
                                            
                                         </asp:GridView>
                                         <br />
                                         <br />
                                     </div>
                                         
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             编号：&nbsp;&nbsp;<asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                                             <br />
                                             <br />
                                             <asp:Button ID="Button19" runat="server" Text="查  询" />
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 
                             </table>
                        </asp:View>  
                        <asp:View ID="View9" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label18" runat="server" Text="添 加 图 书" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书ISBN:&nbsp;&nbsp;<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请选择所属图书类别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList4" runat="server">
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书出版社名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入作者名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                            请输入出版日期:&nbsp;&nbsp;<asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlYear_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            年<asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlMonth_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            月<asp:DropDownList ID="ddlDay" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlDay_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            日</div>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入图书定价:&nbsp;&nbsp;<asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                            请输入入库时间:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlYear_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            年<asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlMonth_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            月<asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlDay_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        请输入入库数量:&nbsp;&nbsp;<asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button16" runat="server" Text="添  加" onclick="Button13_Click" />
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>   
                        <asp:View ID="View10" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label19" runat="server" Text="修 改 图 书 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                         <asp:GridView ID="GridView3" runat="server">
                                            
                                         </asp:GridView>
                                         <br />
                                         <br />
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             ISBN：&nbsp;&nbsp;<asp:TextBox ID="TextBox20" runat="server" Style="width:40%"></asp:TextBox>
                                             <br />
                                             <br />
                                             <asp:Button ID="Button20" runat="server" Text="查  询" />
                                         </div>
                                         
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>      
                        <asp:View ID="View11" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label21" runat="server" Text="修 改 读 者 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者编号:&nbsp;&nbsp;<asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者姓名:&nbsp;&nbsp;<asp:TextBox ID="TextBox7" runat="server" ></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        读者性别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
                                                 <asp:ListItem>男</asp:ListItem>
                                                 <asp:ListItem>女</asp:ListItem>
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        电话号码:&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        借阅卡号:&nbsp;&nbsp;<asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        借阅级别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList9" runat="server">
                                                 <asp:ListItem>1</asp:ListItem>
                                                 <asp:ListItem>2</asp:ListItem>
                                                 <asp:ListItem>3</asp:ListItem>
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        密码:&nbsp;&nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button14" runat="server" Text="修  改" onclick="Button14_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                                 ID="Button17" runat="server" Text="删  除" onclick="Button17_Click" />
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>
                        <asp:View ID="View12" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label24" runat="server" Text="修 改 类 别 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        类别编号:&nbsp;&nbsp;<asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        类别名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox21" runat="server" ></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        所属书库:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList10" runat="server">
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 600px; padding:20px;">
                                        描述:&nbsp;&nbsp;<asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button21" runat="server" Text="修  改" onclick="Button14_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                                 ID="Button22" runat="server" Text="删  除" onclick="Button17_Click" />
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>  
                        <asp:View ID="View13" runat="server">  
                             <table class="styleTable" border="1">
                                 <tr>
                                     <td>
                                         <div style="color:#FFFFFF; background-color:#483D8B; text-align:center; padding:20px;">
                                             <asp:Label ID="Label26" runat="server" Text="修 改 图 书 信 息" Style="font-weight:bold;"></asp:Label>
                                         </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        图书ISBN:&nbsp;&nbsp;<asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                     <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        图书名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                                     </div>
                                         
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        所属图书类别:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList11" runat="server">
                                             </asp:DropDownList>
                                          </div>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                        <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        图书出版社名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                                        </div>    
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        作者名称:&nbsp;&nbsp;<asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                            出版日期:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList12" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlYear_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            年<asp:DropDownList ID="DropDownList13" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlMonth_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            月<asp:DropDownList ID="DropDownList14" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlDay_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            日</div>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        图书定价:&nbsp;&nbsp;<asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                            入库时间:&nbsp;&nbsp;<asp:DropDownList ID="DropDownList15" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlYear_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            年<asp:DropDownList ID="DropDownList16" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlMonth_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            月<asp:DropDownList ID="DropDownList17" runat="server" AutoPostBack="True" 
                                                onselectedindexchanged="ddlDay_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="margin:0px 0px 0px 400px; padding:20px;">
                                        入库数量:&nbsp;&nbsp;<asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                                        </div>  
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <div style="text-align:center; padding:20px;">
                                             <asp:Button ID="Button23" runat="server" Text="修  改" onclick="Button14_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                                 ID="Button24" runat="server" Text="删  除" onclick="Button17_Click" />
                                        </div>  
                                     </td>
                                 </tr>
                             </table>
                        </asp:View>              
                    </asp:MultiView>  
                    </ContentTemplate>
                    <Triggers>
                        
                        <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" /> 
                        <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />         
                        <asp:AsyncPostBackTrigger ControlID="Button5" EventName="Click" />  
                        <asp:AsyncPostBackTrigger ControlID="Button7" EventName="Click" />  
                        <asp:AsyncPostBackTrigger ControlID="Button8" EventName="Click" />   
                        <asp:PostBackTrigger ControlID="Button9"/> 
                        <asp:PostBackTrigger ControlID="Button2"/> 
                        <asp:PostBackTrigger ControlID="Button1"/>
                        <asp:PostBackTrigger ControlID="Button13"/>   
                        <asp:PostBackTrigger ControlID="Button14"/>
                        <asp:PostBackTrigger ControlID="Button17"/>
                        <asp:PostBackTrigger ControlID="Button18"/>
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    
</div>
</asp:Content>

