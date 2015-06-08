<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ page import="java.sql.*"%>
<%@ page import="java.io.*"%>
<%@ page import="java.util.*" %>
<%@ page import="test.Obiekt" %>
<%@ page import="test.ListaObiektow" %>
<%@ page import="test.Termin" %>
<%@ page import="test.ListaTerminow" %>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>menu główne</title>

    <meta name="viewport" content="initial-scale=1, maximum-scale=1">

    
    <meta name="android-mobile-web-app-capable" content="yes">
    <meta name="android-mobile-web-app-status-bar-style" content="black">

   <link href="css/ratchet.css" rel="stylesheet">
    <link href="css/ratchet-theme-android.css" rel="stylesheet">

   
    <script src="js/ratchet.js"></script>
    
  </head>
  <body>
  </br>
  </br>
  </br>
<header class="bar bar-nav">
  <a class="icon icon-left-nav pull-left" href="wyszukaj.jsp"></a>
  <h1 class="title">Wybierz obiekt</h1>
</header> 

<div id="content">
   <%
List<Obiekt> list = new ListaObiektow().getObiekty();
%>
<select name="obiekt">
		<option selected value="default">Wybierz Obiekt</option>
		<%
			for (Obiekt obiekt : list) {
		%>
		<option value="<%=obiekt.idObiekt %>"><%=obiekt.nazwa%> <%=obiekt.adres %></option>
		<%
			}
		%>
</select>     
<br>
<br>
<br>
<input type="text" name="uczest"/>

<%List<Termin> lista = new ListaTerminow().getTerminy(); %>
<div class="tabelawybor">
<table class ="center">

	<tr>
	<td>Nazwa obiektu:</td>
	<td>Data:</td>
	<td>Godzina</br> rozpoczęcia:</td>
	<td>Godzina</br> zakończenia:</td>
	<td> </td>
	</tr>
	<%for (Termin termin : lista) {%>
	<tr>
	<td>Sprawdzamy czy coś się nie zepsuło</td>
	<td><%=termin.nazwaObiektu %> <%=termin.adresObiektu %> </td>
	<td><%=termin.dzien %> </td>
	<td><%=termin.odKtorej %> </td>
	<td><%=termin.doKtorej %> </td>
	<td><button class="btn btn-primary">Zarezerwuj</button></td>
	</tr>
	<% } %>
</table>
</div>
</div>
<button class="btn btn-block">Dalej<span class="icon icon-right"></span></button>

  </body>
</html>

