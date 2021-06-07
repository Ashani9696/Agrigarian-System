using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrigarian
{
    public partial class Employee : Form
    {

        DatabaseManager dObj = new DatabaseManager();
        private string id;
        private bool state = false;
        public Employee()
        {
            InitializeComponent();
            show(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpName.Text) && string.IsNullOrEmpty(txtEmpNic.Text) && string.IsNullOrEmpty(txtEmpTele.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(txtEmpName.Text))
            {
                MessageBox.Show("Please Enter the name");
            }
            else if (txtEmpName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Cannot be Numbers");
            }
            else if (!((txtEmpNic.Text.Count(char.IsDigit) == 9) && (txtEmpNic.Text.EndsWith("X") || txtEmpNic.Text.EndsWith("V")) && (txtEmpNic.Text[2] != '4' && txtEmpNic.Text[2] != '9')))
            {
                MessageBox.Show("Please Enter the NIC number");
            }
            else if (string.IsNullOrEmpty(txtEmpTele.Text))
            {
                MessageBox.Show("Please Enter the telephone number");
            }
            else if (!Regex.IsMatch(txtEmpTele.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {
                int i = dObj.insertUpdateDelete("INSERT INTO Employee VALUES('" + txtEmpName.Text + "','" + txtEmpNic.Text + "','" + txtEmpTele.Text + "',SYSDATETIME())");

                if (i == 1)
                {
                    MessageBox.Show("Inserted Success");
                    show();
                    txtEmpName.Text = "";
                    txtEmpNic.Text = "";
                    txtEmpTele.Text = "";

                }
                else
                {
                    MessageBox.Show("Not inserted");
                }

            }
        }

        private void show()
        {
            DataTable dt1 = new DataTable();
            dt1 = dObj.getData("SELECT * FROM Employee");
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = dt1;

        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dObj.getData("SELECT * FROM Employee WHERE employee_id LIKE '" + txtSearch.text + "%' OR employee_name LIKE '" + txtSearch.text + "%' OR employee_NIC LIKE '" + txtSearch.text + "%' ");
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpName.Text) && string.IsNullOrEmpty(txtEmpNic.Text) && string.IsNullOrEmpty(txtEmpTele.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(txtEmpName.Text))
            {
                MessageBox.Show("Please Enter the name");
            }
            else if (txtEmpName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Cannot be Numbers");
            }
            else if (string.IsNullOrEmpty(txtEmpTele.Text))
            {
                MessageBox.Show("Please Enter the telephone number");
            }
            else if (!Regex.IsMatch(txtEmpTele.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {

                if (dObj.check("SELECT * FROM Employee WHERE employee_id='" + id + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("UPDATE Employee SET employee_name = '" + txtEmpName.Text + "',employee_NIC = '" + txtEmpNic.Text + "',employee_oficial_telephone = '" + txtEmpTele.Text + "' WHERE employee_id = '" + id + "'");

                    if (i == 1)
                    {
                        MessageBox.Show("Updated Success");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (dObj.check("SELECT * FROM Employee WHERE employee_id='" + id + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("DELETE  FROM Employee WHERE employee_id = '" + id + "'");

                    if (i == 1)
                    {
                        MessageBox.Show("Deleted Success");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }


            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state = true;
            id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtEmpName.Text = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtEmpNic.Text = this.dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtEmpTele.Text = this.dgvEmployee.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
