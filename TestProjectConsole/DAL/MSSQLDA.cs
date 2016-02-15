using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using TestProjectConsole.DTO;


namespace TestProjectConsole.DAL
{
    public interface IMSSQLDA
    {
        List<Course> GetClasses();
    }
    public class MSSQLDA
    {
        public static List<Course> GetClasses()
        {
            using (SqlConnection myConnection = new SqlConnection())
            {

                try
                {

                    string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string path = root+"\\AppData\\ConsoleDatabase.mdf";

                    myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+path+";Integrated Security=True";
                    List<Course> courses = new List<Course>();

                    myConnection.Open();

                    try
                    {
                        string sql = @"Select * from Courses";

                        SqlCommand myCommand = new SqlCommand(sql, myConnection);

                        SqlDataReader myReader = null;

                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            Course c = new Course();
                            c.Id = Convert.ToInt32(myReader["Id"]);
                            c.TemplateId = myReader["TemplateId"].ToString();
                            c.StartDate = Convert.ToDateTime(myReader["StartDate"]);
                            c.EndDate = Convert.ToDateTime(myReader["EndDate"]);
                            c.Semester = myReader["Semester"].ToString();
                            c.MaxStudent = Convert.ToInt32(myReader["MaxStudent"]);

                            courses.Add(c);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return courses;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    throw e;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }

    }
}
