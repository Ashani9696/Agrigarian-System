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
    public partial class FormArea : Form
    {
        DatabaseManager ObjDB = new DatabaseManager();
        string areaId, fieldId;
        bool areaState = false, fieldState = false;

        public FormArea()
        {
            InitializeComponent();
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtArea.Text) && string.IsNullOrEmpty(txtNumOfField.Text) && string.IsNullOrEmpty(txtEmpId.Text))
            {
                MessageBox.Show("Please Fill the  Fields");
            }
            else if (string.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("Area can't be empty");
            }
            else if (string.IsNullOrEmpty(txtNumOfField.Text))
            {
                MessageBox.Show("Please Enter Number Of Fields");
            }
            else if (string.IsNullOrEmpty(txtEmpId.Text))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            

            else
            {
                txtArea.Enabled = false;
                txtNumOfField.Enabled = false;
                txtEmpId.Enabled = false;
                txtFieldName.Enabled = true;
                txtLandOwner.Enabled = true;
                txtSize.Enabled = true;
                txtFarmer.Enabled = true;
                btnSaveField.Enabled = true;
                btnUpdateField.Enabled = true;
                btnDeleteField.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                string query = "INSERT INTO Area VALUES ('"+txtArea.Text+"','"+ txtNumOfField.Text+ "','"+ txtEmpId .Text + "')";
                
                if(ObjDB.insertUpdateDelete(query) == 1)
                { 
                   
                    MessageBox.Show("Insert Successfull");
                    show();
                    txtArea.Text = "";
                    //txtNumOfField.Text = "";
                    //txtEmpId.Text = "";

                }
                else
                {
                    MessageBox.Show("Not inserted Values");
                }
                fsize = Convert.ToInt32(txtNumOfField.Text);
                txtAreaID.Text = ObjDB.getValue("SELECT * FROM Area", empId, 4,1);
            }
        }

        int i = 0;
        private void btnSaveField_Click(object sender, EventArgs e)
        {
            
            if(i != fsize)
            {
                i++;
                string query = "INSERT INTO Field VALUES ('" + txtFieldName.Text + "','" + txtSize.Text + "','" + txtFarmer.Text + "','" + txtLandOwner.Text + "','" + txtAreaID.Text + "')";
                if (ObjDB.insertUpdateDelete(query) == 1)
                {
                    show();
                    MessageBox.Show("Insert Successfull");
                    
                }
                else
                {
                    MessageBox.Show("Not inserted Values");
                }

                txtFieldName.ResetText();
                txtSize.ResetText();
                txtFarmer.ResetText();
                txtLandOwner.ResetText();
            }
            else
            {
                txtArea.Enabled = true;
                txtNumOfField.Enabled = true;
                txtEmpId.Enabled = true;
                txtFieldName.Enabled = false;
                txtLandOwner.Enabled = false;
                txtSize.Enabled = false;
                txtFarmer.Enabled = false;
                btnSaveField.Enabled = false;
                btnUpdateField.Enabled = false;
                btnDeleteField.Enabled = false;
                btnSave.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtAreaID.ResetText(); //== txtAreaID.text = "";
                txtFieldName.ResetText();
                txtSize.ResetText();
                txtFarmer.ResetText();
                txtLandOwner.ResetText();
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
        }

        private void FormArea_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            DataTable dt1 = new DataTable();
            dt1 = ObjDB.getData("select * from Area");
            dgvArea.AutoGenerateColumns = false;
            dgvArea.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = ObjDB.getData("select * from Field");
            dgvField.AutoGenerateColumns = false;
            dgvField.DataSource = dt2;
        }

        private void txtSearchArea_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = ObjDB.getData("SELECT * FROM Area WHERE area_id LIKE '" + txtSearchArea.text + "%' OR area_name LIKE '" + txtSearchArea.text + "%' OR employee_id LIKE '" + txtSearchArea.text + "%' ");
            dgvArea.AutoGenerateColumns = false;
            dgvArea.DataSource = dt1;
        }

        private void dgvField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fieldState = true;
            fieldId = this.dgvField.CurrentRow.Cells[0].Value.ToString();
            txtFieldName.Text = this.dgvField.CurrentRow.Cells[1].Value.ToString();
            txtSize.Text = this.dgvField.CurrentRow.Cells[2].Value.ToString();
            txtFarmer.Text = this.dgvField.CurrentRow.Cells[3].Value.ToString();
            txtLandOwner.Text = this.dgvField.CurrentRow.Cells[4].Value.ToString();

            btnDeleteField.Enabled = true;
            btnUpdateField.Enabled = true;

            txtFieldName.Enabled = true;
            txtSize.Enabled = true;
            txtFarmer.Enabled = true;
            txtLandOwner.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e) //validation karanna mekath
        {
            if (string.IsNullOrEmpty(txtArea.Text) && string.IsNullOrEmpty(txtNumOfField.Text) && string.IsNullOrEmpty(txtEmpId.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (ObjDB.check("SELECT * FROM Area WHERE area_id='" + areaId + "'") == 1)
                {
                    int i = ObjDB.insertUpdateDelete("UPDATE Area SET area_name = '" + txtArea.Text + "',number_of_fields = '" + txtNumOfField.Text + "',employee_id = '" + txtEmpId.Text + "' WHERE area_id = '" + areaId + "'");

                    if (i == 1)
                    {
                        MessageBox.Show("Updated Success");
                        show();
                        txtArea.Text = "";
                        txtNumOfField.Text = "";
                        txtEmpId.Text = "";

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
            if (!areaState)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (ObjDB.check("SELECT * FROM Area WHERE area_id='" + areaId + "'") == 1)
                {
                    int j = ObjDB.insertUpdateDelete("DELETE  FROM Field WHERE area_id = '" + areaId + "'");
                    int i = ObjDB.insertUpdateDelete("DELETE  FROM Area WHERE area_id = '" + areaId + "'");

                    if (i == 1 || j == 1)
                    {
                        MessageBox.Show("Deleted Success");
                        show();
                        txtArea.Text = "";
                        txtNumOfField.Text = "";
                        txtEmpId.Text = "";

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

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            if (!fieldState)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (ObjDB.check("SELECT * FROM Field WHERE field_id='" + fieldId + "'") == 1)
                {
                    int i = ObjDB.insertUpdateDelete("DELETE  FROM Field WHERE field_id = '" + fieldId + "'");

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

        private void btnUpdateField_Click(object sender, EventArgs e) //mekath validation karanna
        {
            if (string.IsNullOrEmpty(txtFieldName.Text) && string.IsNullOrEmpty(txtSize.Text) && string.IsNullOrEmpty(txtFarmer.Text) && string.IsNullOrEmpty(txtLandOwner.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (ObjDB.check("SELECT * FROM Field WHERE field_id='" + fieldId + "'") == 1)
                {

                    string idArea = ObjDB.getValue("SELECT * FROM Field", fieldId,1,6);
                    int i = ObjDB.insertUpdateDelete("UPDATE Field SET field_name = '" + txtFieldName.Text + "',field_size = '" + txtSize.Text + "',farmer_name = '" + txtFarmer.Text + "',land_owner_name = '" + txtLandOwner.Text + "',area_id = '" + idArea + "' WHERE field_id = '" + fieldId + "'");

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
        private int fsize;
        private void txtNumOfField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fsize = Convert.ToInt32(txtNumOfField.Text);
            }
            catch
            {
                //
            }
        }

        private string empId;
        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            empId = txtEmpId.Text;
        }

        private void txtSearchField_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = ObjDB.getData("SELECT * FROM Field WHERE field_id LIKE '" + txtSearchField.text + "%' OR field_name LIKE '" + txtSearchField.text + "%' OR farmer_name LIKE '" + txtSearchField.text + "%' OR land_owner_name LIKE '" + txtSearchField.text + "%' ");
            dgvField.AutoGenerateColumns = false;
            dgvField.DataSource = dt2; 
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            areaState = true;
            areaId = this.dgvArea.CurrentRow.Cells[0].Value.ToString();
            txtArea.Text = this.dgvArea.CurrentRow.Cells[1].Value.ToString();
            txtNumOfField.Text = this.dgvArea.CurrentRow.Cells[2].Value.ToString();
            txtEmpId.Text = this.dgvArea.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
