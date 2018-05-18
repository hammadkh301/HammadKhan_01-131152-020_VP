using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace semsterproject
{
    public partial class Multiplechoice1 : Form
    {
        string submitted;
        public Multiplechoice1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[submit] ([sa1])

VALUES
('"+submitted+ "')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Answer is submitted succesfully");
            SqlCommand cmd1 = new SqlCommand("Select submit.sa1,answer.ans from answer INNER JOIN(SELECT TOP 1 sa1 From submit order by ID DESC)AS submit ON Submit.sa1=answer.ans", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable obj = new DataTable();
            sda.Fill(obj);
            if(obj.Rows.Count>0)
            {
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) VALUES ('correct')", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) 
VALUES ('incorrect')", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
            }



            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "hammad";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "khan";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "sohaib";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "rana";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 value FROM Compare ORDER BY ID DESC", con1);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd);
            DataTable dtbl1 = new DataTable();
            sda3.Fill(dtbl1);
            MessageBox.Show("your answer is " + dtbl1.Rows[0][0]);

        }
        List<Panel> listpanel = new List<Panel>();
        int index;
        private void button3_Click(object sender, EventArgs e)
        {
              if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }
        }
        private void Multiplechoice1_Load(object sender, EventArgs e)
        {

            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel.Add(p3);
           listpanel.Add(panel4);
          listpanel[index].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[submit] ([sa1])

VALUES
('" + submitted + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Answer is submitted succesfully");
            SqlCommand cmd1 = new SqlCommand("Select submit.sa1,answer.ans from answer INNER JOIN(SELECT TOP 1 sa1 From submit order by ID DESC)AS submit ON Submit.sa1=answer.ans", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable obj = new DataTable();
            sda.Fill(obj);
            if (obj.Rows.Count > 0)
            {
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) VALUES ('correct')", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) 
VALUES ('incorrect')", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 value FROM Compare ORDER BY ID DESC", con1);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd);
            DataTable dtbl1 = new DataTable();
            sda3.Fill(dtbl1);
            MessageBox.Show("your answer is " + dtbl1.Rows[0][0]);
        }
        
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C++";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "assembly language";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C sharp";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[submit] ([sa1])

VALUES
('" + submitted + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Answer is submitted succesfully");
            SqlCommand cmd1 = new SqlCommand("Select submit.sa1,answer.ans from answer INNER JOIN(SELECT TOP 1 sa1 From submit order by ID DESC)AS submit ON Submit.sa1=answer.ans", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable obj = new DataTable();
            sda.Fill(obj);
            if (obj.Rows.Count > 0)
            {
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) VALUES ('correct')", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) 
VALUES ('incorrect')", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 value FROM Compare ORDER BY ID DESC", con1);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd);
            DataTable dtbl1 = new DataTable();
            sda3.Fill(dtbl1);
            MessageBox.Show("your answer is " + dtbl1.Rows[0][0]);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C sharp";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "C sharp";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "all of these";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "None of these";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[submit] ([sa1])

VALUES
('" + submitted + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Answer is submitted succesfully");
            SqlCommand cmd1 = new SqlCommand("Select submit.sa1,answer.ans from answer INNER JOIN(SELECT TOP 1 sa1 From submit order by ID DESC)AS submit ON Submit.sa1=answer.ans", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable obj = new DataTable();
            sda.Fill(obj);
            if (obj.Rows.Count > 0)
            {
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) VALUES ('correct')", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO [dbo].[compare] ([value]) 
VALUES ('incorrect')", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 value FROM Compare ORDER BY ID DESC", con1);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd);
            DataTable dtbl1 = new DataTable();
            sda3.Fill(dtbl1);
            MessageBox.Show("your answer is " + dtbl1.Rows[0][0]);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "Wide Area Network";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "Work Area Network";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            submitted = "Wireless Area Network";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
        }
    }