using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class RoomInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public RoomInfo()
        {
            InitializeComponent();
            RoomGridview.CellClick += new DataGridViewCellEventHandler(RoomGridview_CellClick);
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
             populate();
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string isfree;
                if (Yesradio.Checked == true)
                {
                    isfree = "free";
                }
                else
                {
                    isfree = "busy";
                }
                string RoomId = RoomNumbertb.Text;
                string RoomCapacity = RoomCounttb.Text;
                string RoomPrice =RoomPricetb.Text;
                

                
                Con.Open();

                
                SqlCommand cmd = new SqlCommand("INSERT INTO Room_tbl (RoomId, RoomCapacity, RoomPrice, RoomFree) VALUES (@RoomId, @RoomCapacity, @RoomPrice, @RoomFree)", Con);
                cmd.Parameters.AddWithValue("@RoomId", RoomId);
                cmd.Parameters.AddWithValue("@RoomCapacity", RoomCapacity);
                cmd.Parameters.AddWithValue("@RoomPrice", RoomPrice);
                cmd.Parameters.AddWithValue("@RoomFree", isfree);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Room_tbl", Con);
                var ds = new DataSet();
                da.Fill(ds);

                
                RoomGridview.DataSource = ds.Tables[0];

                MessageBox.Show("Room Successfully Added");

                
                RoomNumbertb.Clear();
                RoomCounttb.Clear();
                RoomPricetb.Clear();
               
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

        private void RoomGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = RoomGridview.Rows[e.RowIndex];

                RoomNumbertb.Text = selectedRow.Cells["RoomId"].Value.ToString();
                RoomCounttb.Text = selectedRow.Cells["RoomCapacity"].Value.ToString();
                RoomPricetb.Text = selectedRow.Cells["RoomPrice"].Value.ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void EditRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomGridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = RoomGridview.SelectedRows[0];

                    int RoomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);
                    string RoomCapacity = RoomCounttb.Text;
                    string RoomPrice = RoomPricetb.Text;
                    
                    string isfree;
                    if (Yesradio.Checked == true)
                    {
                        isfree = "free";
                    }
                    else
                    {
                        isfree = "busy";
                    }

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Room_tbl SET RoomCapacity = @RoomCapacity, RoomPrice = @RoomPrice, RoomFree = @RoomFree WHERE RoomId = @RoomId", Con);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@RoomId", RoomId);
                    cmd.Parameters.AddWithValue("@RoomCapacity", RoomCapacity);
                    cmd.Parameters.AddWithValue("@RoomPrice", RoomPrice);
                    cmd.Parameters.AddWithValue("@RoomFree", isfree);
                    cmd.ExecuteNonQuery();

                    selectedRow.Cells["RoomCapacity"].Value = RoomCapacity;
                    selectedRow.Cells["RoomPrice"].Value = RoomPrice;
                    selectedRow.Cells["RoomFree"].Value = isfree;

                    MessageBox.Show("Room Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Choose data");
                }
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

        private void DeleteRoombtn_Click(object sender, EventArgs e)
        {
            if (RoomGridview.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = RoomGridview.SelectedRows[0];

                    int RoomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Room_tbl WHERE RoomId = @RoomId", Con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@RoomId", RoomId);
                    cmd.ExecuteNonQuery();

                    RoomGridview.Rows.Remove(selectedRow);

                    MessageBox.Show(" Room Successfully Deleted");
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
            else
            {
                MessageBox.Show("Choose data.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where RoomId='" + RoomSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
