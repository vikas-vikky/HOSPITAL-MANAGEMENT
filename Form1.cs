using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HospitalDatabase
{
    public partial class Form1 : Form
    {
        String firstName = null;
        String lastName = null;
        String Id = null;
        String email = null;

        String connectionString;
        SqlConnection cnn;

        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter = new SqlDataAdapter();
        String sql = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
        }

        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
             
           
            
            try
            {


connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
              //  MessageBox.Show("Inserted Successfully");

                sql = "Insert into dbo.PatientDetails values("+"'"+ Id + "','" + firstName + "','" + lastName + "','" + email +"'"+ ")";

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Id = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            email = textBox4.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     



        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Go back
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        //Update
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
              //  MessageBox.Show("Connection Open");

                sql = "update dbo.PatientDetails set Firstname ='" + firstName + "',Lastname='" + lastName + "',email ='" + email + "' where Id = '" + Id+"'";

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

        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
               // MessageBox.Show("Connection Open");

                sql = "delete dbo.PatientDetails where Id = '" + Id + "'";

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

        //Get Details
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
connectionString = @"Data Source=MSSQLSERVER;AttachDBFilename=C:\Users\ajith\OneDrive\Desktop\HospitalDatabase\HospitalDatabase\HospitalDatabase\Database1.mdf;Integrated Security=True";

                String Output = "";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
              //  MessageBox.Show("Connection Open");

                if(Id == null)
                      sql = "select * from dbo.PatientDetails";
                else if(Id.Equals(""))
                      sql = "select * from dbo.PatientDetails";
                else
                      sql = "select * from dbo.PatientDetails where Id = '" + Id + "'";

                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                 Output = Output + "Id - "+dataReader.GetValue(0)+""+Environment.NewLine + "Firstname - " + dataReader.GetValue(1)+""+Environment.NewLine + "Lastname - " + dataReader.GetValue(2)+""+Environment.NewLine + "Email - " + dataReader.GetValue(3)+""+Environment.NewLine+""+Environment.NewLine;
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
