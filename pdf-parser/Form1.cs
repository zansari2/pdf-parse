using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdf_parser
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Assignments' table. You can move, or remove it, as needed.
            this.assignmentsTableAdapter.Fill(this.schoolDataSet.Assignments);
        }

        private void Swap_Click(object sender, EventArgs e)
        {
           
        }
    }
}
