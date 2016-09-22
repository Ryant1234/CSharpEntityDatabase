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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.dtBookingTo = new System.Windows.Forms.DateTimePicker();
            this.dtBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGetRooms = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.GuestsTab = new System.Windows.Forms.TabPage();
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.BookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.GuestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.InvoiceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookingsTab);
            this.tabControl1.Controls.Add(this.GuestsTab);
            this.tabControl1.Controls.Add(this.InvoiceTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // BookingsTab
            // 
            this.BookingsTab.Controls.Add(this.label9);
            this.BookingsTab.Controls.Add(this.label8);
            this.BookingsTab.Controls.Add(this.dgvRooms);
            this.BookingsTab.Controls.Add(this.lblRoomId);
            this.BookingsTab.Controls.Add(this.lblGuestID);
            this.BookingsTab.Controls.Add(this.dtBookingTo);
            this.BookingsTab.Controls.Add(this.dtBookingFrom);
            this.BookingsTab.Controls.Add(this.btnGetRooms);
            this.BookingsTab.Controls.Add(this.btnNewRoom);
            this.BookingsTab.Controls.Add(this.dgvBooking);
            this.BookingsTab.Controls.Add(this.btnGet);
            this.BookingsTab.Controls.Add(this.btnNewBooking);
            this.BookingsTab.Controls.Add(this.comboBox3);
            this.BookingsTab.Location = new System.Drawing.Point(4, 22);
            this.BookingsTab.Name = "BookingsTab";
            this.BookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookingsTab.Size = new System.Drawing.Size(802, 328);
            this.BookingsTab.TabIndex = 0;
            this.BookingsTab.Text = "Bookings";
            this.BookingsTab.UseVisualStyleBackColor = true;
            this.BookingsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Booking To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Booking From";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(585, 95);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(210, 64);
            this.dgvRooms.TabIndex = 52;
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(396, 241);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(0, 13);
            this.lblRoomId.TabIndex = 51;
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(396, 202);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(0, 13);
            this.lblGuestID.TabIndex = 50;
            // 
            // dtBookingTo
            // 
            this.dtBookingTo.Location = new System.Drawing.Point(596, 69);
            this.dtBookingTo.Name = "dtBookingTo";
            this.dtBookingTo.Size = new System.Drawing.Size(200, 20);
            this.dtBookingTo.TabIndex = 46;
            this.dtBookingTo.ValueChanged += new System.EventHandler(this.dtBookingTo_ValueChanged);
            // 
            // dtBookingFrom
            // 
            this.dtBookingFrom.Location = new System.Drawing.Point(599, 30);
            this.dtBookingFrom.Name = "dtBookingFrom";
            this.dtBookingFrom.Size = new System.Drawing.Size(200, 20);
            this.dtBookingFrom.TabIndex = 45;
            this.dtBookingFrom.ValueChanged += new System.EventHandler(this.dtBookingFrom_ValueChanged);
            // 
            // btnGetRooms
            // 
            this.btnGetRooms.Location = new System.Drawing.Point(504, 175);
            this.btnGetRooms.Name = "btnGetRooms";
            this.btnGetRooms.Size = new System.Drawing.Size(75, 23);
            this.btnGetRooms.TabIndex = 44;
            this.btnGetRooms.Text = "Get Rooms";
            this.btnGetRooms.UseVisualStyleBackColor = true;
            this.btnGetRooms.Click += new System.EventHandler(this.btnGetRooms_Click);
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(18, 218);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(75, 23);
            this.btnNewRoom.TabIndex = 43;
            this.btnNewRoom.Text = "new room";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
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
            this.btnGet.Location = new System.Drawing.Point(318, 272);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 41;
            this.btnGet.Text = "GetBookings";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(392, 6);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(75, 51);
            this.btnNewBooking.TabIndex = 36;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(108, 220);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 35;
            // 
            // GuestsTab
            // 
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
            this.GuestsTab.Size = new System.Drawing.Size(802, 328);
            this.GuestsTab.TabIndex = 1;
            this.GuestsTab.Text = "Guests";
            this.GuestsTab.UseVisualStyleBackColor = true;
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Location = new System.Drawing.Point(331, 193);
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
            this.cbGuests.Location = new System.Drawing.Point(8, 205);
            this.cbGuests.Name = "cbGuests";
            this.cbGuests.Size = new System.Drawing.Size(121, 21);
            this.cbGuests.TabIndex = 34;
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(8, 6);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(391, 181);
            this.dgvGuests.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(473, 268);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(473, 229);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Province/State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Suburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(473, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // txtProvinceState
            // 
            this.txtProvinceState.Location = new System.Drawing.Point(473, 190);
            this.txtProvinceState.Name = "txtProvinceState";
            this.txtProvinceState.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceState.TabIndex = 22;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(473, 151);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(473, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(473, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // InvoiceTab
            // 
            this.InvoiceTab.Controls.Add(this.comboBox2);
            this.InvoiceTab.Location = new System.Drawing.Point(4, 22);
            this.InvoiceTab.Name = "InvoiceTab";
            this.InvoiceTab.Size = new System.Drawing.Size(802, 328);
            this.InvoiceTab.TabIndex = 2;
            this.InvoiceTab.Text = "Invoices";
            this.InvoiceTab.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(438, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.BookingsTab.ResumeLayout(false);
            this.BookingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.GuestsTab.ResumeLayout(false);
            this.GuestsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.InvoiceTab.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGetRooms;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dtBookingTo;
        private System.Windows.Forms.DateTimePicker dtBookingFrom;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

