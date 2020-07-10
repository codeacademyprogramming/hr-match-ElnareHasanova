using HR_match.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_match
{
    public partial class Form4 : Form
    {
        HRContext db = new HRContext();

        CV cV = new CV();
        Employee crntEmp = new Employee();
        int currentId;
        public Form4()
        {
            InitializeComponent();
        }
        public void GetCurrentEmp(int id)
        {
            using (db)
            {
                currentId = id;
                crntEmp = db.Employees.FirstOrDefault(x => x.Id == currentId);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Clear();
        }



        void Clear()
        {
            name.Text = surname.Text = gender.Text = study.Text = workExperience.Text = category.Text = city.Text = telephone.Text = "";
            age.Value = minSalary.Value = 0;
        }

        //public bool IsTelephoneValid(string tel)
        //{
        //    Regex pattern = new Regex(@"^([+]994)?([70]|[50]|[51]|[55])\d{7}$");
        //    bool valid = false;
        //    valid = pattern.IsMatch(tel);

        //    if (valid == true)
        //    {
        //        return valid;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Enter valid telephone number");
        //        telephone.Text = "";
        //        return valid;
        //    }
        //}

        void Run()
        {
            using (HRContext db = new HRContext())
            {
                cV.Name = name.Text;
                cV.Surname = surname.Text;
                cV.Age = (int)age.Value;
                cV.Gender = (string)gender.SelectedItem;
                cV.Study = (string)study.SelectedItem;
                cV.WorkExperience = (string)workExperience.SelectedItem;
                cV.Category = (string)category.SelectedItem;
                cV.City = city.Text;
                cV.MininumSalary = (int)minSalary.Value;
                cV.Mobile = telephone.Text;
                cV.EmployeeId = crntEmp.Id;
                
                db.CVs.Add(cV);
                db.SaveChanges();

                Form5 menuEmp = new Form5();
                menuEmp.Show();
                menuEmp.GetCurrentEmployee(currentId);

            }

        }



        public void FillOutForm()
        {
            if (age.Value == 0 ||
                gender.SelectedIndex == -1||
                study.SelectedIndex == -1 ||
                workExperience.SelectedIndex == -1 ||
                category.SelectedIndex == -1 ||
                minSalary.Value == 0||
                name.Text == "" ||
                surname.Text == ""||
                gender.Text == ""||
                study.Text ==""||
                workExperience.Text == ""||
                category.Text == ""||
                city.Text == ""||
                telephone.Text == "")
            {
                MessageBox.Show("Fill out all fields!");
            }
            else
            {
                Run();
            }
        }


        private void submit_Click(object sender, EventArgs e)
        {
            using (db)
            {
                //IsTelephoneValid(telephone.Text);
                FillOutForm();
            }
        }
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
