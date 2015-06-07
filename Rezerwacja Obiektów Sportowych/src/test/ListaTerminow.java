package test;

import test.ConnectionClass;
import test.ListaObiektow;
import test.Obiekt;

import java.sql.*;
import java.util.ArrayList;

public class ListaTerminow {
	Connection conn;
	public ListaTerminow() throws SQLException
	{
		conn = ConnectionClass.Polacz();
	}
	
	public ArrayList<Termin> getTerminy() throws SQLException, ClassNotFoundException
	{
		ArrayList<Termin> terminy = new ArrayList<Termin>();
		
		Statement st = null;
		
		ResultSet rs = null;
		
		String query = "SELECT obiekty.nazwa,obiekty.adres, termin.dzien, termin.odKtorej, termin.doKtorej FROM termin LEFT JOIN obiekty ON termin.idObiekt = obiekty.idObiekt;";
		
		st = conn.createStatement();
		
		rs = st.executeQuery(query);
		
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
