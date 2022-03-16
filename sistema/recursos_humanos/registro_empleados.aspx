<%@ Page Language="VB" CodeFile="registro_empleados.aspx.vb" Inherits="sistema_recursos_humanos_registro_empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: verdana, Geneva, Tahoma, sans-serif;
            font-size: 10pt;
        }
        .auto-style2 {
            width: 196px;
        }
    </style>
    <link href="../../css/w3/w3.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span class="auto-style1"><strong>Registro de Empleados</strong></span><hr />
        <asp:HiddenField ID="cemp" runat="server" />
    
    </div>
        <center>
        <div class="w3-container w3-card-4" style="width:50%;">
    <table style="width:100%; font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt;" class="w3-table w3-striped">
        <tr>
            <td colspan="2" class="w3-teal">Favor de introducir la siguiente información</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width:30%">Nombre:</td>
            <td style="width: 70%">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="w3-input w3-round-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 30%">Apellido Paterno:</td>
            <td style="width: 70%">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="w3-input w3-round-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 30%">Apellido Materno:</td>
            <td style="width: 70%">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="w3-input w3-round-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 30%">Fecha de Nacimiento:</td>
            <td style="width: 70%">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="w3-input w3-round-large" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="auto-style2" style="width: 30%">
                <asp:Button ID="Button1" runat="server" CssClass="auto-style1 w3-button w3-black w3-round-large" Text="Registrar" />
            </td>
            <td style="width: 70%">&nbsp;</td>
        </tr>
    </table>
            </div>
            </center>
    </form>
    </body>
</html>
