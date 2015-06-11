package test;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import test.ConnectionClass;

@WebServlet("/Rezerwuj")
public class Rezerwuj extends HttpServlet {
	private static final long serialVersionUID = 1L;
    Connection conn;
    public Rezerwuj() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		conn = ConnectionClass.Polacz();
		
		int idTermin = Integer.parseInt(request.getParameter("idTermin"));
		int liczbaUczestnikow = Integer.parseInt(request.getParameter("liczbaUczestnikow"));
		
		
		String sql1 = "INSERT INTO rezerwacje (liczbaUczestnikow,idTermin) values (?,?)";
		String sql2 = "UPDATE termin SET termin.czyZajety=true WHERE termin.idTermin = ?";
		
		try {
			PreparedStatement preparedStatement1 = conn.prepareStatement(sql1);
				preparedStatement1.setInt(1, liczbaUczestnikow );
		
				preparedStatement1.setInt(2, idTermin);
				PreparedStatement preparedStatement2 = conn.prepareStatement(sql2);
				preparedStatement2.setInt(1, idTermin);
				preparedStatement1.executeUpdate();
				preparedStatement2.executeUpdate();
				String z = "<font color='green' size='r8'>Zarezerwowano!</font>";
				request.setAttribute("z", z); // This will be available as ${message}
		        request.getRequestDispatcher("zarezerwowano.jsp").forward(request, response);
				
				
		}
		catch(SQLException e)
		{
			System.out.print(e);
		}
	}

}
