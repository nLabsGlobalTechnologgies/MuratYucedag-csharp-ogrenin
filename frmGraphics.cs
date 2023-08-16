using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class frmGraphics : Form
    {
        public frmGraphics()
        {
            InitializeComponent();
        }

        DbConnect db = new DbConnect();
        private void frmGraphics_Load(object sender, System.EventArgs e)
        {
            //Şehirler Kodu aslında her şehre ait kaç personel var onun kodu
            SqlCommand cQuery = new SqlCommand("select City, Count(*) from Employees Group By City", db.Connection());
            SqlDataReader creader = cQuery.ExecuteReader();
            while (creader.Read())
            {
                cCities.Series["Sehirler"].Points.AddXY(creader[0], creader[1]);
            }

            //Meslekler Kodu buda her meslekte ortalama alınan maaş kodu
            SqlCommand jQuery = new SqlCommand("select Job, Avg(Salary) from Employees Group By Job", db.Connection());
            SqlDataReader jreader = jQuery.ExecuteReader();
            while (jreader.Read())
            {
                cJobs.Series["Meslek-Maas"].Points.AddXY(jreader[0], jreader[1]);
            }
            db.Connection().Close();
        }
    }
}
