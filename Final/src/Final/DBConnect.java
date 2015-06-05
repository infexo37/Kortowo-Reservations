package Final;

import java.sql.*;

public class DBConnect {

	public static boolean validate() {
		
		boolean status = false;
		
		try {
			Class.forName("com.mysql.jdbc.Driver");
			System.out.println("Driver found");
		} catch (ClassNotFoundException e) {
			System.out.println("Driver not found:"+e);
		}
		
		String url = "jdbc:mysql://localhost/zespolowy";
		String user = "root";
		String password = "";

		Connection conn = null;
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			status = true;
		} catch (SQLException e) {
			System.out.println("blad");
		} finally {  
            if (conn != null) {  
                try {  
                    conn.close();  
                } catch (SQLException e) {  
                    e.printStackTrace();  
                }    
            }  
        }
		return status;

	}

}