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
            <td>
                <div class="panel-group" id="accordion">
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseOne">
					                <img id="next1"alt="" style="width:30px; height:30px;"src="res/下一步.png" /> 借书与还书
				                </a>
			                </h4>
		                </div>
		                <div id="collapseOne" class="panel-collapse collapse in">
			                <div class="panel-body">
				                Nihil anim keffiyeh helvetica, craft beer labore wes anderson 
				                cred nesciunt sapiente ea proident. Ad vegan excepteur butcher 
				                vice lomo.
			                </div>
		                </div>
	                </div>
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseTwo">
                                    <img alt="" style="width:30px; height:30px;"src="res/下一步.png" />罚款管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseTwo" class="panel-collapse collapse">
			                <div class="panel-body">
				                Nihil anim keffiyeh helvetica, craft beer labore wes anderson 
				                cred nesciunt sapiente ea proident. Ad vegan excepteur butcher 
				                vice lomo.
			                </div>
		                </div>
	                </div>
	                <div class="panel panel-default">
		                <div class="panel-heading">
			                <h4 class="panel-title">
				                <a data-toggle="collapse" data-parent="#accordion" 
				                   href="#collapseThree">
					                <img alt="" style="width:30px; height:30px;"src="res/下一步.png" />读者信息管理
				                </a>
			                </h4>
		                </div>
		                <div id="collapseThree" class="panel-collapse collapse">
			                <div class="panel-body">
				                Nihil anim keffiyeh helvetica, craft beer labore wes anderson 
				                cred nesciunt sapiente ea proident. Ad vegan excepteur butcher 
				                vice lomo.
			                </div>
		                </div>
	                </div>
                </div>
                
            </td>
            <td>
                111</td>
        </tr>
    </table>
    
</div>
</asp:Content>

