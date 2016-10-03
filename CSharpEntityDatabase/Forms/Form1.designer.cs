namespace CSharpEntityDatabase
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BookingsTab = new System.Windows.Forms.TabPage();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.GuestsTab = new System.Windows.Forms.TabPage();
            this.lblGuestId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNewGuest = new System.Windows.Forms.Button();
            this.cbGuests = new System.Windows.Forms.ComboBox();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtProvinceState = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.InvoiceTab = new System.Windows.Forms.TabPage();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckoutForm = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.BookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.GuestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.InvoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookingsTab);
            this.tabControl1.Controls.Add(this.GuestsTab);
            this.tabControl1.Controls.Add(this.InvoiceTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // BookingsTab
            // 
            this.BookingsTab.Controls.Add(this.btnCheckoutForm);
            this.BookingsTab.Controls.Add(this.button1);
            this.BookingsTab.Controls.Add(this.dgvBooking);
            this.BookingsTab.Controls.Add(this.btnGet);
            this.BookingsTab.Controls.Add(this.btnNewBooking);
            this.BookingsTab.Location = new System.Drawing.Point(4, 22);
            this.BookingsTab.Name = "BookingsTab";
            this.BookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookingsTab.Size = new System.Drawing.Size(1076, 402);
            this.BookingsTab.TabIndex = 0;
            this.BookingsTab.Text = "Bookings";
            this.BookingsTab.UseVisualStyleBackColor = true;
            this.BookingsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(18, 6);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(368, 192);
            this.dgvBooking.TabIndex = 42;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(392, 52);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 29);
            this.btnGet.TabIndex = 41;
            this.btnGet.Text = "GetBookings";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(392, 6);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(100, 29);
            this.btnNewBooking.TabIndex = 36;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // GuestsTab
            // 
            this.GuestsTab.Controls.Add(this.lblGuestId);
            this.GuestsTab.Controls.Add(this.label11);
            this.GuestsTab.Controls.Add(this.btnUpdate);
            this.GuestsTab.Controls.Add(this.btnDeleteGuest);
            this.GuestsTab.Controls.Add(this.label10);
            this.GuestsTab.Controls.Add(this.btnNewGuest);
            this.GuestsTab.Controls.Add(this.cbGuests);
            this.GuestsTab.Controls.Add(this.dgvGuests);
            this.GuestsTab.Controls.Add(this.label7);
            this.GuestsTab.Controls.Add(this.txtPhoneNumber);
            this.GuestsTab.Controls.Add(this.label6);
            this.GuestsTab.Controls.Add(this.txtCountry);
            this.GuestsTab.Controls.Add(this.label5);
            this.GuestsTab.Controls.Add(this.label4);
            this.GuestsTab.Controls.Add(this.label3);
            this.GuestsTab.Controls.Add(this.label2);
            this.GuestsTab.Controls.Add(this.label1);
            this.GuestsTab.Controls.Add(this.txtAddress);
            this.GuestsTab.Controls.Add(this.txtProvinceState);
            this.GuestsTab.Controls.Add(this.txtSuburb);
            this.GuestsTab.Controls.Add(this.txtLastName);
            this.GuestsTab.Controls.Add(this.txtFirstName);
            this.GuestsTab.Location = new System.Drawing.Point(4, 22);
            this.GuestsTab.Name = "GuestsTab";
            this.GuestsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GuestsTab.Size = new System.Drawing.Size(1076, 402);
            this.GuestsTab.TabIndex = 1;
            this.GuestsTab.Text = "Guests";
            this.GuestsTab.UseVisualStyleBackColor = true;
            // 
            // lblGuestId
            // 
            this.lblGuestId.AutoSize = true;
            this.lblGuestId.Location = new System.Drawing.Point(949, 34);
            this.lblGuestId.Name = "lblGuestId";
            this.lblGuestId.Size = new System.Drawing.Size(0, 13);
            this.lblGuestId.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(928, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "GuestId";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(576, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(576, 29);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGuest.TabIndex = 37;
            this.btnDeleteGuest.Text = "Delete Guest";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Guest Querys";
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Location = new System.Drawing.Point(925, 331);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Size = new System.Drawing.Size(106, 36);
            this.btnNewGuest.TabIndex = 35;
            this.btnNewGuest.Text = "Enter new guest";
            this.btnNewGuest.UseVisualStyleBackColor = true;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // cbGuests
            // 
            this.cbGuests.FormattingEnabled = true;
            this.cbGuests.Location = new System.Drawing.Point(8, 288);
            this.cbGuests.Name = "cbGuests";
            this.cbGuests.Size = new System.Drawing.Size(121, 21);
            this.cbGuests.TabIndex = 34;
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(0, 0);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(562, 247);
            this.dgvGuests.TabIndex = 33;
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(928, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(931, 308);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(928, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(931, 269);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(928, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Province/State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Suburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddress.Location = new System.Drawing.Point(931, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // txtProvinceState
            // 
            this.txtProvinceState.Location = new System.Drawing.Point(931, 230);
            this.txtProvinceState.Name = "txtProvinceState";
            this.txtProvinceState.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceState.TabIndex = 22;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(931, 191);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(931, 113);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(931, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // InvoiceTab
            // 
            this.InvoiceTab.Controls.Add(this.dgvInvoices);
            this.InvoiceTab.Controls.Add(this.comboBox2);
            this.InvoiceTab.Location = new System.Drawing.Point(4, 22);
            this.InvoiceTab.Name = "InvoiceTab";
            this.InvoiceTab.Size = new System.Drawing.Size(1076, 402);
            this.InvoiceTab.TabIndex = 2;
            this.InvoiceTab.Text = "Invoices";
            this.InvoiceTab.UseVisualStyleBackColor = true;
            this.InvoiceTab.Click += new System.EventHandler(this.InvoiceTab_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(465, 90);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(240, 150);
            this.dgvInvoices.TabIndex = 36;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(438, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 62;
            this.button1.Text = "Update/Edit Rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCheckoutForm
            // 
            this.btnCheckoutForm.Location = new System.Drawing.Point(972, 350);
            this.btnCheckoutForm.Name = "btnCheckoutForm";
            this.btnCheckoutForm.Size = new System.Drawing.Size(89, 39);
            this.btnCheckoutForm.TabIndex = 63;
            this.btnCheckoutForm.Text = "Check out Guest";
            this.btnCheckoutForm.UseVisualStyleBackColor = true;
            this.btnCheckoutForm.Click += new System.EventHandler(this.btnCheckoutForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.BookingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.GuestsTab.ResumeLayout(false);
            this.GuestsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.InvoiceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BookingsTab;
        private System.Windows.Forms.TabPage GuestsTab;
        private System.Windows.Forms.TabPage InvoiceTab;
        private System.Windows.Forms.Button btnNewGuest;
        private System.Windows.Forms.ComboBox cbGuests;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtProvinceState;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckoutForm;
    }
}

