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
    public partial class Ok :Form
    {
        public Ok()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            SqlConnection obj = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter obj1 = new SqlDataAdapter("Select * From Login123 Where USERNAME='" + txtusername.Text + "'and PASSWORD='" + txtpassword.Text+ "'", obj);
            DataTable obj2 = new DataTable();
            obj1.Fill(obj2);
            if(obj2.Rows.Count==1)
            {
                MainForm obj3 = new MainForm();
                obj3.Hide();
                obj3.Show();
            }
            else
            {
                MessageBox.Show("Please Check Username and Password");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup obj = new signup();
            obj.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void Ok_Load(object sender, EventArgs e)
        {

        }
    }
}
