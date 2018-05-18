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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }
        private DataTable data = null;
        private int currentRecord = 0;
        string correct;
        private void Exam_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hamma\Documents\quizapplication.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con1 = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("select * from addquestion1", con1))
            {
                con1.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    data = new DataTable();
                    da.Fill(data);
                }
                displayrecord();
            }
        }
             public void displayrecord()
        {
            textBox1.Text = String.Format("{0}", data.Rows[currentRecord][0]);
            radioButton1.Text = String.Format("{0}", data.Rows[currentRecord][1]);
            radioButton2.Text = String.Format("{0}", data.Rows[currentRecord][2]);
            radioButton3.Text = String.Format("{0}", data.Rows[currentRecord][3]);
            radioButton4.Text = String.Format("{0}", data.Rows[currentRecord][4]);
                 textBox1.Text=string.Format("{0}",data.Rows[currentRecord][5]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true)
            {

            }
         if (currentRecord >= data.Rows.Count - 1)
                currentRecord = 0;
            else
                currentRecord++;
            displayrecord();
        }
        }
    }
