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
            this.btnCheckoutForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.InvoiceTab = new System.Windows.Forms.TabPage();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.BookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.InvoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookingsTab);
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
            this.InvoiceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BookingsTab;
        private System.Windows.Forms.TabPage InvoiceTab;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckoutForm;
    }
}

