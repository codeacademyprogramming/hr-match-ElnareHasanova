namespace HR_match
{
    partial class Form8
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
            this.label11 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.salary = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.telephone = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.workExperience = new System.Windows.Forms.ComboBox();
            this.study = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameOfCompany = new System.Windows.Forms.TextBox();
            this.nameOfVacancie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 110;
            this.label11.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(253, 210);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(121, 67);
            this.description.TabIndex = 109;
            this.description.Text = "";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(254, 345);
            this.salary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(120, 20);
            this.salary.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 107;
            this.label10.Text = "Contact phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 104;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Work experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Study";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Age";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(568, 323);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 42);
            this.submit.TabIndex = 100;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(567, 236);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(120, 20);
            this.telephone.TabIndex = 99;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(254, 307);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(120, 20);
            this.city.TabIndex = 98;
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
            this.category.Location = new System.Drawing.Point(253, 172);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 97;
            // 
            // workExperience
            // 
            this.workExperience.FormattingEnabled = true;
            this.workExperience.Items.AddRange(new object[] {
            "Less than a year",
            "1-3 years",
            "5 years or more"});
            this.workExperience.Location = new System.Drawing.Point(568, 185);
            this.workExperience.Name = "workExperience";
            this.workExperience.Size = new System.Drawing.Size(121, 21);
            this.workExperience.TabIndex = 96;
            // 
            // study
            // 
            this.study.FormattingEnabled = true;
            this.study.Items.AddRange(new object[] {
            "Higher education",
            "Incomplete higher education",
            "Secondary education"});
            this.study.Location = new System.Drawing.Point(567, 131);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(121, 21);
            this.study.TabIndex = 95;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(568, 86);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(120, 20);
            this.age.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Name of Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Name of vacancie";
            // 
            // nameOfCompany
            // 
            this.nameOfCompany.Location = new System.Drawing.Point(253, 132);
            this.nameOfCompany.Name = "nameOfCompany";
            this.nameOfCompany.Size = new System.Drawing.Size(120, 20);
            this.nameOfCompany.TabIndex = 91;
            // 
            // nameOfVacancie
            // 
            this.nameOfVacancie.Location = new System.Drawing.Point(252, 86);
            this.nameOfVacancie.Name = "nameOfVacancie";
            this.nameOfVacancie.Size = new System.Drawing.Size(120, 20);
            this.nameOfVacancie.TabIndex = 90;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.description);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.category);
            this.Controls.Add(this.workExperience);
            this.Controls.Add(this.study);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOfCompany);
            this.Controls.Add(this.nameOfVacancie);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.NumericUpDown salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox workExperience;
        private System.Windows.Forms.ComboBox study;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameOfCompany;
        private System.Windows.Forms.TextBox nameOfVacancie;
    }
}