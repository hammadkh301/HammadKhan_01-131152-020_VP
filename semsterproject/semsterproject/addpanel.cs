using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semsterproject
{
    public partial class addpanel : Form
    {
        public addpanel()
        {
            InitializeComponent();
        }

        private void addpanel_Load(object sender, EventArgs e)
        {

        }

        public static object Ok { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Ok obj = new Ok();
            obj.Show();
        }
    }
}
