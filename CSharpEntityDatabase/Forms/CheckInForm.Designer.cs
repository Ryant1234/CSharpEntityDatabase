namespace CSharpEntityDatabase.Forms
{
    partial class CheckInForm
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToResizeColumns = false;
            this.dgvGuests.AllowUserToResizeRows = false;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(12, 12);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(562, 247);
            this.dgvGuests.TabIndex = 56;
            this.dgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellContentClick);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(664, 339);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(108, 41);
            this.btnCheckIn.TabIndex = 67;
            this.btnCheckIn.Text = "Check in Guest";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(795, 392);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dgvGuests);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnCheckIn;
    }
}