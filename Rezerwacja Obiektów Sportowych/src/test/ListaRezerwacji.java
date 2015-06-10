package test;
 
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
 
import test.ConnectionClass;
 
public class ListaRezerwacji {
        Connection conn = null;
        public ListaRezerwacji() throws ClassNotFoundException
        {
        	conn = ConnectionClass.Polacz();
        }
       
        public ArrayList<Rezerwacja> getRezerwacje() throws SQLException
        {
        	ArrayList<Rezerwacja> rezerwacje = new ArrayList<Rezerwacja>();
            Statement pst = null;  
            ResultSet rs = null;
            String query = "SELECT obiekty.nazwa, obiekty.adres, termin.dzien, "
                        + "termin.odKtorej, termin.doKtorej, rezerwacje.liczbaUczestnikow "
                        + "from rezerwacje left join termin on "
                        + "rezerwacje.idTermin = termin.idTermin left join obiekty on "
                        + "termin.idObiekt = obiekty.idObiekt;";
            pst = conn.createStatement();
            rs = pst.executeQuery(query);
       
            while(rs.next()){
                Rezerwacja rezerwacja = new Rezerwacja();
                rezerwacja.setNazwaObiektu(rs.getString(1));
                rezerwacja.setAdresObiektu(rs.getString(2));
                rezerwacja.setDzien(rs.getDate(3));
                rezerwacja.setOdKtorej(rs.getString(4));
                rezerwacja.setDoKtorej(rs.getString(5));
                rezerwacja.setLiczbaUczestnikow(rs.getInt(6));
                rezerwacje.add(rezerwacja);
            }	
            return rezerwacje;
        }
}
