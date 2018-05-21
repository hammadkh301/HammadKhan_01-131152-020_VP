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
    public partial class updatequestion : Form
    {
        public updatequestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatequestion_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from addquestion1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter obj = new SqlDataAdapter(cmd);
            obj.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
           SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update addquestion1 set optiona='" + textBox3.Text + "',optionb='"+textBox5.Text+"',optionc='"+textBox7.Text+"',optiond='"+textBox9.Text+"',correct='"+textBox11.Text+"'where qutitle='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully!");
            con.Close();
        }
    }
}
