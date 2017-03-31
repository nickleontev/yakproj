using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_number_7_Model
{
    public partial class TESTHelloMenuForm : Form
    {
        public TESTHelloMenuForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void HelloMenuForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToShortTimeString();
            this.label2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
