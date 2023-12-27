using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class ReservationInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True");
        DateTime today;
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillRoomcombo()
        {
            try
            {
                Con.Open();
                string roomState = "free";
                SqlCommand cmd = new SqlCommand("SELECT RoomId FROM Room_tbl WHERE RoomFree = @RoomFree", Con);
                cmd.Parameters.AddWithValue("@RoomFree", roomState);

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("RoomId", typeof(int));
                dt.Load(rdr);

                RoomNumbercb.ValueMember = "RoomId";
                RoomNumbercb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public void fillClientcombo()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientName FROM Client_tbl", Con);

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ClientName", typeof(string));
                dt.Load(rdr);

                ClientNamecb.ValueMember = "ClientName";
                ClientNamecb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public ReservationInfo()
        {
            InitializeComponent();
            ReservationGridview.CellClick += new DataGridViewCellEventHandler(ReservationGridview_CellClick);

        }

        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = DateIn.Value;
            fillClientcombo();
            fillRoomcombo();
            populate();
        }

        private void DateIn_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateIn.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Wrong Date For Reservation");
            }
        }

        private void DateOut_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateOut.Value, DateIn.Value);
            if (res < 0)
            {
                MessageBox.Show("Wrong Dateout.Check once more");
            }
        }
        public void updateroomstate()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True"))
                {
                    Con.Open();

                    string newState = "busy";
                    string myQuery = "UPDATE Room_tbl SET RoomFree = @NewState WHERE RoomId = @RoomId";

                    using (SqlCommand cmd = new SqlCommand(myQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@NewState", newState);
                        cmd.Parameters.AddWithValue("@RoomId", Convert.ToInt32(RoomNumbercb.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                    }
                }


                fillRoomcombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateroomondelete(int rowIndex)
        {
            Con.Open();
            string newstate = "free";


            string cellValue = ReservationGridview.Rows[rowIndex].Cells[2].Value?.ToString();

            if (int.TryParse(cellValue, out int roomid))
            {
                try
                {
                    string myquery = "UPDATE Room_tbl SET RoomFree = @NewState WHERE RoomId = @RoomId;";
                    using (SqlCommand cmd = new SqlCommand(myquery, Con))
                    {
                        cmd.Parameters.AddWithValue("@NewState", newstate);
                        cmd.Parameters.AddWithValue("@RoomId", roomid);

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();
                    fillRoomcombo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during room update: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid RoomId value: " + cellValue);
            }
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True"))
                {
                    Con.Open();

                    decimal RoomPrice = GetRoomPrice(Convert.ToInt32(RoomNumbercb.SelectedValue));

                    
                    int totalDays = (int)(DateOut.Value.Date - DateIn.Value.Date).TotalDays;

                   
                    decimal TotalPrice = RoomPrice * totalDays;


                    SqlCommand cmd = new SqlCommand("INSERT INTO Reservation_tbl (Id, Client, Room, DateIn, DateOut, TotalPrice) VALUES (@Id, @Client, @Room, @DateIn, @DateOut, @TotalPrice)", Con);

                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(ReserIdtb.Text));
                    cmd.Parameters.AddWithValue("@Client", ClientNamecb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Room", RoomNumbercb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DateIn", DateIn.Value);
                    cmd.Parameters.AddWithValue("@DateOut", DateOut.Value);
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Reservation Successfully Added");

                updateroomstate();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private decimal GetRoomPrice(int RoomId)
        {
            decimal RoomPrice = 0;

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True"))
                {
                   Con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT RoomPrice FROM Room_tbl WHERE RoomId = @RoomId", Con);
                    cmd.Parameters.AddWithValue("@RoomId", RoomId);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        RoomPrice = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return RoomPrice;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void DeleteRoombtn_Click(object sender, EventArgs e)
        {
            if (ReserIdtb.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Reservation_tbl WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Id", ReserIdtb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();


                if (ReservationGridview.SelectedRows.Count > 0)
                {

                    int selectedRowIndex = ReservationGridview.SelectedRows[0].Index;
                    updateroomondelete(selectedRowIndex);
                }

                populate();
            }
        }

        private void ReservationGridview_CellClick(object sender, EventArgs e)
        {
            if (ReservationGridview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationGridview.SelectedRows[0];

                ReserIdtb.Text = selectedRow.Cells["Id"].Value.ToString();
                ClientNamecb.SelectedValue = selectedRow.Cells["Client"].Value.ToString();
                RoomNumbercb.SelectedValue = selectedRow.Cells["Room"].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl where Client='" + ReservationSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}

