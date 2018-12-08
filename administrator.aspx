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
                                <asp:Button ID="Button4" Class="noborderButton" runat="server" Text="查看罚款" />
                                <asp:Button ID="Button6" Class="noborderButton" runat="server" Text="撤销罚款" />
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
                                <asp:Button ID="Button7" Class="noborderButton" runat="server" Text="录入读者信息" />
                                <asp:Button ID="Button8" runat="server" Text="查看读者信息" />

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
                                    <asp:Button ID="Button1" Class="commandButton" runat="server" Text="借   出" Onclick="lend"/>
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
                                        <asp:Button ID="Button2" Class="commandButton" runat="server" Text="还   回" />
                                  </div>
                            </div> 
                        </asp:View>     
                        <asp:View ID="View3" runat="server">  
                        this is the third page  
                        </asp:View>                 
                    </asp:MultiView>  
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" /> 
                        <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />         
                        <asp:AsyncPostBackTrigger ControlID="Button5" EventName="Click" />  
                        <asp:AsyncPostBackTrigger ControlID="Button6" EventName="Click" />   
                        <asp:AsyncPostBackTrigger ControlID="Button7" EventName="Click" />  
                        <asp:AsyncPostBackTrigger ControlID="Button8" EventName="Click" />   
                    </Triggers>
               </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    
</div>
</asp:Content>

