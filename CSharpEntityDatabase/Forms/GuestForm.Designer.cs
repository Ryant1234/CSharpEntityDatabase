namespace CSharpEntityDatabase.Forms
{
    partial class GuestForm
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
            this.lblGuestId = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuestId
            // 
            this.lblGuestId.AutoSize = true;
            this.lblGuestId.Location = new System.Drawing.Point(770, 60);
            this.lblGuestId.Name = "lblGuestId";
            this.lblGuestId.Size = new System.Drawing.Size(0, 13);
            this.lblGuestId.TabIndex = 61;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(499, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(12, 370);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGuest.TabIndex = 59;
            this.btnDeleteGuest.Text = "Delete Guest";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-171, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Guest Querys";
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Location = new System.Drawing.Point(746, 357);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Size = new System.Drawing.Size(106, 36);
            this.btnNewGuest.TabIndex = 57;
            this.btnNewGuest.Text = "Enter new guest";
            this.btnNewGuest.UseVisualStyleBackColor = true;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // cbGuests
            // 
            this.cbGuests.FormattingEnabled = true;
            this.cbGuests.Location = new System.Drawing.Point(-171, 314);
            this.cbGuests.Name = "cbGuests";
            this.cbGuests.Size = new System.Drawing.Size(121, 21);
            this.cbGuests.TabIndex = 56;
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(12, 10);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(562, 247);
            this.dgvGuests.TabIndex = 55;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellClick);
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(746, 276);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(746, 237);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Province/State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Suburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddress.Location = new System.Drawing.Point(746, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 45;
            // 
            // txtProvinceState
            // 
            this.txtProvinceState.Location = new System.Drawing.Point(746, 198);
            this.txtProvinceState.Name = "txtProvinceState";
            this.txtProvinceState.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceState.TabIndex = 44;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(746, 159);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(746, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 42;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(746, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 41;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 398);
            this.Controls.Add(this.lblGuestId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNewGuest);
            this.Controls.Add(this.cbGuests);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtProvinceState);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Label label10;
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
    }
}