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
    public partial class addquestion : Form
    {
        public addquestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into addquestion1 ([qutitle], [optiona],[optionb],[optionc],[optiond],[correct]) values(@qutitle,@optiona,@optionb,@optionc,@optiond,@correct)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@qutitle", qutextBox1.Text);
                    cmd.Parameters.AddWithValue("@optiona", atextBox2.Text);
                    cmd.Parameters.AddWithValue("@optionb", btextBox3.Text);
                    cmd.Parameters.AddWithValue("@optionc", ctextBox4.Text);
                    cmd.Parameters.AddWithValue("@optiond", dtextBox5.Text);
                    cmd.Parameters.AddWithValue("@correct", cotextBox6.Text);
                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ");
                    qutextBox1.Text = "";
                    atextBox2.Text = "";
                    btextBox3.Text = "";
                    ctextBox4.Text = "";
                    dtextBox5.Text = "";
                    cotextBox6.Text = "";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
