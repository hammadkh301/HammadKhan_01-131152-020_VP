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
    public partial class signup : Form
    {

        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          {
              signup obj = new signup();
              SqlConnection objec = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
              objec.Open();
              SqlCommand cmd = new SqlCommand("insert into Login123 ([USERNAME],[PASSWORD],[Firstname],[Lastname]) values((@USERNAME),(@PASSWORD),(@Firstname),(@Lastname))",objec);
              cmd.Parameters.AddWithValue("@USERNAME",username.Text.Trim());
              cmd.Parameters.AddWithValue("@PASSWORD",password.Text.Trim());
              cmd.Parameters.AddWithValue("@Firstname", firstname.Text.Trim());
              cmd.Parameters.AddWithValue("@Lastname", lastname.Text.Trim());
              cmd.ExecuteNonQuery();
              objec.Close();
              MessageBox.Show("Thankyou your account in created");
              obj.Close();
             
          }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
