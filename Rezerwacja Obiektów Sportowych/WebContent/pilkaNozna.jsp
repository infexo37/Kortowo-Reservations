<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@ page import="java.io.*"%>
<%@ page import="java.util.*"%>
<%@ page import="test.Obiekt"%>
<%@ page import="test.ListaObiektow"%>
<%@ page import="test.Termin"%>
<%@ page import="test.ListaTerminow"%>
<%@ page import="test.Rezerwuj" %>
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
	</header>

<p>  Wybierz obiekt:</p>

	<div id="content">
		<div class="tabelawybor">
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
<p>  Wpisz liczbę uczestników:</p>
		<form action="Rezerwuj" method="post">
		<div class="tabelawybor">
			<input type="text" name="liczbaUczestnikow"/>
				
		</div>
			
		<div class="tabelawybor">
			<table class="center">

				<tr>
					<td>#</td>
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
				
					<td><%=termin.idTermin %><input type="hidden" name="idTermin" value="<%=termin.idTermin%>"/></td>
					
					<td><%=termin.nazwaObiektu%> <%=termin.adresObiektu%></td>
					<td><%=termin.dzien%></td>
					<td><%=termin.odKtorej%></td>
					<td><%=termin.doKtorej%></td>
					<td>
							<button class="btn btn-primary">Zarezerwuj</button>
						</td>
				</tr>
				<%
					}
				%>
			</table>
			
		</div>
		</form>
	</div>
<br>
		<a class="btn btn-primary btn-block" href = "index.jsp"><span class="icon icon-home"></span>Powrót do menu głównego</a>

</body>
</html>