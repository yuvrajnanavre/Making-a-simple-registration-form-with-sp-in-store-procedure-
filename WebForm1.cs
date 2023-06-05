<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SP1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 779px;
        }
        .style2
        {
            color: #0000FF;
            text-align: center;
            font-size: x-large;
            font-family: "Arial Black";
        }
        .style3
        {
            color: #000066;
            width: 388px;
        }
        .style4
        {
            height: 17px;
            width: 389px;
        }
        .style8
        {
            width: 389px;
            margin-left: 40px;
        }
        .style9
        {
            width: 388px;
        }
        .style10
        {
            color: #FF0000;
        }
        .style11
        {
            color: #000066;
            width: 388px;
            height: 26px;
        }
        .style12
        {
            width: 389px;
            margin-left: 40px;
            height: 26px;
        }
    </style>
</head>
<body bgcolor="#00ffcc">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2" colspan="2">
                    <p>
                        <strong style="text-align: left">Registration Form</strong></p>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <strong>First Name<span class="style10">*</span> :</strong></td>
                <td class="style8">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="style11">
                    <strong>Last Name<span class="style10">*</span> :</strong></td>
                <td class="style12">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <strong>Email<span class="style10"> *</span> :</strong></td>
                <td class="style8">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <strong>Phone <span class="style10">*</span> :</strong></td>
                <td class="style8">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <strong>Username<span class="style10">*</span> :</strong></td>
                <td class="style8">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <strong>Password<span class="style10">*</span> :</strong></td>
                <td class="style4">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <span class="style10">(*</span> is a mandetory field.)</td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="#FF3399" Font-Bold="True" 
                        Text="Submit" onclick="Button1_Click" />
                    &nbsp;<br />
                </td>
            </tr>
        </table>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="----" Font-Bold="True" 
        Font-Size="Medium"></asp:Label>
    </form>
</body>
</html>
