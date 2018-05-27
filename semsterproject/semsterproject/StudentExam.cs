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
    public partial class StudentExam : Form
    {
        public StudentExam()
        {
            InitializeComponent();
        }

        private void StartExam_Click(object sender, EventArgs e)
        {
            Exam obj = new Exam();
            obj.Show();
        }

        private void StudentExam_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
