namespace CSharpEntityDatabase.Forms
{
    partial class CheckoutForm
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.checkboxHasPaid = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtMiniBarCharge = new System.Windows.Forms.TextBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResturantBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToResizeColumns = false;
            this.dgvGuests.AllowUserToResizeRows = false;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(12, 12);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(522, 150);
            this.dgvGuests.TabIndex = 0;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellClick);
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellContentClick);
            // 
            // checkboxHasPaid
            // 
            this.checkboxHasPaid.AutoSize = true;
            this.checkboxHasPaid.BackColor = System.Drawing.Color.Transparent;
            this.checkboxHasPaid.Location = new System.Drawing.Point(728, 96);
            this.checkboxHasPaid.Name = "checkboxHasPaid";
            this.checkboxHasPaid.Size = new System.Drawing.Size(94, 17);
            this.checkboxHasPaid.TabIndex = 1;
            this.checkboxHasPaid.Text = "Customer Paid";
            this.checkboxHasPaid.UseVisualStyleBackColor = false;
            this.checkboxHasPaid.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(728, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Room Checked ";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // txtMiniBarCharge
            // 
            this.txtMiniBarCharge.Location = new System.Drawing.Point(728, 203);
            this.txtMiniBarCharge.Name = "txtMiniBarCharge";
            this.txtMiniBarCharge.Size = new System.Drawing.Size(100, 20);
            this.txtMiniBarCharge.TabIndex = 3;
            this.txtMiniBarCharge.Text = "0";
            this.txtMiniBarCharge.TextChanged += new System.EventHandler(this.txtMiniBarCharge_TextChanged);
            this.txtMiniBarCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiniBarCharge_KeyPress);
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(728, 242);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.Size = new System.Drawing.Size(100, 20);
            this.txtRoomCharge.TabIndex = 4;
            this.txtRoomCharge.TextChanged += new System.EventHandler(this.txtRoomCharge_TextChanged);
            this.txtRoomCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomCharge_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(725, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Charge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(725, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MiniBar";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(728, 317);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(108, 41);
            this.btnCheckout.TabIndex = 66;
            this.btnCheckout.Text = "Check out Guest";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckoutForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(725, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Resturant Bill";
            // 
            // txtResturantBill
            // 
            this.txtResturantBill.Location = new System.Drawing.Point(728, 164);
            this.txtResturantBill.Name = "txtResturantBill";
            this.txtResturantBill.Size = new System.Drawing.Size(100, 20);
            this.txtResturantBill.TabIndex = 67;
            this.txtResturantBill.Text = "0";
            this.txtResturantBill.TextChanged += new System.EventHandler(this.txtResturantBill_TextChanged);
            this.txtResturantBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResturantBill_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(725, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Total Bill";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(728, 282);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBill.TabIndex = 69;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(871, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResturantBill);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomCharge);
            this.Controls.Add(this.txtMiniBarCharge);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkboxHasPaid);
            this.Controls.Add(this.dgvGuests);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.CheckBox checkboxHasPaid;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtMiniBarCharge;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResturantBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalBill;
    }
}