<%@ Page Language="VB"  CodeFile="top.aspx.vb" Inherits="top" %>

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
            width: 27px;
        }
        .auto-style3 {
            width: 661px;
        }
    </style>
       

  </head>
<body style="margin-top:0px; margin-left:0px; margin-right:0px;" >
    <form id="form1" runat="server">
          
      <div>
          <table style="width:100%;">
              <tr>
                  <td class="auto-style2" style="width:5%;">
                      <img src="" runat="server" id="foto" style="width:30px;height:30px;" />
                  </td>
                  <td class="auto-style3" style="width:80%;">
                      <asp:Label ID="Label1" runat="server" CssClass="auto-style1"></asp:Label>
                  </td>
                  <td style="width:15%;">

                      <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/boton_salir.png" />

                  </td>
              </tr>
          </table>  
          
        </div>
        <asp:HiddenField ID="id_empleado" runat="server" />
    </form>
  
              
  
</body>
</html>
