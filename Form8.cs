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
    public partial class Form8 : Form
    {
        HR crntHR = new HR();
        Vacancie vacancie = new Vacancie();
        int currentHrId;

        public Form8()
        {
            InitializeComponent();
        }
        public void GetCurrentHR(int id)
        {
            using (HRContext db = new HRContext())
            {
                currentHrId = id;
                crntHR = db.HRs.FirstOrDefault(x => x.Id == currentHrId);

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {

        }

        void Run()
        {
            using (HRContext db = new HRContext())
            {
                vacancie.VacancieName = nameOfVacancie.Text;
                vacancie.CompanyName = nameOfCompany.Text;
                vacancie.Category = (string)category.SelectedItem;
                vacancie.Age = (int)age.Value;
                vacancie.Description = description.Text;
                vacancie.Study = (string)study.SelectedItem;
                vacancie.WorkExperience = (string)workExperience.SelectedItem;
                vacancie.City = city.Text;
                vacancie.Salary = (int)salary.Value;
                vacancie.Mobile = telephone.Text;
                vacancie.HrId = currentHrId;
                db.Vacancies.Add(vacancie);
                crntHR.Vacancies.Add(vacancie);
                db.SaveChanges();

                Form7 form7 = new Form7();
                form7.Show();
                form7.GetCurrentHR(currentHrId);
            }

        }

        public void FillOutForm()
        {
            if (age.Value == 0 ||
                study.SelectedIndex == -1 ||
                workExperience.SelectedIndex == -1 ||
                category.SelectedIndex == -1 ||
                description.Text ==""||
                salary.Value == 0 ||
                nameOfVacancie.Text == "" ||
                nameOfCompany.Text == "" ||
                city.Text == "" ||
                telephone.Text == "")
            {
                MessageBox.Show("Fill out all fields!");
            }
            else
            {
                Run();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            FillOutForm();
        }
    }
}
