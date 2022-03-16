<%@ Page Language="VB" CodeFile="entrada.aspx.vb" Inherits="entrada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
       
        window.onload = function () {
        var urlParams = new URLSearchParams(window.location.search);
        document.querySelector('#topFrame').src = "top.aspx?i=" + urlParams.get("id")
        document.querySelector('#leftFrame').src = "menu.aspx?i=" + urlParams.get("id")
        document.querySelector('#mainFrame').src = "main.aspx?i=" + urlParams.get("id")

      
        }
    </script>
   
</head>
  <frameset rows="35,*" bordercolor="#000000" framespacing="1" border="1" >
  <frame src="" name="topFrame" scrolling="no" noresize="noresize" id="topFrame" frameborder="1">
  <frameset rows="*" cols="180,*" bordercolor="#000000"  >
  <frame src="" name="leftFrame" scrolling="yes" noresize="noresize" id="leftFrame" frameborder="0">
  <frame src="" name="mainFrame" id="mainFrame" scrolling="none" frameborder="0">
  </frameset>
</frameset>
</html>
