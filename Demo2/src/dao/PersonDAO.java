package dao;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import model.Person;

public class PersonDAO {

    private Connection connection;

    public PersonDAO() {
        ConnectionClass con = new ConnectionClass();
        try {
            connection = con.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void addPerson(Person person) {
        try {
            String query = "insert into person(name, phone, profession) values ('" + person.getName() + "', '" + person.getPhone() + "', '" + person.getProfession() + "')";

            Statement stmt = connection.createStatement();
            stmt.executeUpdate(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void removePerson(int personid) {
        String query = "delete from person where person.idperson = " + personid + " ";
        try {
            Statement stmt = connection.createStatement();
            stmt.executeUpdate(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void updatePerson(Person person) {
        String query = "update person set person.name='" + person.getName() + "', person.phone='" + person.getPhone()
                + "', person.profession='" + person.getProfession() + "' where person.idperson = " + person.getPersonId() + " ";
        System.out.println(query);
        try {
            Statement stmt = connection.createStatement();
            stmt.executeUpdate(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public ArrayList<Person> getPersons() throws SQLException {
        String query = "select * from person";
        ArrayList<Person> persons = new ArrayList<Person>();
        Statement stmt = connection.createStatement();
        ResultSet res = stmt.executeQuery(query);
        while (res.next()) {
            Person person = new Person();
            person.setName(res.getString("name"));
            person.setPhone(res.getString("phone"));
            person.setProfession(res.getString("profession"));
            person.setPersonId(res.getInt("idperson"));
            persons.add(person);
        }
        return persons;
    }

    public Person getPersonById(int personid) throws SQLException {
        Person person = new Person();
        String query = "select * from person where person.idperson = " + personid + " ";
        Statement stmt = connection.createStatement();
        ResultSet res = stmt.executeQuery(query);
        if (res.next()) {
            person.setName(res.getString("name"));
            person.setPhone(res.getString("phone"));
            person.setProfession(res.getString("profession"));
            person.setPersonId(res.getInt("idperson"));
        }
        return person;
    }
}