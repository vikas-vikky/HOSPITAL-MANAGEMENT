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

namespace HospitalDatabase
{
    public partial class Form3 : Form
    {
        String StaffId = null; //Staff ID
        String StaffName = null; // Staff Full Name
        String Hours = null; // Hours Working
        String connectionString;
        SqlConnection cnn;

        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter = new SqlDataAdapter();
        String sql = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
               // MessageBox.Show("Connection Open");

                sql = "Insert into dbo.Staff values(" + "'" + StaffId + "','" + StaffName + "','" + Hours + "'" + ")";

                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");

                command.Dispose();
                cnn.Close();
                //Console.WriteLine(Id + "," + firstName + "," + lastName + "," + email);


            }
            catch (Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Update
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
              //  MessageBox.Show("Connection Open");

                sql = "update dbo.Staff set StaffName='" + StaffName + "',Hours ='" + Hours + "' where StaffId = '" + StaffId + "'";


                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = new SqlCommand(sql, cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");

                command.Dispose();
                cnn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StaffId = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            StaffName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Hours = textBox3.Text;
        }
        //Delete
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
               // MessageBox.Show("Connection Open");

                sql = "delete dbo.Staff where StaffId = '" + StaffId + "'";

                command = new SqlCommand(sql, cnn);

                adapter.DeleteCommand = new SqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");

                command.Dispose();
                cnn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }
        //GetDetails
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                String Output = "";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
              //  MessageBox.Show("Connection Open");

                if(StaffId == null)
                {
                     sql = "select * from dbo.Staff";

                }
                else if(StaffId.Equals(""))
                     sql = "select * from dbo.Staff";
                else
                      sql = "select * from dbo.Staff where StaffId = '" + StaffId + "'";



                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Output = Output + "Staff ID - "+dataReader.GetValue(0)+""+Environment.NewLine +""+ "Staff Name - " + dataReader.GetValue(1)+""+Environment.NewLine+"" + "Hours - " + dataReader.GetValue(2)+"" + Environment.NewLine+""+Environment.NewLine;
                }

                if(Output.Equals(""))
                    MessageBox.Show("No Records Present");
                else
                    MessageBox.Show(Output);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }
    }
}
