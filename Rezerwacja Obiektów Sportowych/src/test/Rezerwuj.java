package test;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

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
    private int idTermin;
    private int liczbaUczestnikow;
    public Rezerwuj() {
        super();

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
        conn = ConnectionClass.Polacz();
        ArrayList<Rezerwacja> rezerwacje = new ArrayList<Rezerwacja>();
        
        PreparedStatement st = null;

        ResultSet rs = null;
        String sql = "INSERT INTO rezerwacje (liczbaUczestnikow,idTermin) values ('" + liczbaUczestnikow + "','" + idTermin + "')"
         + "UPDATE termin SET termin.czyZajety=true WHERE termin.idTermin = '"+ idTermin +"'";              

        try
        {
            st = conn.prepareStatement(sql);

            
                rs = st.executeQuery();


            while(rs.next())
            {
                Rezerwacja rezerwacja = new Rezerwacja();
                rezerwacja.setLiczbaUczestnikow(rs.getInt(1));
                rezerwacja.setIdTermin(rs.getInt(2));
                rezerwacje.add(rezerwacja);
            }
        }
        catch(SQLException e)
        {
            System.out.println(e);
        }
    }

    public void setIdTermin(String id)
    {
        idTermin = Integer.parseInt(id);
    }
    public void setliczbaUczestnikow(String liczba)
    {
        liczbaUczestnikow = Integer.parseInt(liczba);
    }

}