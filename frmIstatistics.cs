using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class frmIstatistics : Form
    {
        public frmIstatistics()
        {
            InitializeComponent();
        }
        DbConnect db = new DbConnect();
        
        private void frmIstatistics_Load(object sender, EventArgs e)
        {
            List();
        }

        void List()
        {
            //Toplam Personel Sayısı
            SqlCommand eQuery = new SqlCommand("select Count(*) from Employees", db.Connection());
            SqlDataReader ereader = eQuery.ExecuteReader();
            while (ereader.Read())
            {
                lEmployee.Text = ereader[0].ToString();
            }
            //Toplam Evli Personel Sayısı
            SqlCommand mQuery = new SqlCommand("select Count(*) from Employees where Status=1", db.Connection());
            SqlDataReader mreader = mQuery.ExecuteReader();
            while (mreader.Read())
            {
                lMarried.Text = mreader[0].ToString();
            }
            //Toplam Bekar Personel Sayısı
            SqlCommand sQuery = new SqlCommand("select Count(*) from Employees where Status=0", db.Connection());
            SqlDataReader sreader = sQuery.ExecuteReader();
            while (sreader.Read())
            {
                lSingle.Text = sreader[0].ToString();
            }
            //Toplam Şehir Sayısı
            SqlCommand cQuery = new SqlCommand("select Count(City) from Employees", db.Connection());
            SqlDataReader creader = cQuery.ExecuteReader();
            while (creader.Read())
            {
                lCities.Text = creader[0].ToString();
            }
            //Toplam Maaş Tutarı
            SqlCommand salQuery = new SqlCommand("select Sum(Salary) from Employees", db.Connection());
            SqlDataReader salreader = salQuery.ExecuteReader();
            while (salreader.Read())
            {
                lTotalSalary.Text = salreader[0].ToString()  + " TL";
            }
            //Ortalama Maaş Tutarı
            SqlCommand sSalQuery = new SqlCommand("select Avg(Salary) from Employees", db.Connection());
            SqlDataReader sSalreader = sSalQuery.ExecuteReader();
            while (sSalreader.Read())
            {
                lSumSalary.Text = sSalreader[0].ToString() + " TL";
            }
            db.Connection().Close();
        }
    }
}
