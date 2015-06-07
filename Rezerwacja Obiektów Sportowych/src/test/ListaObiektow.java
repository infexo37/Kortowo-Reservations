package test;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class ListaObiektow {
	Connection conn = null;
	public ListaObiektow() throws ClassNotFoundException
	{
		  
        String url = "jdbc:mysql://localhost:3306/";  
        String dbName = "zespolowy";  
        String driver = "com.mysql.jdbc.Driver";  
        String userName = "adminek";  
        String password = "123";  
        try {  
            Class.forName(driver).newInstance();  
            conn = DriverManager  
                    .getConnection(url + dbName, userName, password);
        } catch (Exception e) {  
            System.out.println(e);  
        }  
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
