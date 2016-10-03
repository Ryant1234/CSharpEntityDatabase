using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEntityDatabase.Hotel.BL;

namespace CSharpEntityDatabase
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            cbNewRoom.SelectedIndex = 0;
            var roomRepository = new RoomRepository();
            dgvRooms.DataSource = roomRepository.GetRooms();

        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            var roomRepository = new RoomRepository();
            MessageBox.Show(cbNewRoom.Text);
            roomRepository.InsertRooms(cbNewRoom.Text);
        }

        private void btnGetRooms_Click(object sender, EventArgs e)
        {
     
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
          
            var roomRepository = new RoomRepository();
            roomRepository.DeleteRoom(roomId);
            dgvRooms.DataSource = roomRepository.GetRooms();

        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            var roomRepository = new RoomRepository();
            var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
            var roomType = cbNewRoom.Text;
            roomRepository.EditRoom(roomId, roomType);
            dgvRooms.DataSource = roomRepository.GetRooms();
        }

        private void cbNewRoom_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbNewRoom.Text)
            {
                    
            }
        }
    }
}
