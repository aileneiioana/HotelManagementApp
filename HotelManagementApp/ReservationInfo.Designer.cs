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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
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
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1409, 142);
            this.panel1.TabIndex = 1;
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(1105, 96);
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
            this.label1.Location = new System.Drawing.Point(480, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReservationIdtb
            // 
            this.ReservationIdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ReservationIdtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationIdtb.Location = new System.Drawing.Point(71, 180);
            this.ReservationIdtb.Margin = new System.Windows.Forms.Padding(4);
            this.ReservationIdtb.Name = "ReservationIdtb";
            this.ReservationIdtb.Size = new System.Drawing.Size(281, 30);
            this.ReservationIdtb.TabIndex = 3;
            this.ReservationIdtb.Text = "Reservation Id";
            // 
            // dateInTimePicker
            // 
            this.dateInTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateInTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInTimePicker.Location = new System.Drawing.Point(243, 305);
            this.dateInTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateInTimePicker.Name = "dateInTimePicker";
            this.dateInTimePicker.Size = new System.Drawing.Size(191, 32);
            this.dateInTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(71, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(71, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
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
            this.dateOutTimePicker.Location = new System.Drawing.Point(243, 346);
            this.dateOutTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOutTimePicker.Name = "dateOutTimePicker";
            this.dateOutTimePicker.Size = new System.Drawing.Size(191, 32);
            this.dateOutTimePicker.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(1111, 164);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 44);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Searchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Searchtb.Location = new System.Drawing.Point(871, 171);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(4);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(232, 30);
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
            this.ResView.Location = new System.Drawing.Point(453, 226);
            this.ResView.Margin = new System.Windows.Forms.Padding(4);
            this.ResView.Name = "ResView";
            this.ResView.RowHeadersWidth = 51;
            this.ResView.RowTemplate.Height = 25;
            this.ResView.Size = new System.Drawing.Size(905, 427);
            this.ResView.TabIndex = 13;
            this.ResView.DoubleClick += new System.EventHandler(this.ResView_DoubleClick);
            // 
            // ResId
            // 
            this.ResId.DataPropertyName = "ResId";
            this.ResId.HeaderText = "ResId";
            this.ResId.MinimumWidth = 6;
            this.ResId.Name = "ResId";
            this.ResId.Width = 125;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "DateIn";
            this.DateIn.MinimumWidth = 6;
            this.DateIn.Name = "DateIn";
            this.DateIn.Width = 125;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DateOut";
            this.DateOut.HeaderText = "DateOut";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.Width = 125;
            // 
            // DeleteResfBtn
            // 
            this.DeleteResfBtn.FlatAppearance.BorderSize = 0;
            this.DeleteResfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteResfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteResfBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteResfBtn.Location = new System.Drawing.Point(227, 415);
            this.DeleteResfBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteResfBtn.Name = "DeleteResfBtn";
            this.DeleteResfBtn.Size = new System.Drawing.Size(127, 41);
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
            this.EditResfBtn.Location = new System.Drawing.Point(137, 415);
            this.EditResfBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditResfBtn.Name = "EditResfBtn";
            this.EditResfBtn.Size = new System.Drawing.Size(80, 41);
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
            this.AddResBtn.Location = new System.Drawing.Point(48, 415);
            this.AddResBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddResBtn.Name = "AddResBtn";
            this.AddResBtn.Size = new System.Drawing.Size(80, 41);
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
            this.clientcb.Location = new System.Drawing.Point(243, 226);
            this.clientcb.Margin = new System.Windows.Forms.Padding(4);
            this.clientcb.Name = "clientcb";
            this.clientcb.Size = new System.Drawing.Size(191, 33);
            this.clientcb.TabIndex = 22;
            this.clientcb.Text = "Client Name";
            // 
            // roomnumbercb
            // 
            this.roomnumbercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.roomnumbercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomnumbercb.FormattingEnabled = true;
            this.roomnumbercb.Location = new System.Drawing.Point(243, 267);
            this.roomnumbercb.Margin = new System.Windows.Forms.Padding(4);
            this.roomnumbercb.Name = "roomnumbercb";
            this.roomnumbercb.Size = new System.Drawing.Size(191, 33);
            this.roomnumbercb.TabIndex = 23;
            this.roomnumbercb.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(71, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Client Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(71, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Room Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshpb
            // 
            this.refreshpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshpb.Image = global::HotelManagementApplication.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(1223, 163);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(4);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(82, 55);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 16;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 620);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 690);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private DataGridViewTextBoxColumn ResId;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn DateIn;
        private DataGridViewTextBoxColumn DateOut;
        private PictureBox pictureBox1;
    }
}