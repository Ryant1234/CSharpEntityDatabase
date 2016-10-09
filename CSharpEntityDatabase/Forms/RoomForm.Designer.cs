namespace CSharpEntityDatabase
{
    partial class RoomForm
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnGetRooms = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.cbNewRoom = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(24, 24);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(323, 123);
            this.dgvRooms.TabIndex = 60;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // btnGetRooms
            // 
            this.btnGetRooms.Location = new System.Drawing.Point(570, 24);
            this.btnGetRooms.Name = "btnGetRooms";
            this.btnGetRooms.Size = new System.Drawing.Size(75, 23);
            this.btnGetRooms.TabIndex = 59;
            this.btnGetRooms.Text = "Get Rooms";
            this.btnGetRooms.UseVisualStyleBackColor = true;
            this.btnGetRooms.Click += new System.EventHandler(this.btnGetRooms_Click);
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(12, 284);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(75, 23);
            this.btnNewRoom.TabIndex = 58;
            this.btnNewRoom.Text = "new room";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // cbNewRoom
            // 
            this.cbNewRoom.FormattingEnabled = true;
            this.cbNewRoom.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Twin Room"});
            this.cbNewRoom.Location = new System.Drawing.Point(24, 153);
            this.cbNewRoom.Name = "cbNewRoom";
            this.cbNewRoom.Size = new System.Drawing.Size(121, 21);
            this.cbNewRoom.TabIndex = 57;
            this.cbNewRoom.SelectedIndexChanged += new System.EventHandler(this.cbNewRoom_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(561, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete Room";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.Location = new System.Drawing.Point(570, 76);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRoom.TabIndex = 62;
            this.btnChangeRoom.Text = "Change Room";
            this.btnChangeRoom.UseVisualStyleBackColor = true;
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpEntityDatabase.Properties.Resources.bluebackground;
            this.ClientSize = new System.Drawing.Size(657, 319);
            this.Controls.Add(this.btnChangeRoom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btnGetRooms);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.cbNewRoom);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnGetRooms;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.ComboBox cbNewRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeRoom;
    }
}