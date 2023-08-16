using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        DbConnect db = new DbConnect();

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        void Clear()
        {
            txName.Text = "";
            txSurName.Text = "";
            txCity.Text = "";
            rdMarried.Checked = false;
            rdSingle.Checked = false;
            txJob.Text = "";
        }
        void List()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees", db.Connection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Employees (Name,SurName,City,Salary,Status,Job) values(@p1,@p2,@p3,@p4,@p5,@p6)", db.Connection());
            cmd.Parameters.AddWithValue("@p1", txName.Text);
            cmd.Parameters.AddWithValue("@p2", txSurName.Text);
            cmd.Parameters.AddWithValue("@p3", txCity.Text);
            cmd.Parameters.AddWithValue("@p4", txSalary.Text);
            if (rdMarried.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", "True");
            }
            else if(rdSingle.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", "False");
            }
            else
            {
                MessageBox.Show("Lütfen Medeni Hal Seçin");
            }
            cmd.Parameters.AddWithValue("@p6", txJob.Text);
            cmd.ExecuteNonQuery();
            db.Connection().Close();
            Clear();
            List();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lbId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txSurName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txCity.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txSalary.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdMarried.Checked = true;
            }
            else
            {
                rdSingle.Checked = true;
            }
            txJob.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lbId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand(@"delete from Employees where Id=@p1", db.Connection());
            cmd.Parameters.AddWithValue("@p1", lbId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.Connection().Close();
            List();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Employees set Name=@p1,SurName=@p2,City=@p3,Salary=@p4,Status=@p5,Job=@p6 where Id=@p0", db.Connection());
            cmd.Parameters.AddWithValue("@p0", lbId.Text);
            cmd.Parameters.AddWithValue("@p1", txName.Text);
            cmd.Parameters.AddWithValue("@p2", txSurName.Text);
            cmd.Parameters.AddWithValue("@p3", txCity.Text);
            cmd.Parameters.AddWithValue("@p4", Convert.ToDecimal(txSalary.Text));
            if (rdMarried.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", "True");
            }
            else if (rdSingle.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", "False");
            }
            else
            {
                MessageBox.Show("Lütfen Medeni Hal Seçin");
            }
            cmd.Parameters.AddWithValue("@p6", txJob.Text);
            cmd.ExecuteNonQuery();
            db.Connection().Close();
            Clear();
            List();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btIstatistic_Click(object sender, EventArgs e)
        {
            frmIstatistics frm = new frmIstatistics();
            frm.ShowDialog();
        }

        private void btGraphic_Click(object sender, EventArgs e)
        {
            frmGraphics frm = new frmGraphics();
            frm.ShowDialog();
        }
    }
}
