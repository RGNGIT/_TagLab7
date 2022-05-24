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
        cmd.ExecuteNonQuery();
    }

    public void AddJur(string Name, string Phone)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO jur (Name, Phone) VALUES ('{Name}', '{Phone}')", connection);
        cmd.ExecuteNonQuery();
    }

    public void AddPhys(string Name, string Surname, string Patr)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO phys (Name, Surname, Patr) VALUES ('{Name}', '{Surname}', '{Patr}')", connection);
        cmd.ExecuteNonQuery();
    }

    public void AddAddress(string Name, string Description, string Category, int Price)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO Bilet (Name, Description, Category,Price) VALUES ('{Name}', '{Description}', '{Category}','{Price}')", connection);
        cmd.ExecuteNonQuery();
    }

    public void AddOffice(string Name, int AddrKey)
    {
        SqlCommand cmd = new SqlCommand($"INSERT INTO office (Name, AddrKey) VALUES ('{Name}', {AddrKey})", connection);
        cmd.ExecuteNonQuery();
    }

    public void Selector(string Table, string Conditions)
    {
        SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {Table} WHERE {Conditions}", connection);

    }
}
