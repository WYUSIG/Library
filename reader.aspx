<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="reader.aspx.cs" Inherits="reader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
        <table style="width:100%; border-bottom-style: solid; border-bottom-width: thin; border-bottom-color: #FFFFFF;">
            <tr >
                <td style="width:18%; border-right-style: solid; border-right-width: thin; border-right-color: #141414;" 
                    valign="top">
                    <div id="accordion" class="panel-group">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a id="menu1" data-parent="#accordion" data-toggle="collapse" 
                                        href="#collapseOne" onclick="a(this);">
                                    <img id="msg" alt="" src="res/readerMenu.png" style="width:30px; height:30px;" /> 
                                    借阅信息 </a>
                                </h4>
                            </div>
                            <div id="collapseOne" class="panel-collapse collapse ">
                                <div class="panel-body" style="margin:0 auto">
                                    <asp:Button ID="notReturn" runat="server" Class="noborderButton" 
                                         Text="未归还图书" onclick="notReturn_Click" />
                                    <br />
                                    <br />
                                    <asp:Button ID="alreadyReturn" runat="server" Class="noborderButton" 
                                         Text="已归还图书" onclick="alreadyReturn_Click" />
                                         
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
		                    <div class="panel-heading">
			                    <h4 class="panel-title">
				                    <a id="menu2" data-toggle="collapse" data-parent="#accordion" 
				                       href="#collapseTwo" onclick="a(this);">
                                        <img id="msg1" alt="" src="res/readerMenu.png" style="width:30px; height:30px;" /> 
                                        罚款信息 </a>
				                  
			                    </h4>
		                    </div>
		                    <div id="collapseTwo" class="panel-collapse collapse">
			                    <div class="panel-body" style="margin:0 auto">
                                    <asp:Button ID="ticket" runat="server" Class="noborderButton" Text="罚单信息" 
                                            onclick="ticket_Click" />
                                       
			                    </div>
		                    </div>
	                    </div>
                        <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu3" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseThree" onclick="a(this);">
					                <img id="msg2" alt="" src="res/readerMenu.png" style="width:30px; height:30px;" /> 
                                        借阅等级信息 </a>
				                
			                </h4>
		                </div>
		                <div id="collapseThree" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="level" runat="server"  Class="noborderButton"  Text="借阅等级查询" onclick="level_Click"/>

			                </div>
		                </div>
	                    </div>

                         <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu3" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseFour" onclick="a(this);">
					                <img id="Img3" alt="" src="res/readerMenu.png" style="width:30px; height:30px;" /> 
                                        个人信息 </a>
				                
			                </h4>
		                </div>
		                <div id="collapseFour" class="panel-collapse collapse">
			                <div class="panel-body">
                                <asp:Button ID="message" runat="server" Text="个人资料" Class="noborderButton" 
                                    onclick="message_Click"  />
                                
			                </div>
		                </div>
	                    </div>
                        <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a id="menu4" data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseFive" onclick="a(this);">
					                <img id="Img1" alt="" src="res/readerMenu.png" style="width:30px; height:30px;" /> 
                                        图书查询 </a>
				                
			                </h4>
		                </div>
		                <div id="collapseFive" class="panel-collapse collapse ">
			                <div class="panel-body">
                                <asp:Button ID="search" runat="server" Text="查询" Class="noborderButton" 
                                    onclick="search_Click" />
                                
			                </div>
		                </div>
	                    </div>

                    </div>
                </td>
                <td style="height:500px;">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="-1">
                                <asp:View ID="View1" runat="server">
                                    <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">  
                                            <asp:GridView ID="GridView1" runat="server" Width="100%" BackColor="White" 
                                                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                ForeColor="Black" GridLines="Vertical">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
                                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                        </div>
                                     </div>
                                </asp:View>
                                <asp:View ID="View2" runat="server">
                                    <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">
                                            <asp:GridView ID="GridView2" runat="server" Width="100%" BackColor="White" 
                                                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                ForeColor="Black" GridLines="Vertical">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
                                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>
                                </asp:View>
                                <asp:View ID="View3" runat="server" >
                                    <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">
                                            <asp:GridView ID="GridView3" runat="server" Width="100%" BackColor="White" 
                                                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                ForeColor="Black" GridLines="Vertical">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
                                            <asp:Label ID="totalFineMsg" runat="server" Text=""></asp:Label>
                                            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="100%" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                                                <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            </asp:DetailsView>
                                            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>
                                </asp:View>
                                <asp:View ID="View4" runat="server">
                                <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">
                                            <asp:GridView ID="GridView4" runat="server" Width="100%" BackColor="White" 
                                                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                ForeColor="Black" GridLines="Vertical">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </asp:View>
                                <asp:View ID="View5" runat="server">
                                <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">
                                            <asp:DetailsView ID="DetailsView2" runat="server" Height="50%" Width="50%" 
                                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" GridLines="Horizontal">
                                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                            </asp:DetailsView>
                                        </div>
                                    </div>
                                </asp:View>
                                <asp:View ID="View6" runat="server">
                                <div >
                                        <div align="center" style="width:100%; margin: 0 auto;">                                                                                                                                                                                     
                                            <asp:Label ID="tip" runat="server" Text="输入书名或ISBNS搜索"></asp:Label>
                                            <br/>
                                            <asp:TextBox ID="searchBox" runat="server"></asp:TextBox>
                                            <asp:Button ID="searchBtn" runat="server" Text="搜索" onclick="searchBtn_Click" />
                                             <br/>
                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderStyle="None" 
                                                Height="22px" RepeatDirection="Horizontal" Width="188px">
                                                <asp:ListItem>书名</asp:ListItem>
                                                <asp:ListItem>ISBN</asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:GridView ID="GridView5" runat="server" Width="100%" BackColor="White" 
                                                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                                                ForeColor="Black" GridLines="Vertical">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </asp:View>
                            </asp:MultiView>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="notReturn" EventName="Click" />
                            <asp:AsyncPostBackTrigger ControlID="alreadyReturn" EventName="Click" />
                            <asp:AsyncPostBackTrigger ControlID="ticket" EventName="Click" />
                            <asp:AsyncPostBackTrigger ControlID="level" EventName="Click" />
                             <asp:AsyncPostBackTrigger ControlID="message" EventName="Click" />
                             <asp:AsyncPostBackTrigger ControlID="search" EventName="Click" />
                             <asp:PostBackTrigger ControlID="searchBtn"/>
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>



</asp:Content>

