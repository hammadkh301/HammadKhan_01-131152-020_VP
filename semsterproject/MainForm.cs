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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addquestion obj = new addquestion();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exam obj = new Exam();
            obj.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updatequestion obj = new updatequestion();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewquestions obj = new Viewquestions();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deletequestion obj = new deletequestion();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
