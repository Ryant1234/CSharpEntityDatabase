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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.dtBookingTo = new System.Windows.Forms.DateTimePicker();
            this.dtBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.cbExtraBeds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCharge = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1137, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Booking To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1137, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Booking From";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRooms.Location = new System.Drawing.Point(1056, 144);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(234, 85);
            this.dgvRooms.TabIndex = 65;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // dtBookingTo
            // 
            this.dtBookingTo.Location = new System.Drawing.Point(1067, 71);
            this.dtBookingTo.MinDate = new System.DateTime(2016, 10, 7, 0, 0, 0, 0);
            this.dtBookingTo.Name = "dtBookingTo";
            this.dtBookingTo.Size = new System.Drawing.Size(223, 20);
            this.dtBookingTo.TabIndex = 63;
            this.dtBookingTo.ValueChanged += new System.EventHandler(this.dtBookingTo_ValueChanged);
            // 
            // dtBookingFrom
            // 
            this.dtBookingFrom.Location = new System.Drawing.Point(1070, 32);
            this.dtBookingFrom.Name = "dtBookingFrom";
            this.dtBookingFrom.Size = new System.Drawing.Size(220, 20);
            this.dtBookingFrom.TabIndex = 62;
            this.dtBookingFrom.ValueChanged += new System.EventHandler(this.dtBookingFrom_ValueChanged);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToResizeColumns = false;
            this.dgvGuests.AllowUserToResizeRows = false;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuests.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGuests.Location = new System.Drawing.Point(12, 16);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(443, 192);
            this.dgvGuests.TabIndex = 59;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellClick);
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewBooking_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1137, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Rooms Available";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(1200, 438);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(90, 31);
            this.btnBooking.TabIndex = 71;
            this.btnBooking.Text = "Make Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbExtraBeds
            // 
            this.cbExtraBeds.FormattingEnabled = true;
            this.cbExtraBeds.Location = new System.Drawing.Point(11, 273);
            this.cbExtraBeds.Name = "cbExtraBeds";
            this.cbExtraBeds.Size = new System.Drawing.Size(121, 21);
            this.cbExtraBeds.TabIndex = 76;
            this.cbExtraBeds.SelectedIndexChanged += new System.EventHandler(this.cbExtraBeds_SelectedIndexChanged);
            this.cbExtraBeds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbExtraBeds_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Extra Beds";
            // 
            // lbCharge
            // 
            this.lbCharge.FormattingEnabled = true;
            this.lbCharge.Location = new System.Drawing.Point(11, 424);
            this.lbCharge.Name = "lbCharge";
            this.lbCharge.Size = new System.Drawing.Size(369, 56);
            this.lbCharge.TabIndex = 78;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(1305, 492);
            this.Controls.Add(this.lbCharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbExtraBeds);
            this.Controls.Add(this.btnBooking);
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
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.ComboBox cbExtraBeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCharge;
    }
}