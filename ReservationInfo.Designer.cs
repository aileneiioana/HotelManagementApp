using System;
using System.Windows.Forms;
namespace HotelManagementApplication
{
    partial class ReservationInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReservationIdtb = new System.Windows.Forms.TextBox();
            this.dateInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.ResView = new System.Windows.Forms.DataGridView();
            this.ResId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteResfBtn = new System.Windows.Forms.Button();
            this.EditResfBtn = new System.Windows.Forms.Button();
            this.AddResBtn = new System.Windows.Forms.Button();
            this.clientcb = new System.Windows.Forms.ComboBox();
            this.roomnumbercb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 115);
            this.panel1.TabIndex = 1;
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(818, 79);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(59, 25);
            this.Datelb.TabIndex = 1;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Datelb.Click += new System.EventHandler(this.Datelb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F);
            this.label1.Location = new System.Drawing.Point(326, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReservationIdtb
            // 
            this.ReservationIdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ReservationIdtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationIdtb.Location = new System.Drawing.Point(53, 146);
            this.ReservationIdtb.Name = "ReservationIdtb";
            this.ReservationIdtb.Size = new System.Drawing.Size(212, 26);
            this.ReservationIdtb.TabIndex = 3;
            this.ReservationIdtb.Text = "Reservation Id";
            // 
            // dateInTimePicker
            // 
            this.dateInTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateInTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInTimePicker.Location = new System.Drawing.Point(182, 248);
            this.dateInTimePicker.Name = "dateInTimePicker";
            this.dateInTimePicker.Size = new System.Drawing.Size(144, 27);
            this.dateInTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(53, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(53, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Out";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutTimePicker
            // 
            this.dateOutTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOutTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOutTimePicker.Location = new System.Drawing.Point(182, 281);
            this.dateOutTimePicker.Name = "dateOutTimePicker";
            this.dateOutTimePicker.Size = new System.Drawing.Size(144, 27);
            this.dateOutTimePicker.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(736, 133);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(78, 36);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Searchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Searchtb.Location = new System.Drawing.Point(555, 139);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(175, 26);
            this.Searchtb.TabIndex = 14;
            this.Searchtb.Text = "Reservation Search";
            // 
            // ResView
            // 
            this.ResView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResId,
            this.Client,
            this.Room,
            this.DateIn,
            this.DateOut});
            this.ResView.Location = new System.Drawing.Point(332, 173);
            this.ResView.Name = "ResView";
            this.ResView.RowTemplate.Height = 25;
            this.ResView.Size = new System.Drawing.Size(545, 347);
            this.ResView.TabIndex = 13;
            this.ResView.DoubleClick += new System.EventHandler(this.ResView_DoubleClick);
            // 
            // ResId
            // 
            this.ResId.DataPropertyName = "ResId";
            this.ResId.HeaderText = "ResId";
            this.ResId.Name = "ResId";
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "DateIn";
            this.DateIn.Name = "DateIn";
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DateOut";
            this.DateOut.HeaderText = "DateOut";
            this.DateOut.Name = "DateOut";
            // 
            // DeleteResfBtn
            // 
            this.DeleteResfBtn.FlatAppearance.BorderSize = 0;
            this.DeleteResfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteResfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteResfBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteResfBtn.Location = new System.Drawing.Point(170, 337);
            this.DeleteResfBtn.Name = "DeleteResfBtn";
            this.DeleteResfBtn.Size = new System.Drawing.Size(95, 33);
            this.DeleteResfBtn.TabIndex = 21;
            this.DeleteResfBtn.Text = "DELETE";
            this.DeleteResfBtn.UseVisualStyleBackColor = true;
            this.DeleteResfBtn.Click += new System.EventHandler(this.DeleteResfBtn_Click);
            // 
            // EditResfBtn
            // 
            this.EditResfBtn.FlatAppearance.BorderSize = 0;
            this.EditResfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditResfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EditResfBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditResfBtn.Location = new System.Drawing.Point(103, 337);
            this.EditResfBtn.Name = "EditResfBtn";
            this.EditResfBtn.Size = new System.Drawing.Size(60, 33);
            this.EditResfBtn.TabIndex = 20;
            this.EditResfBtn.Text = "EDIT";
            this.EditResfBtn.UseVisualStyleBackColor = true;
            this.EditResfBtn.Click += new System.EventHandler(this.EditResfBtn_Click);
            // 
            // AddResBtn
            // 
            this.AddResBtn.FlatAppearance.BorderSize = 0;
            this.AddResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddResBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddResBtn.Location = new System.Drawing.Point(36, 337);
            this.AddResBtn.Name = "AddResBtn";
            this.AddResBtn.Size = new System.Drawing.Size(60, 33);
            this.AddResBtn.TabIndex = 19;
            this.AddResBtn.Text = "ADD";
            this.AddResBtn.UseVisualStyleBackColor = true;
            this.AddResBtn.Click += new System.EventHandler(this.AddResBtn_Click);
            // 
            // clientcb
            // 
            this.clientcb.AccessibleName = "";
            this.clientcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientcb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientcb.FormattingEnabled = true;
            this.clientcb.Location = new System.Drawing.Point(182, 184);
            this.clientcb.Name = "clientcb";
            this.clientcb.Size = new System.Drawing.Size(144, 28);
            this.clientcb.TabIndex = 22;
            this.clientcb.Text = "Client Name";
            // 
            // roomnumbercb
            // 
            this.roomnumbercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.roomnumbercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomnumbercb.FormattingEnabled = true;
            this.roomnumbercb.Location = new System.Drawing.Point(182, 217);
            this.roomnumbercb.Name = "roomnumbercb";
            this.roomnumbercb.Size = new System.Drawing.Size(144, 28);
            this.roomnumbercb.TabIndex = 23;
            this.roomnumbercb.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(53, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Client Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(53, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Room Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Backbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Backbtn.Location = new System.Drawing.Point(103, 453);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(60, 33);
            this.Backbtn.TabIndex = 26;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // refreshpb
            // 
            this.refreshpb.Image = global::HotelManagementApplication.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(820, 139);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(30, 28);
            this.refreshpb.TabIndex = 16;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 554);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomnumbercb);
            this.Controls.Add(this.clientcb);
            this.Controls.Add(this.DeleteResfBtn);
            this.Controls.Add(this.EditResfBtn);
            this.Controls.Add(this.AddResBtn);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.ResView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOutTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateInTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReservationIdtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.Text = "ReservationInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Panel panel1;
        private Label Datelb;
        private Label label1;
        public TextBox ReservationIdtb;
        private DateTimePicker dateInTimePicker;
        private Label label2;
        private Label label3;
        private DateTimePicker dateOutTimePicker;
        private PictureBox refreshpb;
        private Button Search;
        private TextBox Searchtb;
        private DataGridView ResView;
        private Button DeleteResfBtn;
        private Button EditResfBtn;
        private Button AddResBtn;
        private ComboBox clientcb;
        private ComboBox roomnumbercb;
        private Label label4;
        private Label label5;
        private Button Backbtn;
        private DataGridViewTextBoxColumn ResId;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn DateIn;
        private DataGridViewTextBoxColumn DateOut;
    }
}