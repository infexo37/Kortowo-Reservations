package test;

import java.sql.Date;

import test.Termin;

public class Rezerwacja {

	private int idRezerwacja;
	private int liczbaUczestnikow;
	private String nazwaObiektu;
	private String adresObiektu;
	private Date dzien;
	private String odKtorej;
	private String doKtorej;
	private Termin termin;
	
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
}
