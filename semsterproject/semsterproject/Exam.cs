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
            Random randomizer = new Random();
        }
        score1 obj1 = new score1();
        private DataTable data = null;
        private int currentRecord = 0;
        string correct;
        string select;
        public int value=0;
        private void Exam_Load(object sender, EventArgs e)
        {
          obj1.label2.Text = value.ToString();
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
            
                label3.Text = String.Format("{0}", data.Rows[currentRecord][0]);
                radioButton1.Text = String.Format("{0}", data.Rows[currentRecord][1]);
                radioButton2.Text = String.Format("{0}", data.Rows[currentRecord][2]);
                radioButton3.Text = String.Format("{0}", data.Rows[currentRecord][3]);
                radioButton4.Text = String.Format("{0}", data.Rows[currentRecord][4]);
                correct = String.Format("{0}", data.Rows[currentRecord][5]);
       
          
        }
        private void button1_Click(object sender, EventArgs e)
         {
                 if (radioButton1.Checked == true)
                 {
                     
                     select = radioButton1.Text;
                     radioButton1.Checked = false;
                 }
                 else if (radioButton2.Checked == true)
                 {
                     select = radioButton2.Text;
                     radioButton2.Checked = false;
                 }
                 else if (radioButton3.Checked == true)
                 {
                     select = radioButton3.Text;
                     radioButton3.Checked = false;
                 }
                 else if (radioButton4.Checked == true)
                 {
                     select = radioButton4.Text;
                     radioButton4.Checked = false;
                 }
                 else
                 {
                     MessageBox.Show("Please select any option");
                 }
                 if (select.Equals(correct))
                 {
                     value++;
                     obj1.label2.Text = value.ToString();
              
                 }

             if (currentRecord >= data.Rows.Count - 1)
             {
                 currentRecord = 0;
                 MessageBox.Show("quiz is over");
                 button1.Enabled = false;
                 obj1.Show();
                 obj1.label2.Text = value.ToString();
             }
             else
             {
                 currentRecord++;
                 displayrecord();
             }
         }
           


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer1.Start();
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
        int timeRemaining =  1* 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
             if (timeRemaining == 0)
            {
                timer1.Stop();
                MessageBox.Show("Sorry Time is up");
                obj1.Show();
                obj1.label2.Text = value.ToString();
            }
            else
                timeRemaining--;
                textBox2.Text = (timeRemaining / 60).ToString("00") +":"+(timeRemaining % 60).ToString("00");
            }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                select = radioButton1.Text;
                
            }
            else if (radioButton2.Checked == true)
            {
                select = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                select = radioButton3.Text;
              
            }
            else if (radioButton4.Checked == true)
            {
                select = radioButton4.Text;
               
            }

            if (select.Equals(correct))
            {
                value++;
                obj1.label2.Text = value.ToString();


            }

                if (currentRecord >= data.Rows.Count - 1)
                {
                    currentRecord = 0;

                }
                else
                {
                    currentRecord--;
                    displayrecord();
                }
            }
           
        }
        }
        