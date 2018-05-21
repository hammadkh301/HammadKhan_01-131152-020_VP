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
    public partial class Viewquestions : Form
    {
        public Viewquestions()
        {
            InitializeComponent();
        }

        private void Updatequestion_Load(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
