<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZhuCe.aspx.cs" Inherits="SanCeng.ZhuCe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            姓名：<asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        </div>
        <div>
            年龄：<asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
        </div>
        <div>
            性别：<asp:TextBox ID="txt_gender" runat="server"></asp:TextBox>
        </div>
        <div>
            电话：<asp:TextBox ID="txt_mobiel" runat="server"></asp:TextBox>
        </div>
        <div>
            密码：<asp:TextBox ID="txt_pwd" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="注册" />
        </div>
    </form>
</body>
</html>
