<%@ Page Language="VB" CodeFile="menu.aspx.vb" Inherits="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="css/menu_moderno/jquery-latest.min.js"></script>
    <script src="css/menu_moderno/script.js"></script>
    <link href="css/menu_moderno/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:HiddenField ID="cemp" runat="server" />

    
        <asp:HiddenField ID="operacion" runat="server" />
    </div>
    </form>
   <script>
$(document).ready(function() {
  $("#accordian h3").click(function() {
    //Slide up all the link lists
    $("#accordian ul ul").slideUp();
    //Slide down the link list below the h3 clicked - only if it's closed
    if(!$(this).next().is(":visible")) {
      $(this).next().slideDown();
    }
  })
})
</script>
</body>
</html>
