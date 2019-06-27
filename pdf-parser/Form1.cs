//Import statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Package information
namespace pdf_parser
{
    //Class declaration
    public partial class ApplicationForm : Form
    {
        //Sql adapter and binding source for changing tables
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();
        //Default constructor, initializes components
        public ApplicationForm()
        {
            InitializeComponent();
        }
        //Load method
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            SetDataGrid("Select * From Assignments");
        }
        //Click method
        private void Swap_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Columns[0].Name=="Date")
            {
                SetDataGrid("Select * From Emails");
            }
            else
            {
                SetDataGrid("Select * From Assignments");
            }
        }
        //Swap data method
        private void SetDataGrid(string selectCommand)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zansari\Documents\GitHub\pdf-parse\pdf-parser\School.mdf;Integrated Security=True";

            sqlDataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            DataTable table = new DataTable { Locale = CultureInfo.InvariantCulture };

            sqlDataAdapter.Fill(table);
            bindingSource.DataSource = table;
        }
    }
}
