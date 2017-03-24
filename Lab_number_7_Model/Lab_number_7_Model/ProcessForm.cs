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
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }
        public void StartModelling()
        {

            foreach (Terminal t in Program.modeling.terminals)
            {
                t.CalculationOfTp();
            }
            double dt = Program.modeling.deltaT;
            while (Program.modeling.t <= Program.modeling.T)
            {

                if (Program.modeling.t  >= dt)
                {
                    //Информация
                    Program.modeling.GetInformation(this.dataGridView1);
                    dt = dt + Program.modeling.deltaT;
                }
                Program.modeling.t = Program.modeling.t + Program.modeling.deltat;
                Program.modeling.ReceiptOfBids();

                if (Program.modeling.ISEmployed())
                {
                    Program.modeling.PackageTreatment();
                    Program.modeling.IsConflict();
                    Program.modeling.ReducingWindows();
                }
                else
                {
                    Program.modeling.Processing();
                    Program.modeling.ReducingWindows();
                }

            }
            Program.modeling.GetInformation(this.dataGridView1);
        }



        private void ProcessForm_Load(object sender, EventArgs e)
        {
            Program.modeling.GetInformation(this.dataGridView1);
            this.StartModelling();
        }
    }
}
