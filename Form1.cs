using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Arriane\Documents\Contact-Tracing.txt");
            file.WriteLine("First Name: " + FnBox.Text);
            file.WriteLine("Middle Name: " + MnBox.Text);
            file.WriteLine("Last Name: " + LnBox.Text);
            file.Close();
        }
    }
}
