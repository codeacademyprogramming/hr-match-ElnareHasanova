namespace HR_match
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.about_me = new System.Windows.Forms.ToolStripMenuItem();
            this.applied_vacancies = new System.Windows.Forms.ToolStripMenuItem();
            this.search_job = new System.Windows.Forms.ToolStripMenuItem();
            this.recommendation = new System.Windows.Forms.ToolStripMenuItem();
            this.see_all_vacancies = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
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
            this.age = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.study = new System.Windows.Forms.TextBox();
            this.workexperience = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.minimumSalary = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancieList = new System.Windows.Forms.DataGridView();
            this.Applie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataForSearch = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.vacancieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vacancieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vacancieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appliedVacancies = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliedVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_me,
            this.applied_vacancies,
            this.search_job,
            this.recommendation,
            this.see_all_vacancies,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // about_me
            // 
            this.about_me.Name = "about_me";
            this.about_me.Size = new System.Drawing.Size(72, 20);
            this.about_me.Text = "About me";
            this.about_me.Click += new System.EventHandler(this.about_me_Click);
            // 
            // applied_vacancies
            // 
            this.applied_vacancies.Name = "applied_vacancies";
            this.applied_vacancies.Size = new System.Drawing.Size(114, 20);
            this.applied_vacancies.Text = "Applied vacancies";
            this.applied_vacancies.Click += new System.EventHandler(this.applied_vacancies_Click);
            // 
            // search_job
            // 
            this.search_job.Name = "search_job";
            this.search_job.Size = new System.Drawing.Size(74, 20);
            this.search_job.Text = "Search job";
            this.search_job.Click += new System.EventHandler(this.search_job_Click);
            // 
            // recommendation
            // 
            this.recommendation.Name = "recommendation";
            this.recommendation.Size = new System.Drawing.Size(114, 20);
            this.recommendation.Text = "Recommendation";
            this.recommendation.Click += new System.EventHandler(this.recommendation_Click);
            // 
            // see_all_vacancies
            // 
            this.see_all_vacancies.Name = "see_all_vacancies";
            this.see_all_vacancies.Size = new System.Drawing.Size(106, 20);
            this.see_all_vacancies.Text = "See all vacancies";
            this.see_all_vacancies.Click += new System.EventHandler(this.see_all_vacancies_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 20);
            this.logout.Text = "Log out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(175, 94);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(120, 20);
            this.name.TabIndex = 35;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(175, 140);
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Size = new System.Drawing.Size(120, 20);
            this.surname.TabIndex = 36;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(489, 184);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(120, 20);
            this.city.TabIndex = 42;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(489, 269);
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Size = new System.Drawing.Size(120, 20);
            this.telephone.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Study";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Work experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Minimum salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Mobile telephone";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(175, 188);
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(120, 20);
            this.age.TabIndex = 55;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(175, 231);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(120, 20);
            this.gender.TabIndex = 56;
            // 
            // study
            // 
            this.study.Location = new System.Drawing.Point(175, 276);
            this.study.Name = "study";
            this.study.ReadOnly = true;
            this.study.Size = new System.Drawing.Size(120, 20);
            this.study.TabIndex = 57;
            // 
            // workexperience
            // 
            this.workexperience.Location = new System.Drawing.Point(489, 94);
            this.workexperience.Name = "workexperience";
            this.workexperience.ReadOnly = true;
            this.workexperience.Size = new System.Drawing.Size(120, 20);
            this.workexperience.TabIndex = 58;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(489, 140);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(120, 20);
            this.category.TabIndex = 59;
            // 
            // minimumSalary
            // 
            this.minimumSalary.Location = new System.Drawing.Point(489, 224);
            this.minimumSalary.Name = "minimumSalary";
            this.minimumSalary.ReadOnly = true;
            this.minimumSalary.Size = new System.Drawing.Size(120, 20);
            this.minimumSalary.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 357);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HR";
            this.dataGridViewTextBoxColumn1.HeaderText = "Created by";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // vacancieList
            // 
            this.vacancieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacancieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Applie});
            this.vacancieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vacancieList.Location = new System.Drawing.Point(0, 24);
            this.vacancieList.Name = "vacancieList";
            this.vacancieList.Size = new System.Drawing.Size(771, 357);
            this.vacancieList.TabIndex = 61;
            this.vacancieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vacancieList_CellContentClick);
            // 
            // Applie
            // 
            this.Applie.HeaderText = "Applie";
            this.Applie.Name = "Applie";
            // 
            // dataForSearch
            // 
            this.dataForSearch.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataForSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataForSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataForSearch.Location = new System.Drawing.Point(0, 57);
            this.dataForSearch.Name = "dataForSearch";
            this.dataForSearch.Size = new System.Drawing.Size(771, 324);
            this.dataForSearch.TabIndex = 62;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(575, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(191, 20);
            this.searchBox.TabIndex = 63;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(432, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 23);
            this.searchButton.TabIndex = 64;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // vacancieBindingSource2
            // 
            this.vacancieBindingSource2.DataSource = typeof(HR_match.Models.Vacancie);
            // 
            // vacancieBindingSource1
            // 
            this.vacancieBindingSource1.DataSource = typeof(HR_match.Models.Vacancie);
            // 
            // vacancieBindingSource
            // 
            this.vacancieBindingSource.DataSource = typeof(HR_match.Models.Vacancie);
            // 
            // cVBindingSource
            // 
            this.cVBindingSource.DataSource = typeof(HR_match.Models.CV);
            // 
            // hRBindingSource
            // 
            this.hRBindingSource.DataSource = typeof(HR_match.Models.HR);
            // 
            // appliedVacancies
            // 
            this.appliedVacancies.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.appliedVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliedVacancies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appliedVacancies.Location = new System.Drawing.Point(0, 24);
            this.appliedVacancies.Name = "appliedVacancies";
            this.appliedVacancies.Size = new System.Drawing.Size(771, 33);
            this.appliedVacancies.TabIndex = 65;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(771, 381);
            this.Controls.Add(this.appliedVacancies);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataForSearch);
            this.Controls.Add(this.vacancieList);
            this.Controls.Add(this.minimumSalary);
            this.Controls.Add(this.category);
            this.Controls.Add(this.workexperience);
            this.Controls.Add(this.study);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
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
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliedVacancies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem about_me;
        private System.Windows.Forms.ToolStripMenuItem applied_vacancies;
        private System.Windows.Forms.ToolStripMenuItem search_job;
        private System.Windows.Forms.ToolStripMenuItem recommendation;
        private System.Windows.Forms.ToolStripMenuItem see_all_vacancies;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox telephone;
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
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox study;
        private System.Windows.Forms.TextBox workexperience;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox minimumSalary;
        private System.Windows.Forms.BindingSource vacancieBindingSource;
        private System.Windows.Forms.BindingSource cVBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vacancieBindingSource1;
        private System.Windows.Forms.BindingSource hRBindingSource;
        private System.Windows.Forms.BindingSource vacancieBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView vacancieList;
        private System.Windows.Forms.DataGridViewButtonColumn Applie;
        private System.Windows.Forms.DataGridView dataForSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView appliedVacancies;
    }
}