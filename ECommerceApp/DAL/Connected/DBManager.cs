namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString = @"Server=localhost;port=3307;user=root;password=root123;database=transflower";

    public static List<Department> GetAllDepartments()
    {
        List<Department> allDepartments = new List<Department>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        try
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            string query = "SELECT * FROM departments";
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString()!);
                string name = reader["name"].ToString()!;
                string location = reader["location"].ToString()!;
                Department dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
                allDepartments.Add(dept);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return allDepartments;
    }

    public static Department GetDepartmentDetails(int id)
    {   
        Department dept = null!;
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        try
        {
            connection.Open();
            string query = "SELECT * FROM departments WHERE id = " + id;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["id"].ToString()!);
                string name = reader["name"].ToString()!;
                string location = reader["location"].ToString()!;
                dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return dept;
    }

}