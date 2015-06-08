package test;

import java.sql.Date;

import test.Obiekt;
public class Termin {
	
	public int idTermin;
	public Date dzien;
	public String odKtorej;
	public String doKtorej;
	public boolean czyZajety;
	public String nazwaObiektu;
	public String adresObiektu;
	public int idObiekt;
	public Obiekt obiekt;
	
	
	
	public int getIdTermin() {
		return idTermin;
	}
	public void setIdTermin(int idTermin) {
		this.idTermin = idTermin;
	}
	public Date getDzien() {
		return dzien;
	}
	public void setDzien(Date dzien) {
		this.dzien = dzien;
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
	public boolean isCzyZajety() {
		return czyZajety;
	}
	public void setCzyZajety(boolean czyZajety) {
		this.czyZajety = czyZajety;
	}
	public int getIdObiekt() {
		return obiekt.idObiekt;
	}
	public void setIdObiekt(int idObiekt) {
		obiekt.idObiekt = idObiekt;
	}
	public String getNazwaObiektu() {
		return nazwaObiektu;
	}
	public void setNazwaObiektu(String nazwaObiektu) {
		this.nazwaObiektu = nazwaObiektu;
	}
	public void setAdresObiektu(String adresObiektu) {
		this.adresObiektu = adresObiektu;
		
	}
	public String getAdresObiektu()
	{
		return adresObiektu;
	}
	
}
