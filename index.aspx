<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="css/text">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label runat="server" Text="图 书 管 理 系 统" Font-Names="微软雅黑" Font-Size="30px"></asp:Label><br />
        <br />
        <asp:Image runat="server"  ImageUrl="res/图书馆.png"/><br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;账号：<asp:TextBox ID="account" runat="server" BorderStyle="Solid"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="account" 
            ForeColor="Red">*账号不能为空</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;密码：<asp:TextBox ID="password" runat="server" BorderStyle="Solid"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="password" 
            ForeColor="Red">*密码不能空</asp:RequiredFieldValidator>&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem>用户</asp:ListItem>
            <asp:ListItem>管理员</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="登录" BorderColor="White" 
            Width="61px" onclick="Button1_Click" /><br />
            <br />
            <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
