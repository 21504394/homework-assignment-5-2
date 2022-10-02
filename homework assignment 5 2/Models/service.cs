using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using homework_assignment_5_2.Models;

namespace homework_assignment_5_2.Models
{
    public class Service
    {
        //this is an sql connection string function
        private SqlConnection myConnection;
        private static Service instance;

        public string surname { get; private set; }

        public static Service GetService()
        {
            if (instance == null)
            {
                instance = new Service();
            }

            return instance;
        }

        //soem connection string removed 
        //if there is something worng with the namespace return to instance 

        public void OpenConnection()
        {
            try
            {
                //this connection doesnt transfer data it just opens access to the database 
                myConnection = new SqlConnection("Data Source=DESKTOP-3QSGQ3E\\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True");

                //open connection 
                myConnection.Open();

            }
            catch (Exception)
            {
                myConnection.Close();
            }

        }

        public List<books> GetAvailableBooks()
        {

            //temporarily receives the data till its all in the model 
            List<books> bookList = new List<books>();
            try
            {
                OpenConnection();

                //runs the command and sends it by means of sql
                SqlCommand command = new SqlCommand("select*from books", myConnection);
                SqlDataReader reader = command.ExecuteReader();
                //reader reads through the books
                while (reader.Read())
                {
                    //our books model will be able to recieve our data ,acts as a list
                    //overloads 
                    books book = new books()
                    {
                        //these are the names in the models and the names in the tables 
                        bookId = Convert.ToInt32(reader["bookId"]),
                        name = Convert.ToString(reader["name"]),
                        authorId = Convert.ToInt32(reader["authorId"]),
                        typeId = Convert.ToInt32(reader["typeId"]),
                        pagecount = Convert.ToInt32(reader["pagecount"]),
                        point = Convert.ToInt32(reader["point"])
                    };
                        bookList.Add(book);
                }

            }
             catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return bookList;
        }
        //VM creates a relationship between models, many to many relationships associative entity is like a VM, we want to refernce our lists 
        //view is temporary, we want to see the data 

        public List<authors> GetavailableAuthors()
        {
            //temporarily receives the data till its all in the model 
            List<authors> authorList = new List<authors>();
            OpenConnection();
            try
            {
                //runs the command and sends it by means of sql
                SqlCommand command = new SqlCommand("select*from authors", myConnection);
                SqlDataReader reader = command.ExecuteReader();
                //reader reads through the books
                while (reader.Read())
                {
                    //our books model will be able to recieve our data ,acts as a list

                    authors author = new authors()
                    {
                        //these are the names in the models and the names in the tables 
                        authorId = Convert.ToInt32(reader["authorId"]),
                        name = Convert.ToString(reader["name"]),
                        surname = Convert.ToInt32(reader["surname"]),

                    };
                    authorList.Add(author);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            return authorList;
        }

        public List<authors> GetAvailableStudents()
        {
            //temporarily receives the data till its all in the model 
            List<students> studentList = new List<students>();
            OpenConnection();
            try
            {
                //runs the command and sends it by means of sql
                SqlCommand command = new SqlCommand("select*from students", myConnection);
                SqlDataReader reader = command.ExecuteReader();
                //reader reads through the books
                while (reader.Read())
                {
                    //our books model will be able to recieve our data ,acts as a list

                    students student = new students()
                    {
                        //these are the names in the models and the names in the tables 


                        studentId = Convert.ToInt32(reader["studentId"]),
                        name = Convert.ToString(reader["name"]),
                        surname = Convert.ToString(reader["surname"]),
                        birthdate = Convert.ToDateTime(reader["birthdate"]),
                        gender = Convert.ToString(reader["gender"]),
                        Class = Convert.ToString(reader["class"]),
                        point = Convert.ToInt32(reader["point"]),

                    };
                    studentList.Add(student);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return studentList;
        }



    }
    //in the controller get all authors

    public string Returnbook()
    {
        return;
    }
}
