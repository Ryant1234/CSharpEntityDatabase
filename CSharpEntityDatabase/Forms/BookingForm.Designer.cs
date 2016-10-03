namespace CSharpEntityDatabase
{
    partial class BookingForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.dtBookingTo = new System.Windows.Forms.DateTimePicker();
            this.dtBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetInvoices = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbExtraBeds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCharge = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(922, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Booking To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(922, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Booking From";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(841, 128);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(234, 85);
            this.dgvRooms.TabIndex = 65;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // dtBookingTo
            // 
            this.dtBookingTo.Location = new System.Drawing.Point(852, 71);
            this.dtBookingTo.Name = "dtBookingTo";
            this.dtBookingTo.Size = new System.Drawing.Size(223, 20);
            this.dtBookingTo.TabIndex = 63;
            this.dtBookingTo.ValueChanged += new System.EventHandler(this.dtBookingTo_ValueChanged);
            // 
            // dtBookingFrom
            // 
            this.dtBookingFrom.Location = new System.Drawing.Point(855, 32);
            this.dtBookingFrom.Name = "dtBookingFrom";
            this.dtBookingFrom.Size = new System.Drawing.Size(220, 20);
            this.dtBookingFrom.TabIndex = 62;
            this.dtBookingFrom.ValueChanged += new System.EventHandler(this.dtBookingFrom_ValueChanged);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(12, 21);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(368, 192);
            this.dgvGuests.TabIndex = 59;
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewBooking_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Rooms Available";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(12, 232);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(120, 20);
            this.txtGuestName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Enter Guest Name Here";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(1002, 363);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(90, 31);
            this.btnBooking.TabIndex = 71;
            this.btnBooking.Text = "Make Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnGetInvoices
            // 
            this.btnGetInvoices.Location = new System.Drawing.Point(634, 190);
            this.btnGetInvoices.Name = "btnGetInvoices";
            this.btnGetInvoices.Size = new System.Drawing.Size(75, 23);
            this.btnGetInvoices.TabIndex = 73;
            this.btnGetInvoices.Text = "Get Invoices";
            this.btnGetInvoices.UseVisualStyleBackColor = true;
            this.btnGetInvoices.Click += new System.EventHandler(this.btnGetInvoices_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(506, 190);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnInvoice.TabIndex = 74;
            this.btnInvoice.Text = "New Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 75;
            this.button1.Text = "showbookings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbExtraBeds
            // 
            this.cbExtraBeds.FormattingEnabled = true;
            this.cbExtraBeds.Location = new System.Drawing.Point(11, 273);
            this.cbExtraBeds.Name = "cbExtraBeds";
            this.cbExtraBeds.Size = new System.Drawing.Size(121, 21);
            this.cbExtraBeds.TabIndex = 76;
            this.cbExtraBeds.SelectedIndexChanged += new System.EventHandler(this.cbExtraBeds_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Extra Beds";
            // 
            // lbCharge
            // 
            this.lbCharge.FormattingEnabled = true;
            this.lbCharge.Location = new System.Drawing.Point(11, 316);
            this.lbCharge.Name = "lbCharge";
            this.lbCharge.Size = new System.Drawing.Size(369, 56);
            this.lbCharge.TabIndex = 78;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 406);
            this.Controls.Add(this.lbCharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbExtraBeds);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnGetInvoices);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.dtBookingTo);
            this.Controls.Add(this.dtBookingFrom);
            this.Controls.Add(this.dgvGuests);
            this.Name = "BookingForm";
            this.Text = "NewBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DateTimePicker dtBookingTo;
        private System.Windows.Forms.DateTimePicker dtBookingFrom;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetInvoices;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbExtraBeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCharge;
    }
}