﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>無題のページ</title>
</head>
<body>
    <form id="form1" runat="server">   
      
        <asp:Button ID="Button1" runat="server" Text="検索" onclick="Button1_Click" />&nbsp;<br />
        <asp:TextBox ID="TextBox1" runat="server"/><br />
        <asp:Label ID="Label1" runat="server" Text=""/><br /><br />
        
        <asp:Table ID="Table1" runat="server" BorderColor="#3333CC" BorderWidth="1px" GridLines="Both">
        </asp:Table>
        
       

        
    </form>
</body>
</html>
