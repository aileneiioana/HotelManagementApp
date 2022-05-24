namespace HotelManagementApplication
{
    partial class RoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomGridview = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            this.RoomSearchtbl = new System.Windows.Forms.RichTextBox();
            this.roomphonetbl = new System.Windows.Forms.RichTextBox();
            this.roomidtbl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yesbtn = new System.Windows.Forms.RadioButton();
            this.Noradio = new System.Windows.Forms.RadioButton();
            this.Yesradio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 100);
            this.panel1.TabIndex = 1;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century", 17.25F);
            this.Datelbl.Location = new System.Drawing.Point(1083, 55);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(80, 34);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F);
            this.label1.Location = new System.Drawing.Point(506, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomGridview
            // 
            this.RoomGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomPhone,
            this.RoomFree});
            this.RoomGridview.Location = new System.Drawing.Point(636, 219);
            this.RoomGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersWidth = 51;
            this.RoomGridview.RowTemplate.Height = 29;
            this.RoomGridview.Size = new System.Drawing.Size(573, 358);
            this.RoomGridview.TabIndex = 6;
            this.RoomGridview.DoubleClick += new System.EventHandler(this.RoomGridview_DoubleClick);
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomId";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // RoomPhone
            // 
            this.RoomPhone.DataPropertyName = "RoomPhone";
            this.RoomPhone.HeaderText = "RoomPhone";
            this.RoomPhone.MinimumWidth = 6;
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.Width = 125;
            // 
            // RoomFree
            // 
            this.RoomFree.DataPropertyName = "RoomFree";
            this.RoomFree.HeaderText = "RoomFree";
            this.RoomFree.MinimumWidth = 6;
            this.RoomFree.Name = "RoomFree";
            this.RoomFree.Width = 125;
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(1125, 164);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(42, 42);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 14;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(978, 170);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(141, 36);
            this.Search.TabIndex = 13;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RoomSearchtbl
            // 
            this.RoomSearchtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearchtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomSearchtbl.Location = new System.Drawing.Point(760, 170);
            this.RoomSearchtbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomSearchtbl.Name = "RoomSearchtbl";
            this.RoomSearchtbl.Size = new System.Drawing.Size(212, 36);
            this.RoomSearchtbl.TabIndex = 12;
            this.RoomSearchtbl.Text = "RoomSearch";
            // 
            // roomphonetbl
            // 
            this.roomphonetbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomphonetbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomphonetbl.Location = new System.Drawing.Point(321, 296);
            this.roomphonetbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomphonetbl.Name = "roomphonetbl";
            this.roomphonetbl.Size = new System.Drawing.Size(212, 33);
            this.roomphonetbl.TabIndex = 16;
            this.roomphonetbl.Text = "Room Phone";
            // 
            // roomidtbl
            // 
            this.roomidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomidtbl.Location = new System.Drawing.Point(321, 219);
            this.roomidtbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.Size = new System.Drawing.Size(212, 33);
            this.roomidtbl.TabIndex = 15;
            this.roomidtbl.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(315, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Free";
            // 
            // Yesbtn
            // 
            this.Yesbtn.AutoSize = true;
            this.Yesbtn.Location = new System.Drawing.Point(395, 379);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(17, 16);
            this.Yesbtn.TabIndex = 18;
            this.Yesbtn.UseVisualStyleBackColor = true;
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Location = new System.Drawing.Point(470, 379);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(17, 16);
            this.Noradio.TabIndex = 19;
            this.Noradio.UseVisualStyleBackColor = true;
            // 
            // Yesradio
            // 
            this.Yesradio.AutoSize = true;
            this.Yesradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesradio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Yesradio.Location = new System.Drawing.Point(418, 374);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(46, 25);
            this.Yesradio.TabIndex = 20;
            this.Yesradio.Text = "Yes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(493, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "No";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(455, 450);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(123, 41);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(369, 450);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(80, 41);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(283, 450);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(80, 41);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 607);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomphonetbl);
            this.Controls.Add(this.roomidtbl);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.RoomSearchtbl);
            this.Controls.Add(this.RoomGridview);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RoomGridview;
        private System.Windows.Forms.PictureBox refreshpb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox RoomSearchtbl;
        private System.Windows.Forms.RichTextBox roomphonetbl;
        private System.Windows.Forms.RichTextBox roomidtbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Yesbtn;
        private System.Windows.Forms.RadioButton Noradio;
        private System.Windows.Forms.Label Yesradio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomFree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}