<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@ page import="java.io.*"%>
<%@ page import="java.util.*"%>
<%@ page import="test.Obiekt"%>
<%@ page import="test.ListaObiektow"%>
<%@ page import="test.Termin"%>
<%@ page import="test.ListaTerminow"%>
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
<script type="text/javascript">
function Refresh(idObiekt){
	location.href="pilkaNozna.jsp?idObiekt=" + idObiekt; 
	}
</script>
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
		<div class="tabelawybor">

			<b>Wybierz obiekt:</b>
			<%
				ArrayList<Obiekt> list = new ListaObiektow().getObiekty();
			%>
			<form>
				<select name="obiekt" onChange="Refresh(this.value)">
					<option value="0" selected>Wybierz Obiekt</option>
					<%
					String selectedObiekt = request.getParameter("idObiekt");
					int counter=0;
					for (Obiekt obiekt : list) {
						if(selectedObiekt == null && counter==0)
						{
							selectedObiekt = Integer.toString(obiekt.idObiekt);
						}
								
				%>
					<option value="<%=obiekt.idObiekt%>"
						<%= ((Integer.toString(obiekt.idObiekt)).equals(selectedObiekt))?"selected":""%>><%=obiekt.nazwa%>
						<%=obiekt.adres%></option>
					
					<%
					}
					
				%>

				</select>
			</form>
		</div>

		<div class="tabelawybor">
			<td><b>Wpisz liczbę uczestników:</b><input type="text" name="uczest" /></td>
			<% String liczbaUzytkownikow = request.getParameter("uczest"); %>
		</div>

		<div class="tabelawybor">
			<table class="center">

				<tr>
					<td>Nazwa obiektu:</td>
					<td>Data:</td>
					<td>Godzina</br> rozpoczęcia:
					</td>
					<td>Godzina</br> zakończenia:
					</td>
					<td></td>
				</tr>
				<%
				ListaTerminow listaterminow = new ListaTerminow(); 
				listaterminow.setId(selectedObiekt);
				ArrayList<Termin> lista =listaterminow.getTerminy();
					for (Termin termin : lista) {
				%>
				<tr>
					<td><%=termin.nazwaObiektu%> <%=termin.adresObiektu%></td>
					<td><%=termin.dzien%></td>
					<td><%=termin.odKtorej%></td>
					<td><%=termin.doKtorej%></td>
					<td><form action="Rezerwuj" method="post">
							<button class="btn btn-primary">Zarezerwuj</button>
						</form></td>
				</tr>
				<%
					}
				%>
			</table>
		</div>
	</div>


</body>
</html>

