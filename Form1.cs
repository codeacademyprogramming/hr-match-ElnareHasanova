using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Form3 signIn = new Form3();
            signIn.Show();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Form2 signUp = new Form2();
            signUp.Show();
        }
    }
}
