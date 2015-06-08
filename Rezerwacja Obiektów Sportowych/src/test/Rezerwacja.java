package test;

import test.Termin;

public class Rezerwacja {

	private int idRezerwacja;
	private int liczbaUczestnikow;
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
}
