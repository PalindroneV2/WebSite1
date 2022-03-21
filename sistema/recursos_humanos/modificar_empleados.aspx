<%@ Page Language="VB" CodeFile="modificar_empleados.aspx.vb" Inherits="sistema_recursos_humanos_modificar_empleados" %>

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
            background-color: #CC3300;
        }
        .auto-style3 {
            width: 131px;
        }
        </style>
    <link href="../../css/w3/w3.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span class="auto-style1"><strong>Actualización de Empleados</strong></span><hr />
        <asp:HiddenField ID="cemp" runat="server" />
    
    </div>
        
        Introduzca un valor:
        <asp:TextBox ID="TextBox1" runat="server" BorderWidth="1px" Height="30px" Width="200px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" CssClass="w3-btn w3-teal" style="font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt" Text="Buscar" />
        <br />
        <br />
        <br />
        <br />
        
        <asp:Label ID="Label3" runat="server"></asp:Label>

        <br />
        <asp:DataGrid ID="dg1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="false">
            <AlternatingItemStyle BackColor="White" />
            <EditItemStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />

            <Columns>

                 <asp:TemplateColumn>
                    <HeaderTemplate>Opciones</HeaderTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument="MODIFICAR" ImageUrl="../../images/estandar/editar.png" CommandName="Edit" ToolTip="Modificar Registro" />
                        <asp:Label ID="id1" runat="server" Text='<%# Container.DataItem("id") %>' Visible="false"></asp:Label>
                        <asp:Label ID="estatus1" runat="server" Text='<%# Container.DataItem("estatus") %>' Visible="false"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn>
                    <HeaderTemplate>Nombre</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="nombre1" runat="server" Text='<%# Container.DataItem("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn>
                    <HeaderTemplate>Apellido Paterno</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="apepat1" runat="server" Text='<%# Container.DataItem("Apellido Paterno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn>
                    <HeaderTemplate>Apellido Materno</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="apemat1" runat="server" Text='<%# Container.DataItem("Apellido Materno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                    <asp:TemplateColumn>
                    <HeaderTemplate>Fecha de Nacimiento</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="fecha_nac1" runat="server" Text='<%# Container.DataItem("Fecha de Nacimiento") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>

        </asp:DataGrid>

        <table style="width:100%;" runat="server" visible="false" class="w3-table" id="tabla_modificar">
            <tr>
                <td class="w3-black" colspan="2">Modificación de Datos del Empleado<asp:Label ID="Label4" runat="server" CssClass="auto-style2" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td>
        <asp:TextBox ID="TextBox2" runat="server" BorderWidth="1px" Height="30px" Width="519px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido Paterno:</td>
                <td>
        <asp:TextBox ID="TextBox3" runat="server" BorderWidth="1px" Height="30px" Width="519px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido Materno:</td>
                <td>
        <asp:TextBox ID="TextBox4" runat="server" BorderWidth="1px" Height="30px" Width="519px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Fecha de Nacimiento:</td>
                <td>
        <asp:TextBox ID="TextBox5" runat="server" BorderWidth="1px" Height="30px" Width="254px" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="Button3" runat="server" CssClass="w3-btn w3-teal" style="font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt" Text="Modificar" />
                &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button4" runat="server" CssClass="w3-btn w3-red" style="font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt" Text="Eliminar" OnClientClick="return confirm(&quot;¿Esta seguro de eliminar el registro?&quot;);" />
                    <asp:Button ID="Button5" runat="server" CssClass="w3-btn w3-green" style="font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt" Text="Reactivar" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" CssClass="w3-btn w3-gray" style="font-family: verdana, Geneva, Tahoma, sans-serif; font-size: 10pt" Text="Cancelar" />
                </td>
            </tr>
        </table>

    </form>
    </body>
</html>
