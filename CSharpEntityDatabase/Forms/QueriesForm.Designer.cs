namespace CSharpEntityDatabase.Forms
{
    partial class QueriesForm
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
            this.tabGuestQueries = new System.Windows.Forms.TabPage();
            this.cbGuestQueries = new System.Windows.Forms.ComboBox();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.tabBookingQueries = new System.Windows.Forms.TabPage();
            this.cbBookingQueries = new System.Windows.Forms.ComboBox();
            this.dgvBookingQueries = new System.Windows.Forms.DataGridView();
            this.tabInvoiceQueries = new System.Windows.Forms.TabPage();
            this.cbInvoiceQueries = new System.Windows.Forms.ComboBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabGuestQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.tabBookingQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingQueries)).BeginInit();
            this.tabInvoiceQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGuestQueries);
            this.tabControl1.Controls.Add(this.tabBookingQueries);
            this.tabControl1.Controls.Add(this.tabInvoiceQueries);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGuestQueries
            // 
            this.tabGuestQueries.BackColor = System.Drawing.Color.Transparent;
            this.tabGuestQueries.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.tabGuestQueries.Controls.Add(this.cbGuestQueries);
            this.tabGuestQueries.Controls.Add(this.dgvGuests);
            this.tabGuestQueries.Location = new System.Drawing.Point(4, 22);
            this.tabGuestQueries.Name = "tabGuestQueries";
            this.tabGuestQueries.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuestQueries.Size = new System.Drawing.Size(756, 364);
            this.tabGuestQueries.TabIndex = 0;
            this.tabGuestQueries.Text = "GuestQueries";
            // 
            // cbGuestQueries
            // 
            this.cbGuestQueries.FormattingEnabled = true;
            this.cbGuestQueries.Items.AddRange(new object[] {
            "Get All Guests"});
            this.cbGuestQueries.Location = new System.Drawing.Point(6, 238);
            this.cbGuestQueries.Name = "cbGuestQueries";
            this.cbGuestQueries.Size = new System.Drawing.Size(121, 21);
            this.cbGuestQueries.TabIndex = 1;
            this.cbGuestQueries.SelectedIndexChanged += new System.EventHandler(this.cbGuestQueries_SelectedIndexChanged);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToResizeColumns = false;
            this.dgvGuests.AllowUserToResizeRows = false;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(0, 0);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.Size = new System.Drawing.Size(750, 223);
            this.dgvGuests.TabIndex = 0;
            // 
            // tabBookingQueries
            // 
            this.tabBookingQueries.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.tabBookingQueries.Controls.Add(this.cbBookingQueries);
            this.tabBookingQueries.Controls.Add(this.dgvBookingQueries);
            this.tabBookingQueries.Location = new System.Drawing.Point(4, 22);
            this.tabBookingQueries.Name = "tabBookingQueries";
            this.tabBookingQueries.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookingQueries.Size = new System.Drawing.Size(756, 364);
            this.tabBookingQueries.TabIndex = 1;
            this.tabBookingQueries.Text = "Booking Queries";
            this.tabBookingQueries.UseVisualStyleBackColor = true;
            // 
            // cbBookingQueries
            // 
            this.cbBookingQueries.FormattingEnabled = true;
            this.cbBookingQueries.Items.AddRange(new object[] {
            "Get Bookings With No Checkin Date",
            "Get Bookings With No Checkout Date"});
            this.cbBookingQueries.Location = new System.Drawing.Point(7, 245);
            this.cbBookingQueries.Name = "cbBookingQueries";
            this.cbBookingQueries.Size = new System.Drawing.Size(121, 21);
            this.cbBookingQueries.TabIndex = 2;
            this.cbBookingQueries.SelectedIndexChanged += new System.EventHandler(this.cbBookingQueries_SelectedIndexChanged);
            // 
            // dgvBookingQueries
            // 
            this.dgvBookingQueries.AllowUserToResizeColumns = false;
            this.dgvBookingQueries.AllowUserToResizeRows = false;
            this.dgvBookingQueries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingQueries.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingQueries.Name = "dgvBookingQueries";
            this.dgvBookingQueries.Size = new System.Drawing.Size(750, 223);
            this.dgvBookingQueries.TabIndex = 1;
            // 
            // tabInvoiceQueries
            // 
            this.tabInvoiceQueries.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.tabInvoiceQueries.Controls.Add(this.cbInvoiceQueries);
            this.tabInvoiceQueries.Controls.Add(this.dgvInvoice);
            this.tabInvoiceQueries.Location = new System.Drawing.Point(4, 22);
            this.tabInvoiceQueries.Name = "tabInvoiceQueries";
            this.tabInvoiceQueries.Size = new System.Drawing.Size(756, 364);
            this.tabInvoiceQueries.TabIndex = 2;
            this.tabInvoiceQueries.Text = "InvoiceQueries";
            this.tabInvoiceQueries.UseVisualStyleBackColor = true;
            this.tabInvoiceQueries.Click += new System.EventHandler(this.tabInvoiceQueries_Click);
            // 
            // cbInvoiceQueries
            // 
            this.cbInvoiceQueries.FormattingEnabled = true;
            this.cbInvoiceQueries.Items.AddRange(new object[] {
            "Get Unpaid Invoices",
            "Get Paid Invoices",
            "Get Paid Invoices By Date",
            "Get All Invoices"});
            this.cbInvoiceQueries.Location = new System.Drawing.Point(7, 238);
            this.cbInvoiceQueries.Name = "cbInvoiceQueries";
            this.cbInvoiceQueries.Size = new System.Drawing.Size(121, 21);
            this.cbInvoiceQueries.TabIndex = 2;
            this.cbInvoiceQueries.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToResizeColumns = false;
            this.dgvInvoice.AllowUserToResizeRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(753, 223);
            this.dgvInvoice.TabIndex = 1;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(756, 386);
            this.Controls.Add(this.tabControl1);
            this.Name = "QueriesForm";
            this.Text = "QueriesForm";
            this.tabControl1.ResumeLayout(false);
            this.tabGuestQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.tabBookingQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingQueries)).EndInit();
            this.tabInvoiceQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGuestQueries;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.TabPage tabBookingQueries;
        private System.Windows.Forms.TabPage tabInvoiceQueries;
        private System.Windows.Forms.DataGridView dgvBookingQueries;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.ComboBox cbGuestQueries;
        private System.Windows.Forms.ComboBox cbBookingQueries;
        private System.Windows.Forms.ComboBox cbInvoiceQueries;
    }
}