using System;
using System.Windows.Forms;
namespace HotelManagementApplication
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffIdtb = new System.Windows.Forms.TextBox();
            this.StaffNametb = new System.Windows.Forms.TextBox();
            this.PhoneNumbertb = new System.Windows.Forms.TextBox();
            this.Gendercb = new System.Windows.Forms.ComboBox();
            this.AddStaffBtn = new System.Windows.Forms.Button();
            this.EditStaffBtn = new System.Windows.Forms.Button();
            this.DeleteStaffBtn = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StaffView = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 133);
            this.panel1.TabIndex = 0;
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(1138, 81);
            this.Datelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(76, 33);
            this.Datelb.TabIndex = 1;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F);
            this.label1.Location = new System.Drawing.Point(563, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StaffIdtb
            // 
            this.StaffIdtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffIdtb.Location = new System.Drawing.Point(276, 221);
            this.StaffIdtb.Margin = new System.Windows.Forms.Padding(4);
            this.StaffIdtb.Name = "StaffIdtb";
            this.StaffIdtb.Size = new System.Drawing.Size(203, 30);
            this.StaffIdtb.TabIndex = 1;
            this.StaffIdtb.Text = "Staff Id";
            // 
            // StaffNametb
            // 
            this.StaffNametb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffNametb.Location = new System.Drawing.Point(276, 272);
            this.StaffNametb.Margin = new System.Windows.Forms.Padding(4);
            this.StaffNametb.Name = "StaffNametb";
            this.StaffNametb.Size = new System.Drawing.Size(203, 30);
            this.StaffNametb.TabIndex = 2;
            this.StaffNametb.Text = "Staff Name";
            // 
            // PhoneNumbertb
            // 
            this.PhoneNumbertb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PhoneNumbertb.Location = new System.Drawing.Point(276, 325);
            this.PhoneNumbertb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumbertb.Name = "PhoneNumbertb";
            this.PhoneNumbertb.Size = new System.Drawing.Size(203, 30);
            this.PhoneNumbertb.TabIndex = 3;
            this.PhoneNumbertb.Text = "Phone Number";
            // 
            // Gendercb
            // 
            this.Gendercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Gendercb.FormattingEnabled = true;
            this.Gendercb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Gendercb.Location = new System.Drawing.Point(276, 426);
            this.Gendercb.Margin = new System.Windows.Forms.Padding(4);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.Size = new System.Drawing.Size(203, 33);
            this.Gendercb.TabIndex = 4;
            this.Gendercb.Text = "Gender";
            // 
            // AddStaffBtn
            // 
            this.AddStaffBtn.FlatAppearance.BorderSize = 0;
            this.AddStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddStaffBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddStaffBtn.Location = new System.Drawing.Point(241, 501);
            this.AddStaffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddStaffBtn.Name = "AddStaffBtn";
            this.AddStaffBtn.Size = new System.Drawing.Size(70, 38);
            this.AddStaffBtn.TabIndex = 6;
            this.AddStaffBtn.Text = "ADD";
            this.AddStaffBtn.UseVisualStyleBackColor = true;
            this.AddStaffBtn.Click += new System.EventHandler(this.AddStaffBtn_Click);
            // 
            // EditStaffBtn
            // 
            this.EditStaffBtn.FlatAppearance.BorderSize = 0;
            this.EditStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EditStaffBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditStaffBtn.Location = new System.Drawing.Point(319, 501);
            this.EditStaffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditStaffBtn.Name = "EditStaffBtn";
            this.EditStaffBtn.Size = new System.Drawing.Size(70, 38);
            this.EditStaffBtn.TabIndex = 7;
            this.EditStaffBtn.Text = "EDIT";
            this.EditStaffBtn.UseVisualStyleBackColor = true;
            this.EditStaffBtn.Click += new System.EventHandler(this.EditStaffBtn_Click);
            // 
            // DeleteStaffBtn
            // 
            this.DeleteStaffBtn.FlatAppearance.BorderSize = 0;
            this.DeleteStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteStaffBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteStaffBtn.Location = new System.Drawing.Point(397, 501);
            this.DeleteStaffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteStaffBtn.Name = "DeleteStaffBtn";
            this.DeleteStaffBtn.Size = new System.Drawing.Size(105, 38);
            this.DeleteStaffBtn.TabIndex = 8;
            this.DeleteStaffBtn.Text = "DELETE";
            this.DeleteStaffBtn.UseVisualStyleBackColor = true;
            this.DeleteStaffBtn.Click += new System.EventHandler(this.DeleteStaffBtn_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Searchtb.Location = new System.Drawing.Point(924, 173);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(4);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(203, 30);
            this.Searchtb.TabIndex = 9;
            this.Searchtb.Text = "Staff Name";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(1135, 167);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 41);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Passwordtb
            // 
            this.Passwordtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Passwordtb.Location = new System.Drawing.Point(276, 375);
            this.Passwordtb.Margin = new System.Windows.Forms.Padding(4);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(203, 30);
            this.Passwordtb.TabIndex = 11;
            this.Passwordtb.Text = "Password";
            // 
            // refreshpb
            // 
            this.refreshpb.Image = global::HotelManagementApplication.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(1233, 173);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(35, 32);
            this.refreshpb.TabIndex = 12;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // StaffView
            // 
            this.StaffView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.Staffname,
            this.Staffphone,
            this.Gender,
            this.Staffpassword});
            this.StaffView.Location = new System.Drawing.Point(590, 221);
            this.StaffView.Margin = new System.Windows.Forms.Padding(4);
            this.StaffView.Name = "StaffView";
            this.StaffView.RowHeadersWidth = 51;
            this.StaffView.RowTemplate.Height = 25;
            this.StaffView.Size = new System.Drawing.Size(678, 410);
            this.StaffView.TabIndex = 5;
            this.StaffView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_DoubleClick);
            // 
            // StaffId
            // 
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "StaffId";
            this.StaffId.MinimumWidth = 6;
            this.StaffId.Name = "StaffId";
            this.StaffId.Width = 125;
            // 
            // Staffname
            // 
            this.Staffname.DataPropertyName = "Staffname";
            this.Staffname.HeaderText = "Staffname";
            this.Staffname.MinimumWidth = 6;
            this.Staffname.Name = "Staffname";
            this.Staffname.Width = 125;
            // 
            // Staffphone
            // 
            this.Staffphone.DataPropertyName = "Staffphone";
            this.Staffphone.HeaderText = "Staffphone";
            this.Staffphone.MinimumWidth = 6;
            this.Staffphone.Name = "Staffphone";
            this.Staffphone.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Staffpassword
            // 
            this.Staffpassword.DataPropertyName = "Staffpassword";
            this.Staffpassword.HeaderText = "Password";
            this.Staffpassword.MinimumWidth = 6;
            this.Staffpassword.Name = "Staffpassword";
            this.Staffpassword.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 592);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.DeleteStaffBtn);
            this.Controls.Add(this.EditStaffBtn);
            this.Controls.Add(this.AddStaffBtn);
            this.Controls.Add(this.StaffView);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.PhoneNumbertb);
            this.Controls.Add(this.StaffNametb);
            this.Controls.Add(this.StaffIdtb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox StaffNametb;
        private TextBox PhoneNumbertb;
        private ComboBox Gendercb;
        private Button AddStaffBtn;
        private Button EditStaffBtn;
        private Button DeleteStaffBtn;
        private TextBox Searchtb;
        private Button Search;
        private TextBox Passwordtb;
        private PictureBox refreshpb;
        private Label Datelb;
        private System.Windows.Forms.Timer timer1;
        private DataGridView StaffView;
        public TextBox StaffIdtb;
        private DataGridViewTextBoxColumn StaffId;
        private DataGridViewTextBoxColumn Staffname;
        private DataGridViewTextBoxColumn Staffphone;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Staffpassword;
        private PictureBox pictureBox1;
    }
}