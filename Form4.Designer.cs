namespace HR_match
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.gender = new System.Windows.Forms.ComboBox();
            this.study = new System.Windows.Forms.ComboBox();
            this.workExperience = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minSalary = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(171, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(171, 119);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(120, 20);
            this.surname.TabIndex = 1;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(172, 163);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(120, 20);
            this.age.TabIndex = 2;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gender.Location = new System.Drawing.Point(171, 203);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 3;
            // 
            // study
            // 
            this.study.FormattingEnabled = true;
            this.study.Items.AddRange(new object[] {
            "Higher education",
            "Incomplete higher education",
            "Secondary education"});
            this.study.Location = new System.Drawing.Point(171, 247);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(121, 21);
            this.study.TabIndex = 4;
            // 
            // workExperience
            // 
            this.workExperience.FormattingEnabled = true;
            this.workExperience.Items.AddRange(new object[] {
            "Less than a year",
            "1-3 years",
            "5 years or more"});
            this.workExperience.Location = new System.Drawing.Point(485, 72);
            this.workExperience.Name = "workExperience";
            this.workExperience.Size = new System.Drawing.Size(121, 21);
            this.workExperience.TabIndex = 5;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Finance",
            "Marketing",
            "Information Technology",
            "Admininstration and management",
            "Sales",
            "Design",
            "Legal",
            "Education and Science",
            "Industry and Agriculture",
            "Services",
            "Medicine and Pharmacy",
            "Other"});
            this.category.Location = new System.Drawing.Point(486, 118);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 6;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(485, 163);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(120, 20);
            this.city.TabIndex = 7;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(485, 248);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(120, 20);
            this.telephone.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(486, 323);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 42);
            this.submit.TabIndex = 19;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Study";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Work experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Minimum salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mobile telephone";
            // 
            // minSalary
            // 
            this.minSalary.Location = new System.Drawing.Point(487, 203);
            this.minSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(120, 20);
            this.minSalary.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Create CV";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 389);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.minSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.category);
            this.Controls.Add(this.workExperience);
            this.Controls.Add(this.study);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox study;
        private System.Windows.Forms.ComboBox workExperience;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown minSalary;
        private System.Windows.Forms.Label label11;
    }
}