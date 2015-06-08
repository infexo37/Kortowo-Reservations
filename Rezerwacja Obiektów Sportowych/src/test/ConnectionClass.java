package test;

import java.sql.Connection;
import java.sql.DriverManager;

public class ConnectionClass {
	static Connection conn;
	public static Connection Polacz()
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
	    return conn;
	}
	
}
