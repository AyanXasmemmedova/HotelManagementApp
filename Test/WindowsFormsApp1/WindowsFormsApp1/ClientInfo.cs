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
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HOME-PC\MSSQLSERVER01;Initial Catalog=TestDB;Integrated Security=True");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
           
        }
        
        private void ClientInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ClientId = clientidtbl.Text;
                string ClientName = ClientNametb.Text;
                string ClientPhone = ClientPhonetb.Text;
                string ClientEmail = ClientEmailtb.Text;

                
                Con.Open();

                
                SqlCommand cmd = new SqlCommand("INSERT INTO Client_tbl (ClientId, ClientName, ClientPhone, ClientEmail) VALUES (@ClientId, @ClientName, @ClientPhone, @ClientEmail)", Con);

               
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ClientId", ClientId);
                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                cmd.Parameters.AddWithValue("@ClientPhone", ClientPhone);
                cmd.Parameters.AddWithValue("@ClientEmail", ClientEmail);

                
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client_tbl", Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);

                var ds = new DataSet();
                da.Fill(ds);

                ClientGridview.DataSource = ds.Tables[0];

                MessageBox.Show("Client Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                Con.Close();
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientGridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ClientGridview.SelectedRows[0];

                    int ClientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value);
                    string ClientName = ClientNametb.Text;
                    string ClientPhone = ClientPhonetb.Text;
                    string ClientEmail = ClientEmailtb.Text;

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Client_tbl SET ClientName = @ClientName, ClientPhone = @ClientPhone, ClientEmail = @ClientEmail WHERE ClientId = @ClientId", Con);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ClientId", ClientId);
                    cmd.Parameters.AddWithValue("@ClientName", ClientName);
                    cmd.Parameters.AddWithValue("@ClientPhone", ClientPhone);
                    cmd.Parameters.AddWithValue("@ClientEmail", ClientEmail);
                    cmd.ExecuteNonQuery();

                    selectedRow.Cells["ClientName"].Value = ClientName;
                    selectedRow.Cells["ClientPhone"].Value = ClientPhone;
                    selectedRow.Cells["ClientEmail"].Value = ClientEmail;

                    MessageBox.Show("Client Successfully Updated");
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


        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ClientGridview.Rows[e.RowIndex];


                clientidtbl.Text = selectedRow.Cells["ClientId"].Value.ToString();
                ClientNametb.Text = selectedRow.Cells["ClientName"].Value.ToString();
                ClientPhonetb.Text = selectedRow.Cells["ClientPhone"].Value.ToString();
                ClientEmailtb.Text = selectedRow.Cells["ClientEmail"].Value.ToString();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (ClientGridview.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = ClientGridview.SelectedRows[0];

                    int clientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value);

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Client_tbl WHERE ClientId = @ClientId", Con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.ExecuteNonQuery();

                    ClientGridview.Rows.Remove(selectedRow);

                    MessageBox.Show(" Client Successfully Deleted");
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
            string clientName = ClientSearchtb.Text;

            
            string myquery = "SELECT * FROM Client_tbl WHERE ClientName = @ClientName";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.Parameters.AddWithValue("@ClientName", clientName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);

            var ds = new DataSet();
            da.Fill(ds);

            ClientGridview.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
