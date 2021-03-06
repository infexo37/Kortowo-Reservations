package test;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import test.ConnectionClass;
/**
 * Servlet implementation class AnulujRezerwacje
 */
@WebServlet("/AnulujRezerwacje")
public class AnulujRezerwacje extends HttpServlet {
	private static final long serialVersionUID = 1L;
    Connection conn;
    public AnulujRezerwacje() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		conn = ConnectionClass.Polacz();
		
		int idTermin = Integer.parseInt(request.getParameter("idTermin"));
		int idRezerwacja = Integer.parseInt(request.getParameter("idRezerwacja"));
		
		String sql1 = "DELETE FROM rezerwacje WHERE rezerwacje.idRezerwacja = ?";
		String sql2 = "UPDATE termin SET termin.czyZajety=false WHERE termin.idTermin= ?";
		try{
		PreparedStatement preparedStatement1 = conn.prepareStatement(sql1);
		preparedStatement1.setInt(1, idRezerwacja);

		
		PreparedStatement preparedStatement2 = conn.prepareStatement(sql2);
		preparedStatement2.setInt(1, idTermin);
		preparedStatement1.executeUpdate();
		preparedStatement2.executeUpdate();
		String z = "<font color='red' size='r8'>Anulowano rezerwację!</font>";
		request.setAttribute("z", z); // This will be available as ${message}
        request.getRequestDispatcher("zarezerwowano.jsp").forward(request, response);
		}
		catch(SQLException e)
		{
			System.out.print(e);
		}
	}

}
