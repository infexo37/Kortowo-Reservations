package test;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import test.ConnectionClass;

public class ListaObiektow {
	Connection conn = null;
	public ListaObiektow() throws ClassNotFoundException
	{
		  conn = ConnectionClass.Polacz();
     
	}
	
	
	public ArrayList<Obiekt> getObiekty() throws SQLException
	{
		ArrayList<Obiekt> obiekty = new ArrayList<Obiekt>();
		Statement pst = null;  
        ResultSet rs = null;
        String query = "SELECT nazwa,adres,dyscyplina from obiekty;";
        pst = conn.createStatement();
        rs = pst.executeQuery(query);
        
        while(rs.next()){
        	Obiekt obiekt = new Obiekt();
        	obiekt.setNazwa(rs.getString("nazwa"));
        	obiekt.setAdres(rs.getString("adres"));
        	obiekt.setDyscyplina(rs.getString("dyscyplina"));
        	obiekty.add(obiekt);
        }
        
        return obiekty;
        
	}
}
