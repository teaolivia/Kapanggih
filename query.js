// Deklarasi
// http://stackoverflow.com/questions/18441194/how-to-call-a-c-sharp-function-from-javascript
// http://www.java2s.com/Code/ASP/Asp-Control/EmbedJavascripttoCcodetocreateapopupwindow.htm

<%@ Page Language="C#" AutoEventWireup = "true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<%@ import Namespace = "System.IO" %>
<!DOCTYPE html PUBLIC "-//"> //?

<html xmlns="http://"> //?
<head runat="server">
	<title>Select Date</title>
	<SCRIPT language=JavaScript> 
		function SetDate(dateToSet)
		{
			controlName = window.location.searc.substr(1).substring(8);

			window.opener.document.forms[0].elements[controlName].value = dateToSet;

			self.close();
		}
	</script>
</head>
<body>
	<form id="form1" runat="server">
	<div>
	<asp: >
var Doc = (document.all); // daun pada BFS/DFS
var Fol = (document.folder); // folder pada direktory
var win = window;
// Use later

 <script type="text/javascript">             //Default.aspx
       function DeleteKartItems() {     
                 $.ajax({
                 type: "POST",
                 url: 'Default.aspx/DeleteItem',
                 data: "",
                 contentType: "application/json; charset=utf-8",
                 dataType: "json",
                 success: function (msg) {
                     $("#divResult").html("success");
                 },
                 error: function (e) {
                     $("#divResult").html("Something Wrong.");
                 }
             });
         }

   [WebMethod]                                 //Default.aspx.cs
  public static void DeleteItem()
  {
     //Your Logic
  }

</script>