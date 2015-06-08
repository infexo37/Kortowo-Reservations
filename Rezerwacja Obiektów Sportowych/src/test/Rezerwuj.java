package test;

import java.io.IOException;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import test.ConnectionClass;
import test.Rezerwacja;
import test.Termin;/**
 * Servlet implementation class Rezerwuj
 */
@WebServlet("/Rezerwuj")
public class Rezerwuj extends HttpServlet {
	private static final long serialVersionUID = 1L;
    Connection conn;
    public Rezerwuj() {
        super();
        conn = ConnectionClass.Polacz();
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		int liczbaUczestnikow = Integer.parseInt(request.getParameter("liczbaUczestnikow"));
        int idTermin = Integer.parseInt(request.getParameter("idTermin"));
        Statement st = null;
        String sql = "INSERT INTO rezerwacje (liczbaUczestnikow,idTermin) values ('" + liczbaUczestnikow + "','" + idTermin + "')";
        try
        {
            st = conn.createStatement();
        }
        catch(SQLException e)
        {
            System.out.println(e);
        }
	}

}
