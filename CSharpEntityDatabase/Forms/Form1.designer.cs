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
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckoutForm = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnCheckInGuest = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(12, 12);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(100, 29);
            this.btnNewBooking.TabIndex = 36;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 62;
            this.button1.Text = "Edit Room Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCheckoutForm
            // 
            this.btnCheckoutForm.Location = new System.Drawing.Point(976, 273);
            this.btnCheckoutForm.Name = "btnCheckoutForm";
            this.btnCheckoutForm.Size = new System.Drawing.Size(89, 39);
            this.btnCheckoutForm.TabIndex = 63;
            this.btnCheckoutForm.Text = "Check out Guest";
            this.btnCheckoutForm.UseVisualStyleBackColor = true;
            this.btnCheckoutForm.Click += new System.EventHandler(this.btnCheckoutForm_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Location = new System.Drawing.Point(218, 12);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(75, 23);
            this.btnQueries.TabIndex = 64;
            this.btnQueries.Text = "Queries";
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuests.Location = new System.Drawing.Point(945, 12);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(120, 41);
            this.btnGuests.TabIndex = 65;
            this.btnGuests.Text = "New/Update/Delte Guest";
            this.btnGuests.UseVisualStyleBackColor = false;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // btnCheckInGuest
            // 
            this.btnCheckInGuest.Location = new System.Drawing.Point(976, 228);
            this.btnCheckInGuest.Name = "btnCheckInGuest";
            this.btnCheckInGuest.Size = new System.Drawing.Size(89, 39);
            this.btnCheckInGuest.TabIndex = 66;
            this.btnCheckInGuest.Text = "Check in Guest";
            this.btnCheckInGuest.UseVisualStyleBackColor = true;
            this.btnCheckInGuest.Click += new System.EventHandler(this.btnCheckInGuest_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(12, 47);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteBooking.TabIndex = 67;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(1077, 323);
            this.Controls.Add(this.btnQueries);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.btnCheckInGuest);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.btnCheckoutForm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckoutForm;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnCheckInGuest;
        private System.Windows.Forms.Button btnDeleteBooking;
    }
}

