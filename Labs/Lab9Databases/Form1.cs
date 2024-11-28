using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Databases
{
	public partial class Form1 : Form
	{
		string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lab9;Integrated Security=True";

		public Form1()
		{
			InitializeComponent();
		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'lab9DataSet.demotb' table. You can move, or remove it, as needed.
			this.demotbTableAdapter.Fill(this.lab9DataSet.demotb);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				MessageBox.Show("Connection Open!");
			}
		}

		private void Insert_Click(object sender, EventArgs e)
		{
			string idValue = txtID.Text;
			string nameValue = txtName.Text;

			string query = "Insert into demotb (TutorialID,TutorialName) values(@TutorialID, @TutorialName)";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@TutorialID", idValue);
					command.Parameters.AddWithValue("@TutorialName", nameValue);

					command.ExecuteNonQuery();
				}
			}
		}

		private void Update_Click(object sender, EventArgs e)
		{


			string idValue = txtID.Text;
			string nameValue = txtName.Text;

			string query = "Update demotb set TutorialID = \"@TutorialID\", TutorialName = \"@TutorialName\" where TutorialID";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@TutorialID", idValue);
					command.Parameters.AddWithValue("@TutorialName", nameValue);

					command.ExecuteNonQuery();
				}
			}

		}

		private void Delete_Click(object sender, EventArgs e)
		{

		}
	}
}
