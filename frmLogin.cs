using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DbConnect db = new DbConnect();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Users where UserName=@p1 and Password=@p2", db.Connection());
            cmd.Parameters.AddWithValue("@p1", txUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyin.");
            }
            db.Connection().Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txUserName.Text = "admin";
            txPassword.Text = "admin";
        }
    }
}
