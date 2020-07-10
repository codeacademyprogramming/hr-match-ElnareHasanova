using HR_match.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_match
{
    public partial class Form5 : Form
    {
        int currentId;
        Employee crntEmp = new Employee();
        CV cV = new CV();
        Vacancie vacancie = new Vacancie();
        public Form5()
        {
            InitializeComponent();
        }


        public void GetCurrentEmployee(int id)
        {
            using (HRContext db = new HRContext())
            {
                currentId = id;
                crntEmp = db.Employees.FirstOrDefault(x => x.Id == currentId);
            }
        }

        void GetMyCv()
        {
            using (HRContext db = new HRContext())
            {
                var myCv = db.CVs.FirstOrDefault(c => c.EmployeeId == crntEmp.Id);
                name.Text = myCv.Name;
                surname.Text = myCv.Surname;
                age.Text = myCv.Age.ToString();
                gender.Text = (string)myCv.Gender;
                study.Text = myCv.Study;
                workexperience.Text = myCv.WorkExperience;
                category.Text = myCv.Category;
                city.Text = myCv.City;
                minimumSalary.Text = myCv.MininumSalary.ToString();
                telephone.Text = myCv.Mobile;
            }

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            vacancieList.Hide();
            dataForSearch.Hide();
            searchBox.Hide();
            searchButton.Hide();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.Show();
        }

        private void about_me_Click(object sender, EventArgs e)
        {
            dataForSearch.Hide();
            vacancieList.Hide();
            appliedVacancies.Hide();
            dataGridView1.Show();
            GetMyCv();
        }

        private void see_all_vacancies_Click(object sender, EventArgs e)
        {
            dataForSearch.Hide();
            dataGridView1.Hide();
            vacancieList.BringToFront();
            vacancieList.Show();
            using (HRContext db = new HRContext())
            {

                var result = (from v in db.Vacancies
                              join hr in db.HRs on v.HrId equals hr.Id
                              select new
                              {
                                  v.VacancieName,
                                  v.CompanyName,
                                  v.Category,
                                  v.Description,
                                  v.Age,
                                  v.Study,
                                  v.WorkExperience,
                                  v.City,
                                  v.Salary,
                                  v.Mobile,
                                  hr.Username
                              }).ToList();
                vacancieList.DataSource = result;
                vacancieList.Refresh();
                db.SaveChanges();
            }
        }

        private void search_job_Click(object sender, EventArgs e)
        {
            vacancieList.Hide();
            appliedVacancies.Hide();
            dataForSearch.Show();
            searchBox.Show();
            searchButton.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (HRContext db = new HRContext())
            {
                var keyword = searchBox.Text;
                var result = (from v in db.Vacancies
                              join hr in db.HRs on v.HrId equals hr.Id
                              select new
                              {
                                  v.VacancieName,
                                  v.CompanyName,
                                  v.Category,
                                  v.Description,
                                  v.Age,
                                  v.Study,
                                  v.WorkExperience,
                                  v.City,
                                  v.Salary,
                                  v.Mobile,
                                  hr.Username
                              }).ToList();
                var filtered = result.Where(x => x.VacancieName.ToLower().Contains(keyword.ToLower()) ||
                x.CompanyName.ToLower().Contains(keyword.ToLower()) ||
                x.Category.ToLower().Contains(keyword.ToLower()) ||
                x.Description.ToLower().Contains(keyword.ToLower()) ||
                x.Study.ToLower().Contains(keyword.ToLower()) ||
                x.WorkExperience.ToLower().Contains(keyword.ToLower()) ||
                x.City.ToLower().Contains(keyword.ToLower()) ||
                x.Username.ToLower().Contains(keyword.ToLower())).ToList();
                dataForSearch.DataSource = filtered;
                dataForSearch.Refresh();
                db.SaveChanges();
            }
        }

        private void vacancieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (HRContext db = new HRContext())
            {

                for (int i = 0; i < vacancieList.Rows.Count; i++)
                {
                    var currentCell = vacancieList.Rows[i].Cells[0];
                    var nameCell = vacancieList.Rows[i].Cells[1];

                    var selectedVacancie = db.Vacancies.FirstOrDefault(v => v.VacancieName == nameCell.Value.ToString());

                    if (currentCell.Selected)
                    {

                        // crntEmp - sign in eden iscidir. current Employer

                        crntEmp.Vacancies.Add(selectedVacancie);
                        vacancie.Employees.Add(crntEmp);
                        db.SaveChanges();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            dataForSearch.Hide();
            dataGridView1.Hide();
            appliedVacancies.Hide();
            vacancieList.BringToFront();
            vacancieList.Show();



            using (HRContext db = new HRContext())
            {
                var myCv = db.CVs.FirstOrDefault(x => x.EmployeeId == crntEmp.Id);


                var result = (from v in db.Vacancies
                              join hr in db.HRs on v.HrId equals hr.Id
                              select new
                              {
                                  v.VacancieName,
                                  v.CompanyName,
                                  v.Category,
                                  v.Description,
                                  v.Age,
                                  v.Study,
                                  v.WorkExperience,
                                  v.City,
                                  v.Salary,
                                  v.Mobile,
                                  hr.Username
                              }).ToList();

                var recommented = result.Where(v => v.VacancieName.Equals(myCv.Category) ||
                v.Category.Equals(myCv.Category) ||
                v.Age.Equals(myCv.Age) ||
                v.Study.Equals(myCv.Study) ||
                v.WorkExperience.Equals(myCv.WorkExperience) ||
                v.City.Equals(myCv.City) ||
                v.Salary.Equals(myCv.MininumSalary)).ToList();

                vacancieList.DataSource = recommented;
                vacancieList.Refresh();
                db.SaveChanges();
            }
        }

        private void applied_vacancies_Click(object sender, EventArgs e)
        {
            dataForSearch.Hide();
            dataGridView1.Hide();
            vacancieList.Hide();
            appliedVacancies.BringToFront();
            appliedVacancies.Show();

            using (HRContext db = new HRContext())
            {
                //var result = (from v in crntEmp.Vacancies
                //              select new
                //              {
                //                  v.Id,
                //                  v.VacancieName,
                //                  v.CompanyName,
                //                  v.Category,
                //                  v.Description,
                //                  v.Age,
                //                  v.Study,
                //                  v.WorkExperience,
                //                  v.City,
                //                  v.Salary,
                //                  v.Mobile
                //              }).ToList();

                var result = crntEmp.Vacancies.ToList();

                appliedVacancies.DataSource = result;
                appliedVacancies.Refresh();
                db.SaveChanges();
            }
        }
    }
}
