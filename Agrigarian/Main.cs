using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrigarian
{
    public partial class Main : Form
    {
        DatabaseManager dObj = new DatabaseManager();
        public Main()
        {
            InitializeComponent();
            countShow();
        }

        private void countShow()
        {
            DataTable dt1 = new DataTable();
            dt1 = dObj.getData("SELECT * FROM Area");
            lblAreas.Text = dt1.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = dObj.getData("SELECT * FROM Employee");
            lblEmp.Text = dt2.Rows.Count.ToString();

            DataTable dt3 = new DataTable();
            dt3 = dObj.getData("SELECT * FROM Fertilizer,Supplier WHERE Fertilizer.supplier_id = Supplier.supplier_id");
            lblFertSupp.Text = dt3.Rows.Count.ToString();

            DataTable dt4 = new DataTable();
            dt4 = dObj.getData("SELECT * FROM Student");
            lblStudent.Text = dt4.Rows.Count.ToString();
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            FormArea areObj = new FormArea();
            this.Hide();
            areObj.Show();
        }

        private void btn_fertisup_Click(object sender, EventArgs e)
        {
            FertilizerSupplier ferSupObj = new FertilizerSupplier();
            this.Hide();
            ferSupObj.Show();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            Employee empObj = new Employee();
            this.Hide();
            empObj.Show();
        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            Student stObj = new Student();
            this.Hide();
            stObj.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Close();
            objLogin.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
