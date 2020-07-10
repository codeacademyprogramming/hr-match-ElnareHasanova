using HR_match.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_match
{
    public partial class Form2 : Form
    {

        Employee employee = new Employee();
        HR hR = new HR();
        public int randomLength = 4;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            random.Text = GenerateRandomCode().ToString();
        }

        void Clear()
        {
            username.Text = email.Text = status.Text = password.Text = repassword.Text = type_random.Text = random.Text = "";
        }

        public static string GenerateRandomCode(int length = 4)
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public bool IsValidEmail(string em)
        {
            Regex pattern = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,4}$");
            bool valid = false;
            valid = pattern.IsMatch(em);

            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Enter valid email address");
                email.Text = "";
                return valid;
            }

        }

        public bool IsValidPassword(string p)
        {
            Regex pattern = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,15}$");
            bool valid = false;
            valid = pattern.IsMatch(p);

            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Password has to contain at least - one upper case character, one lower case character, one digit. Length of password must be 4 - 15.");
                password.Text = "";
                return valid;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (HRContext db = new HRContext())
            {
                bool em = IsValidEmail(email.Text);
                bool p = IsValidPassword(password.Text);

                if (em == false || p == false)
                {
                    return;
                }
                else
                {
                    if (username.Text == "" ||
                    email.Text == "" ||
                    status.SelectedIndex == -1 ||
                    password.Text == "" ||
                    repassword.Text == "" ||
                    type_random.Text == "")
                    {
                        MessageBox.Show("Fill out all fields!");
                    }
                    else
                    {

                        if (password.Text != repassword.Text)
                        {
                            MessageBox.Show("Password and repassword do not match.");
                        }
                        else
                        {
                            if (random.Text != type_random.Text)
                            {
                                MessageBox.Show("Confirm that you are a human.");
                            }
                            else
                            {
                                if (status.SelectedIndex == 0)
                                {
                                    employee.Username = username.Text;
                                    employee.Email = email.Text;
                                    employee.Status = (string)status.SelectedItem;
                                    employee.Password = password.Text;
                                    db.Employees.Add(employee);
                                    db.SaveChanges();
                                    MessageBox.Show("Employee account submited successfuly");
                                    Clear();
                                    Form4 form4 = new Form4();
                                    form4.Show();
                                    form4.GetCurrentEmp(employee.Id);
                                }
                                else if (status.SelectedIndex == 1)
                                {
                                    hR.Username = username.Text;
                                    hR.Email = email.Text;
                                    hR.Status = (string)status.SelectedItem;
                                    hR.Password = password.Text;
                                    db.HRs.Add(hR);
                                    db.SaveChanges();
                                    MessageBox.Show("HR account submited successfuly");
                                    Clear();
                                }
                            }

                        }
                    }
                }

            }
        }

    }
}
