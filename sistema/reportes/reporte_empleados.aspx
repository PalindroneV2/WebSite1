<%@ Page Language="VB" CodeFile="reporte_empleados.aspx.vb" Inherits="sistema_reportes_reporte_empleados" %>

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
        </style>
    <link href="../../css/w3/w3.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span class="auto-style1"><strong>Reporte de Empleados</strong></span><hr />
        <asp:HiddenField ID="cemp" runat="server" />
    
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>

        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>

        <br />
        <asp:DataGrid ID="dg1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingItemStyle BackColor="White" />
            <EditItemStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>

    </form>
    </body>
</html>
