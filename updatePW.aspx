<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatePW.aspx.cs" Inherits="updatePW" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        #form1
        {
            text-align: center;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        &nbsp;账 号：<asp:TextBox ID="accountBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="accountBox" ErrorMessage="RequiredFieldValidator" 
            ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;旧密码：<asp:TextBox ID="oldpw" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="oldpw" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        新密码：<asp:TextBox ID="newpw" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        确认密码：<asp:TextBox ID="newpwsure" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="newpw" ControlToValidate="newpwsure" 
            ErrorMessage="CompareValidator" ForeColor="Red">两次输入的密码不一致</asp:CompareValidator>
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" onclick="change_Click" 
            style="height: 27px" Text="修改" BackColor="#3399FF" BorderStyle="Solid" 
            ForeColor="White" Height="30px" Width="120px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
    </form>
    </body>
</html>
