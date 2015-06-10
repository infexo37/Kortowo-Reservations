<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@ page import="java.io.*"%>
<%@ page import="java.util.*"%>
<%@ page import="test.Obiekt"%>
<%@ page import="test.ListaObiektow"%>
<%@ page import="test.Termin"%>
<%@ page import="test.ListaTerminow"%>
<%@ page import="test.ListaRezerwacji"%>
<%@ page import="test.Rezerwacja"%>
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

	



		<div class="tabelawybor">
			<table class="center">

				<tr>
					<td>Nazwa obiektu:</td>
					<td>Adres obiektu: </td>
					<td>Data:</td>
					<td>Godzina</br> rozpoczęcia:
					</td>
					<td>Godzina</br> zakończenia:
					</td>
					
					<td> Liczba uczestników: </td>
				</tr>
				<%
				ArrayList<Rezerwacja> listaRezerwacji = new ListaRezerwacji().getRezerwacje();
					for (Rezerwacja rezerwacja : listaRezerwacji) {
				%>
				<tr>
					<td><%=rezerwacja.nazwaObiektu%></td>
					<td> <%=rezerwacja.adresObiektu%></td>
					<td><%=rezerwacja.dzien%></td>
					<td><%=rezerwacja.odKtorej%></td>
					<td><%=rezerwacja.doKtorej%></td>
					<td><%=rezerwacja.liczbaUczestnikow%></td>
					
				</tr>
				<%
					}
				%>
			</table>
		</div>
	</div>


</body>
</html>

