package test;
 
import java.sql.Date;
 



import test.Termin;
 
public class Rezerwacja {
	public int idRezerwacja;
	public int liczbaUczestnikow;
	public Termin termin;
	public String nazwaObiektu;
	public String adresObiektu;
	public String odKtorej;
	public String doKtorej;
	public Date dzien;
    public int idTermin;
   
    public int getIdRezerwacja() {
    	return idRezerwacja;
    }
    public void setIdRezerwacja(int idRezerwacja) {
    	this.idRezerwacja = idRezerwacja;
    }
    public int getLiczbaUczestnikow() {
        return liczbaUczestnikow;
    }
    public void setLiczbaUczestnikow(int liczbaUczestnikow) {
        this.liczbaUczestnikow = liczbaUczestnikow;
    }
    public Termin getTermin() {
        return termin;
    }
    public void setTermin(Termin termin) {
        this.termin = termin;
    }
    public String getNazwaObiektu() {
        return nazwaObiektu;
    }
    public void setNazwaObiektu(String nazwaObiektu) {
        this.nazwaObiektu = nazwaObiektu;
    }
    public String getAdresObiektu() {
    	return adresObiektu;
    }
    public void setAdresObiektu(String adresObiektu) {
        this.adresObiektu = adresObiektu;
    }
    public String getOdKtorej() {
        return odKtorej;
    }
    public void setOdKtorej(String odKtorej) {
        this.odKtorej = odKtorej;
    }
    public String getDoKtorej() {
        return doKtorej;
    }
    public void setDoKtorej(String doKtorej) {
        this.doKtorej = doKtorej;
    }
    public Date getDzien() {
        return dzien;
    }
    public void setDzien(Date dzien) {
        this.dzien = dzien;
    }
	public int getIdTermin() {
		return idTermin;
	}
	public void setIdTermin(int idTermin) {
		this.idTermin = idTermin;
	}
}
