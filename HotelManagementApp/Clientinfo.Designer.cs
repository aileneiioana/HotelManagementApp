using System.Windows.Forms;

namespace HotelManagementApplication
{
    partial class Clientinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientidtbl = new System.Windows.Forms.RichTextBox();
            this.clientnametbl = new System.Windows.Forms.RichTextBox();
            this.clientphonetb = new System.Windows.Forms.RichTextBox();
            this.clientctrytb = new System.Windows.Forms.ComboBox();
            this.ClientGridview = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClientSearchtb = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 81);
            this.panel1.TabIndex = 0;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelbl.Location = new System.Drawing.Point(856, 40);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(59, 25);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F);
            this.label1.Location = new System.Drawing.Point(402, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // clientidtbl
            // 
            this.clientidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientidtbl.Location = new System.Drawing.Point(138, 151);
            this.clientidtbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(160, 28);
            this.clientidtbl.TabIndex = 1;
            this.clientidtbl.Text = "ClientId";
            // 
            // clientnametbl
            // 
            this.clientnametbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientnametbl.Location = new System.Drawing.Point(138, 189);
            this.clientnametbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(160, 29);
            this.clientnametbl.TabIndex = 2;
            this.clientnametbl.Text = "ClientName";
            // 
            // clientphonetb
            // 
            this.clientphonetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientphonetb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientphonetb.Location = new System.Drawing.Point(138, 230);
            this.clientphonetb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientphonetb.Name = "clientphonetb";
            this.clientphonetb.Size = new System.Drawing.Size(160, 30);
            this.clientphonetb.TabIndex = 3;
            this.clientphonetb.Text = "Phone Number";
            // 
            // clientctrytb
            // 
            this.clientctrytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientctrytb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientctrytb.FormattingEnabled = true;
            this.clientctrytb.Items.AddRange(new object[] {
            "ROMANIA",
            "SPAIN",
            "USA",
            "CHINA",
            "FRANCE",
            "ITALY"});
            this.clientctrytb.Location = new System.Drawing.Point(138, 272);
            this.clientctrytb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientctrytb.Name = "clientctrytb";
            this.clientctrytb.Size = new System.Drawing.Size(160, 28);
            this.clientctrytb.TabIndex = 4;
            this.clientctrytb.Text = "Country";
            // 
            // ClientGridview
            // 
            this.ClientGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.PhoneNum,
            this.Country});
            this.ClientGridview.Location = new System.Drawing.Point(370, 151);
            this.ClientGridview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersWidth = 51;
            this.ClientGridview.RowTemplate.Height = 29;
            this.ClientGridview.Size = new System.Drawing.Size(553, 333);
            this.ClientGridview.TabIndex = 5;
            this.ClientGridview.DoubleClick += new System.EventHandler(this.ClientGridview_DoubleClick);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(107, 323);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(60, 33);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(172, 323);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(60, 33);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(236, 323);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 33);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClientSearchtb
            // 
            this.ClientSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientSearchtb.Location = new System.Drawing.Point(615, 107);
            this.ClientSearchtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientSearchtb.Name = "ClientSearchtb";
            this.ClientSearchtb.Size = new System.Drawing.Size(160, 32);
            this.ClientSearchtb.TabIndex = 9;
            this.ClientSearchtb.Text = "ClientSearch";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(778, 102);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(98, 36);
            this.Search.TabIndex = 10;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(881, 102);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(32, 34);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 11;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 493);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.MinimumWidth = 6;
            this.ClientId.Name = "ClientId";
            this.ClientId.Width = 125;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 125;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "ClientPhone";
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "ClientCountry";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClientSearchtb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.clientctrytb);
            this.Controls.Add(this.clientphonetb);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientinfo";
            this.Load += new System.EventHandler(this.Clientinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RichTextBox clientidtbl;
        private RichTextBox clientnametbl;
        private RichTextBox clientphonetb;
        private ComboBox clientctrytb;
        private DataGridView ClientGridview;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private RichTextBox ClientSearchtb;
        private Button Search;
        private Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox refreshpb;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn PhoneNum;
        private DataGridViewTextBoxColumn Country;
    }
}