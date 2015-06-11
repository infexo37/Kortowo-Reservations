package test;

import test.ConnectionClass;
import test.ListaObiektow;
import test.Obiekt;

import java.io.IOException;
import java.sql.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
public class ListaTerminow {
	Connection conn;
	private int idObiekt;
	private String dzien;
	public ListaTerminow() throws SQLException
	{
		conn = ConnectionClass.Polacz();
	}
	
	
	public ArrayList<Termin> getTerminy() throws SQLException, ClassNotFoundException
	{
		ArrayList<Termin> terminy = new ArrayList<Termin>();
		
		
		ResultSet rs = null;
		
		String query = "SELECT termin.idTermin,obiekty.idObiekt,obiekty.nazwa,obiekty.adres, termin.dzien, termin.odKtorej, termin.doKtorej FROM termin LEFT JOIN obiekty ON termin.idObiekt = obiekty.idObiekt WHERE termin.czyZajety = false AND obiekty.idObiekt ='"+ idObiekt +"' AND termin.dzien='"+ dzien +"'";
		PreparedStatement ps = conn.prepareStatement(query);
		
		
		rs = ps.executeQuery();
		
		
		
		while(rs.next())
		{
			Termin termin = new Termin();
			termin.setIdTermin(rs.getInt(1));
			termin.setNazwaObiektu(rs.getString(3));
			termin.setAdresObiektu(rs.getString(4));
			termin.setDzien(rs.getString(5));
			termin.setOdKtorej(rs.getString(6));
			termin.setDoKtorej(rs.getString(7));
			terminy.add(termin);
		}
		return terminy;
	}
	
	public void setId(String id)
	{
		idObiekt=Integer.parseInt(id);
	}
	public void setDate(String data)
	{
		dzien=data;
	}
}
