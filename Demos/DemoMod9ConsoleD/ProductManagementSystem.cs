using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoMod9ConsoleD
{
    public class ProductManagementSystem
    {
        string connString;
        SqlConnection conn;

        public ProductManagementSystem()
        {
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library4;Integrated Security=True";
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public void display()
        {
            string sql = "Select * from book";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                //SqlDataReader will data from table record by record
                //ExecuteReader -> Select we are only reading/retrieving data not changeing anything in a table
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())//read a record at a time
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4} {5}", reader.GetValue(0),reader.GetString(1),
                                            reader.GetString(2),reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
                    }
                }
            }

        }

        public void insert()
        {
            Console.WriteLine("Enter ID:");
            int id= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Author Name");
            string author = Console.ReadLine();

            Console.WriteLine("Enter quantity:");
            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            int price = int.Parse(Console.ReadLine());

            string str = $"Insert into book(id,name,author,quantity,price) values ({id},'{name}','{author}',{qty},{price})";
            SqlCommand command = new SqlCommand(str, conn);

            //ExecuteNonQuery: because it is making changes into the table
            int rows = command.ExecuteNonQuery();
            Console.WriteLine($"{rows} books added");

        }

        public void update()
        {
            int uid;
            int available;

            Console.WriteLine("Enter ID that you would like to update");
            uid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the available value that you are updating");
            available = int.Parse(Console.ReadLine());
            //Update book set available=1 where"
            string updateQuery = "Update book set available=" + available + " where id=" + uid;
            SqlCommand command = new SqlCommand(updateQuery, conn);

            command.ExecuteNonQuery();
            Console.WriteLine("Data updated successfully");
        }

        public void delete()
        {
            int id;
            Console.WriteLine("Enter the ID that you would like to delete");
            id = int.Parse(Console.ReadLine());

            string deleteQuery = "Delete from book where id=" + id;
            SqlCommand command = new SqlCommand(deleteQuery, conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Data Deleted successfully");
        }

        public void disconnect()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
