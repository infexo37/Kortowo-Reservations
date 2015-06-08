package test;

import test.ConnectionClass;
import test.ListaObiektow;
import test.Obiekt;

import java.io.IOException;
import java.sql.*;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import test.ListaObiektow;
public class ListaTerminow {
	Connection conn;
	int idObiekt;
	public ListaTerminow() throws SQLException
	{
		conn = ConnectionClass.Polacz();
	}
	
	
	public ArrayList<Termin> getTerminy() throws SQLException, ClassNotFoundException
	{
		ArrayList<Termin> terminy = new ArrayList<Termin>();
		
		
		ResultSet rs = null;
		
		String query = "SELECT obiekty.nazwa,obiekty.adres, termin.dzien, termin.odKtorej, termin.doKtorej FROM termin LEFT JOIN obiekty ON termin.idObiekt = obiekty.idObiekt WHERE termin.czyZajety = false AND obiekty.idObiekt ='"+ idObiekt +"'";
		PreparedStatement ps = conn.prepareStatement(query);
		
		
		rs = ps.executeQuery();
		
		
		
		while(rs.next())
		{
			Termin termin = new Termin();
			
			termin.setNazwaObiektu(rs.getString(1));
			termin.setAdresObiektu(rs.getString(2));
			termin.setDzien(rs.getDate(3));
			termin.setOdKtorej(rs.getString(4));
			termin.setDoKtorej(rs.getString(5));
			terminy.add(termin);
		}
		return terminy;
	}
}
