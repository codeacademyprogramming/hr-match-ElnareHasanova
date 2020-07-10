namespace HR_match
{
    partial class Form7
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
            this.create_vacancie = new System.Windows.Forms.ToolStripMenuItem();
            this.applications = new System.Windows.Forms.ToolStripMenuItem();
            this.search_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.application = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataForSearch = new System.Windows.Forms.DataGridView();
            this.vacancieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vacancieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.application)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_vacancie,
            this.applications,
            this.search_employee,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // create_vacancie
            // 
            this.create_vacancie.Name = "create_vacancie";
            this.create_vacancie.Size = new System.Drawing.Size(111, 20);
            this.create_vacancie.Text = "Create a vacancie";
            this.create_vacancie.Click += new System.EventHandler(this.create_vacancie_Click);
            // 
            // applications
            // 
            this.applications.Name = "applications";
            this.applications.Size = new System.Drawing.Size(85, 20);
            this.applications.Text = "Applications";
            this.applications.Click += new System.EventHandler(this.applications_Click);
            // 
            // search_employee
            // 
            this.search_employee.Name = "search_employee";
            this.search_employee.Size = new System.Drawing.Size(125, 20);
            this.search_employee.Text = "Search an employee";
            this.search_employee.Click += new System.EventHandler(this.search_employee_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 20);
            this.logout.Text = "Log out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // application
            // 
            this.application.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.application.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.application.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vacancieBindingSource1, "VacancieName", true));
            this.application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.application.Location = new System.Drawing.Point(0, 24);
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(770, 428);
            this.application.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(434, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 23);
            this.searchButton.TabIndex = 67;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(577, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(191, 20);
            this.searchBox.TabIndex = 66;
            // 
            // dataForSearch
            // 
            this.dataForSearch.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataForSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataForSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataForSearch.Location = new System.Drawing.Point(0, 56);
            this.dataForSearch.Name = "dataForSearch";
            this.dataForSearch.Size = new System.Drawing.Size(770, 396);
            this.dataForSearch.TabIndex = 65;
            // 
            // vacancieBindingSource1
            // 
            this.vacancieBindingSource1.DataSource = typeof(HR_match.Models.Vacancie);
            // 
            // vacancieBindingSource
            // 
            this.vacancieBindingSource.DataSource = typeof(HR_match.Models.Vacancie);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 452);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataForSearch);
            this.Controls.Add(this.application);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.application)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView application;
        private System.Windows.Forms.ToolStripMenuItem create_vacancie;
        private System.Windows.Forms.ToolStripMenuItem applications;
        private System.Windows.Forms.ToolStripMenuItem search_employee;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.BindingSource vacancieBindingSource1;
        private System.Windows.Forms.BindingSource vacancieBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataForSearch;
    }
}