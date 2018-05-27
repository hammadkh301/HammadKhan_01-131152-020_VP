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
    public partial class StudentRegisteration : Form
    {
        public StudentRegisteration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection objec = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            objec.Open();
            SqlCommand cmd = new SqlCommand("insert into Student ([USERNAME],[PASSWORD],[Firstname],[Lastname]) values((@USERNAME),(@PASSWORD),(@Firstname),(@Lastname))", objec);
            cmd.Parameters.AddWithValue("@USERNAME", utextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@PASSWORD", ptextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@Firstname",ftextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Lastname", ltextBox2.Text.Trim());
            cmd.ExecuteNonQuery();
            objec.Close();
            MessageBox.Show("Thankyou your account in created");
            objec.Close();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
