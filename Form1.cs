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
            StreamWriter file = new StreamWriter(@"C:\Users\Arriane\source\repos\Contact-Tracing\Contact-Tracing\ContactTracing list\Info.txt");
            file.WriteLine("First Name: " + FnBox.Text);
            file.WriteLine("Middle Name: " + MnBox.Text);
            file.WriteLine("Last Name: " + LnBox.Text);
            file.WriteLine("Contact no.: " + CnBox.Text);
            file.WriteLine("Email: " + EmBox.Text);
            file.WriteLine("Full Address: " + FaBox.Text);
            file.WriteLine("Age: " + AgeBox.Text);
            file.WriteLine("Gender: " + GnBox.Text);
            file.Close();
            MessageBox.Show("Thankyou for your response");
            MnBox.Text = "";
            LnBox.Text = "";
            CnBox.Text = "";
            EmBox.Text = "";
            FaBox.Text = "";
            AgeBox.Text = "";
            GnBox.Text = "";
        }
    }
}
