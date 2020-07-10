using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_match
{
    public partial class Form7 : Form
    {
        int currentHrId;
        public Form7()
        {
            InitializeComponent();
        }

        public void GetCurrentHR(int id)
        {
            using (HRContext db = new HRContext())
            {
                currentHrId = id;
                var crntHR = db.HRs.FirstOrDefault(x => x.Id == currentHrId);

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            application.Hide();
            dataForSearch.Hide();
            searchBox.Hide();
            searchButton.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.Show();
        }


        private void create_vacancie_Click(object sender, EventArgs e)
        {
            Form8 vacancie = new Form8();
            vacancie.Show();
            vacancie.GetCurrentHR(currentHrId);
        }

        private void applications_Click(object sender, EventArgs e)
        {
            application.Show();
            using (HRContext db = new HRContext())
            {
                db.Vacancies.Load();
                var myVacancies = db.Vacancies.Local;
                vacancieBindingSource1.DataSource = myVacancies.Where(x => x.HrId == currentHrId);
            }
        }

        private void search_employee_Click(object sender, EventArgs e)
        {
            dataForSearch.Show();
            dataForSearch.BringToFront();
            searchBox.Show();
            searchButton.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (HRContext db = new HRContext())
            {
                var keyword = searchBox.Text;
                var result = (from v in db.CVs
                              select new
                              {
                                  v.Name,
                                  v.Surname,
                                  v.Age,
                                  v.Gender,
                                  v.Study,
                                  v.WorkExperience,
                                  v.Category,
                                  v.City,
                                  v.MininumSalary,
                                  v.Mobile
                              }).ToList();
                var filtered = result.Where(x => x.Name.ToLower().Contains(keyword.ToLower()) ||
                x.Surname.ToLower().Contains(keyword.ToLower()) ||
                x.Gender.ToLower().Contains(keyword.ToLower()) ||
                x.Study.ToLower().Contains(keyword.ToLower()) ||
                x.WorkExperience.ToLower().Contains(keyword.ToLower()) ||
                x.Category.ToLower().Contains(keyword.ToLower()) ||
                x.City.ToLower().Contains(keyword.ToLower()) ||
                x.Mobile.ToLower().Contains(keyword.ToLower())).ToList();
                dataForSearch.DataSource = filtered;
                dataForSearch.Refresh();
                db.SaveChanges();
            }
        }
    }
}
