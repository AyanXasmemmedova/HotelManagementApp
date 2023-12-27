using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientInfo cl = new ClientInfo();
            cl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomInfo roomInfo = new RoomInfo();
            roomInfo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservationInfo reservationInfo = new ReservationInfo();
            reservationInfo.Show();
            this.Hide();
        }
    }
}
