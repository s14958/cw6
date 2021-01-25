using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Wyklad6_nauka.Models;

namespace Wyklad6_nauka.Services
{
    public class SqlServerStudentDbService : IStudentDbService
    {
        private static string connectionString = "Data Source=db-mssql;Initial Catalog=s14958;Integrated Security=True";


        public IEnumerable<Student> GetStudents() { 
            using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();

                command.CommandText = "select * from Student;";

                var reader = command.ExecuteReader();

                var students = new List<Student>();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = DateTime.Parse(reader["BirthDate"].ToString()),
                        IdEnrollment = (int) reader["IdEnrollment"],
                        IndexNumber = reader["IndexNumber"].ToString()
                    });
                }


                return students;
            }
        }

        public Student GetStudent(string index)
        {
            using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Student where IndexNumber = @index";
                command.Parameters.AddWithValue("index", index);

                var reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    return null;
                }

                return new Student
                {
                    IndexNumber = reader["IndexNumber"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    BirthDate = DateTime.Parse(reader["BirthDate"].ToString()),
                    IdEnrollment = (int)reader["IdEnrollment"]
                };
            }
        }
    }
}
