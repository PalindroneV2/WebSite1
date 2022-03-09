<%@ Page Language="VB" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 154px;
        }
        .auto-style2 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
            font-size: 12pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <table class="auto-style2" style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>Sistema Empresarial v1<br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Usuario:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">Clave:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Entrar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
