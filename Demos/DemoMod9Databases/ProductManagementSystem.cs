﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoMod9Databases
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
        public void Display()
        {
            string sql = "Select * from book";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                // SqlDataReader will get data from table record by record
                // ExecuteReader -> we are only reading/retrieving data, not changing anything in a table
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader.GetValue(0)} {reader.GetString(1)} {reader.GetString(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                    }
                }
            }
        }

        public void Insert()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price (as integer for testing): ");
            int price = int.Parse(Console.ReadLine());

            string str = $"Insert into book(id, name, author, quantity, price) values({id},'{name}','{author}',{quantity},{price})";
            SqlCommand command = new SqlCommand(str, conn);

            // ExectuteNonQuery -> because we are making changes into the table
            int rows = command.ExecuteNonQuery();
            Console.WriteLine($"{rows} books added");
        }

        public void Update()
        {
            int id;
            int available;

            Console.WriteLine("Enter ID that you would like to update: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the available value: ");
            available = int.Parse(Console.ReadLine());

            string updateQuery = $"update book set available={available} where id={id}";
            SqlCommand command = new SqlCommand(updateQuery, conn);

            command.ExecuteNonQuery();
            Console.WriteLine("Data updated successfully");
        }

        public void Delete()
        {
            int id;

            Console.WriteLine("Enter ID that you would like to delete: ");
            id = int.Parse(Console.ReadLine());

            string deleteQuery = $"delete from book where id={id}";
            SqlCommand command = new SqlCommand(deleteQuery, conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Data deleted successfully");
        }

        public void Disconnect()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
