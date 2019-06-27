//Import statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Package information
namespace pdf_parser
{
    //Class declaration
    static class Program
    {
        //Main method
        [STAThread]
        static void Main()
        {
            //Calls application method
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Runs a new application form
            Application.Run(new ApplicationForm());
        }
    }
}
