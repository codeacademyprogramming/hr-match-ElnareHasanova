using HR_match.Models;
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
    public partial class Form3 : Form
    {
        Employee employee = new Employee();
        HR hR = new HR();
        int currentId;
        int currentHrId;
        public Form3()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            using (HRContext db = new HRContext())
            {
                var selectedEmployee = db.Employees.FirstOrDefault(x => x.Username == username.Text && x.Password == password.Text);
                var selectedHR = db.HRs.FirstOrDefault(hr => hr.Username == username.Text && hr.Password == password.Text);

                if (selectedEmployee !=null)
                {
                    currentId = selectedEmployee.Id;
                    Form5 menuEmp = new Form5();
                    menuEmp.Show();
                    menuEmp.GetCurrentEmployee(currentId);
                }
                else if (selectedHR != null)
                {
                    currentHrId = selectedHR.Id;
                    Form7 menuHR = new Form7();
                    menuHR.Show();
                    menuHR.GetCurrentHR(currentHrId);
                }
                else
                {
                    MessageBox.Show("Enter valid information");
                }
            }
        }
    }
}
