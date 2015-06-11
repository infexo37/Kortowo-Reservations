<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>menu główne</title>
		<meta name="viewport" content="initial-scale=1, maximum-scale=1">
		<meta name="android-mobile-web-app-capable" content="yes">
		<meta name="android-mobile-web-app-status-bar-style" content="black">
		<meta http-equiv="refresh" content="1; url=mojeRezerwacje.jsp">
		<link href="css/ratchet.css" rel="stylesheet">
		<link href="css/ratchet-theme-android.css" rel="stylesheet">
<!-- 		<link href="css/index.css" rel="stylesheet"> -->
		<script src="js/ratchet.js"></script>
		<script>
  		setTimeout(function() {
      	document.location = "mojeRezerwacje.jsp";
  		}, 5000); // <-- this is the delay in milliseconds
		</script>
	</head>
	<body>
		<header class="bar bar-nav">
			<h1 class="title">System rezerwacji obiektów sportowych w Kortowie</h1>
		</header>
		<br>
		<br>
		<br>
			<center><font color="green" size="48">${z}</font></center>
	</body>
</html>