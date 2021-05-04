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

namespace ConnectDB
{
    public partial class Form1 : Form
    {
        public static string State;
        public Form1()
        {
            InitializeComponent();
            GetData();
            State = "Reset";
            //setConTrol(State);
        }

        string connectionString = @"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=SinhVien;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection conn;
        DataSet ds;



        public void GetData()
        {
            conn = new SqlConnection(connectionString);
            string query = "select * from Table_sv";
            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataColumn colViewGioiTinh = new DataColumn();
                colViewGioiTinh.ColumnName = "view_gt";
                ds.Tables[0].Columns.Add(colViewGioiTinh);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["gt"].ToString() == "1")
                    {
                        dr["view_gt"] = "nam";
                    }
                    else
                        dr["view_gt"] = "nữ";
                }
                //dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gioitinh = -1;
            if (rdnam.Checked == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Text.ToString()).ToString());
            conn = new SqlConnection(connectionString);
            string query = "insert into Table_sv values('" + textBoxmsv.Text + "', N'" + textBoxten.Text + "', '" + gioitinh.ToString() + "', N'" + textBoxdiachi.Text + "', '" + Convert.ToDateTime(dateTimePicker1.Text.ToString()).ToString() + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var gioitinh = -1;
            if (rdnam.Checked == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Text.ToString()).ToString());
            conn = new SqlConnection(connectionString);
            string query = "update Table_sv set ten = '" + textBoxten.Text + "', gt = '" + gioitinh.ToString() + "', diachi = '" + textBoxdiachi.Text + "', ngaysinh = '" + Convert.ToDateTime(dateTimePicker1.Text.ToString()).ToString() + "' where msv = '" + textBoxmsv.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gioitinh = -1;
            if (rdnam.Checked == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Text.ToString()).ToString());
            conn = new SqlConnection(connectionString);
            string query = "delete Table_sv where msv = '" + textBoxmsv.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            GetData();
        }


        public void setConTrol(string State)
        {
            switch (State)
            {
                case "Reset":
                    textBoxmsv.Enabled = false;
                    textBoxten.Enabled = false;
                    textBoxdiachi.Enabled = false;
                    rdnam.Enabled = false;
                    rdnu.Enabled = false;
                    button4.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    break;
                default:
                    break;
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmsv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxdiachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if(dataGridView1.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                rdnam.Checked = true;
            }
            else
            {
                rdnu.Checked = true;
            }
        }
    }
}