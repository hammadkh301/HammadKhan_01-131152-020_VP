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
    public partial class Studentlogin : Form
    {
        public Studentlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter obj1 = new SqlDataAdapter("Select * From Student Where USERNAME='" + utextBox3.Text + "'and PASSWORD='" + ptextBox4.Text + "'", obj);
            DataTable obj2 = new DataTable();
            obj1.Fill(obj2);
            if (obj2.Rows.Count == 1)
            {
                
                StudentExam obj3 = new StudentExam();
                obj3.Show();
            }
            else
            {
                MessageBox.Show("Please Check Username and Password");
            }
        }

        private void rbutton3_Click(object sender, EventArgs e)
        {
            StudentRegisteration obj = new StudentRegisteration();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Studentlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
