using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dental_Clinic_Management_Project
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        ConnectionString MyConnection = new ConnectionString();
        private void DashBoard_Load(object sender, EventArgs e)
        {
            PendingAppProgress.Value = 100;
            UsersProgress.Value = 100;
            Patients.Value = 100;
            NextApp.Value = 100;
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AppointmentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Pendinglbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from PatientTbl", Con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            Patientlbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            Userlbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Appointment App = new Appointment();
            App.Show();
            this.Hide();
        }
    }
}
