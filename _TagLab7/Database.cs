using System;
using System.Data;
using System.Data.SqlClient;

public class Database
{
    SqlConnection connection;

    public Database(string credentials)
    {
        connection = new SqlConnection(credentials);
        connection.Open();
    }

    public void AddStatus(string Status)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO status (Name) VALUES ('{Status}')", connection);
    }

    public void AddJur(string Name, string Phone)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO jur (Name, Phone) VALUES ('{Name}', '{Phone}')", connection);
    }

    public void AddPhys(string Name, string Surname, string Patr)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO phys (Name, Surname, Patr) VALUES ('{Name}', '{Surname}', '{Patr}')", connection);
    }

    public void AddAddress(string City, string Street, string Number)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO address (City, Street, Number) VALUES ('{City}', '{Street}', '{Number}')", connection);
    }

    public void AddOffice(string Name, int AddrKey)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO office (Name, AddrKey) VALUES ('{Name}', {AddrKey})", connection);
    }

    public void Selector(string Table, string Conditions)
    {
        SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {Table} WHERE {Conditions}", connection);

    }
}
