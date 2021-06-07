using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Agrigarian
{
    public partial class FertilizerSupplier : Form
    {
        DatabaseManager dObj = new DatabaseManager();
        private string SuppId, FertId, aid;
        private bool SuppState = false, FertState = false;
        public FertilizerSupplier()
        {
            InitializeComponent();
            show();
            txtFerName.Enabled = false;
            txtFerQuan.Enabled = false;
            txtFerTotalAmount.Enabled = false;
            btnFertSave.Enabled = false;
            btnFertUpdate.Enabled = false;
            btnFertDelete.Enabled = false;
        }

        private void show()
        {
            DataTable dt1 = new DataTable();
            dt1 = dObj.getData("SELECT * FROM Supplier"); 
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = dObj.getData("SELECT * FROM Fertilizer");
            dgvFertilizer.AutoGenerateColumns = false;
            dgvFertilizer.DataSource = dt2;

            
        }

        private void FertilizerSupplier_Load(object sender, EventArgs e)
        {
            txtFerName.Enabled = false;
            txtFerQuan.Enabled = false;
            txtFerTotalAmount.Enabled = false;
            btnFertSave.Enabled = false;
            btnFertUpdate.Enabled = false;
            btnFertDelete.Enabled = false;
        }

        private void txtFerUPrice_TextChanged(object sender, EventArgs e)
        {
           try
            {
                txtFerTotalAmount.Text = (Convert.ToDouble(txtFerQuan.Text) * Convert.ToDouble(txtFerUPrice.Text)).ToString();
            }
            catch(FormatException)
            {
                //
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFerName.Text) && string.IsNullOrEmpty(txtFerQuan.Text) && string.IsNullOrEmpty(txtFerTotalAmount.Text) && string.IsNullOrEmpty(txtFerUPrice.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(txtFerName.Text))
            {
                MessageBox.Show("Please Enter Fertilizer Name");
            }
            else if (string.IsNullOrEmpty(txtFerQuan.Text))
            {
                MessageBox.Show("Enter the Quantity");
            }
            else if (txtFerQuan.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please Enter numbers only");
            }
            else if (string.IsNullOrEmpty(txtFerTotalAmount.Text))
            {
                MessageBox.Show("Total amount can't be Empty");
            }
            else if (string.IsNullOrEmpty(txtFerUPrice.Text))
            {
                MessageBox.Show("Please Enter Unit Price");
            }
            else
            {

                if (dObj.check("SELECT * FROM Fertilizer WHERE fertilizer_id='" + FertId + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("UPDATE Fertilizer SET fertilizer_name = '" + txtFerName.Text + "',official_unit_price = '" + txtFerUPrice.Text + "',quantity = '" + txtFerQuan.Text + "' WHERE fertilizer_id = '" + FertId + "'");

                    if (i == 1)
                    {
                        MessageBox.Show("Updated Success");
                        show();
                        txtFerName.Text = "";
                        txtFerQuan.Text = "";
                        txtFerUPrice.Text = "";
                        txtFerTotalAmount.Text = "";

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

        private void sup_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSuppName.Text) && string.IsNullOrEmpty(txtSuppAddress.Text) && string.IsNullOrEmpty(txtSuppTp.Text))
            {
                MessageBox.Show("Please Fill the  Fields");
            }
            else if(string.IsNullOrEmpty(txtSuppName.Text))
            {
                MessageBox.Show("Please Enter Supplier Name");
            }
            else if (string.IsNullOrEmpty(txtSuppAddress.Text))
            {
                MessageBox.Show("Please Enter Supplier Address");
            }
            else if (string.IsNullOrEmpty(txtSuppTp.Text))
            {
                MessageBox.Show("Please Enter Supplier Telephone Number");
            }
            else if (!Regex.IsMatch(txtSuppTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {
                txtSuppName.Enabled = false;
                txtSuppAddress.Enabled = false;
                txtSuppTp.Enabled = false;
                btnSuppSave.Enabled = false;
                btnSuppUpdate.Enabled = false;
                btnSuppDelete.Enabled = false;

                string query = "INSERT INTO  Supplier VALUES ('" + txtSuppName.Text + "','" + txtSuppAddress.Text + "','" + txtSuppTp.Text + "')";

                if (dObj.insertUpdateDelete(query) == 1)
                {

                    MessageBox.Show("Insert Successfull");
                    show();
                    
                }
                else
                {
                    MessageBox.Show("Not inserted Values");
                }
            }
        }

        private void btnSuppUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSuppName.Text) && string.IsNullOrEmpty(txtSuppAddress.Text) && string.IsNullOrEmpty(txtSuppTp.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(txtSuppName.Text))
            {
                MessageBox.Show("Please Enter Supplier Name");
            }
            else if (string.IsNullOrEmpty(txtSuppAddress.Text))
            {
                MessageBox.Show("Please Enter Supplier Address");
            }
            else if (string.IsNullOrEmpty(txtSuppTp.Text))
            {
                MessageBox.Show("Please Enter Supplier Telephone Number");
            }
            else if (!Regex.IsMatch(txtSuppTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }

            else
            {

                if (dObj.check("SELECT * FROM Supplier WHERE supplier_id='" + SuppId + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("UPDATE Supplier SET supplier_name = '" + txtSuppName.Text + "',supplier_address = '" + txtSuppAddress.Text + "',suppplier_telephone = '" + txtSuppTp.Text + "' WHERE supplier_id = '" + SuppId + "'");

                    if (i == 1)
                    {
                        MessageBox.Show("Updated Success");
                        show();
                        txtSuppName.Text = "";
                        txtSuppAddress.Text = "";
                        txtSuppTp.Text = "";
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

        private void btnSuppDelete_Click(object sender, EventArgs e)
        {
            if (!SuppState)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (dObj.check("SELECT * FROM Supplier WHERE supplier_id='" + SuppId + "'") == 1)
                {
                    int j = dObj.insertUpdateDelete("DELETE  FROM Fertilizer WHERE supplier_id = '" + SuppId + "'");
                    int i = dObj.insertUpdateDelete("DELETE  FROM Supplier WHERE supplier_id = '" + SuppId + "'");

                    if (i == 1 || j == 1)
                    {
                        MessageBox.Show("Deleted Success");
                        show();
                        txtSuppName.Text = "";
                        txtSuppAddress.Text = "";
                        txtSuppTp.Text = "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string tpNumber;
        private void txtSuppTp_TextChanged(object sender, EventArgs e)
        {
            tpNumber = txtSuppTp.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!FertState)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {

                if (dObj.check("SELECT * FROM Fertilizer WHERE fertilizer_id='" + FertId + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("DELETE  FROM Fertilizer WHERE fertilizer_id = '" + FertId + "'");
                    if(i==1)
                    {
                        MessageBox.Show("DELETE Successfull");
                        show();
                        txtFerName.Text = "";
                        txtFerQuan.Text = "";
                        txtFerUPrice.Text = "";
                        txtFerTotalAmount.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }


            }
        }

        private void dgvFertilizer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FertState = true;
            FertId = this.dgvFertilizer.CurrentRow.Cells[0].Value.ToString();
            txtFerName.Text = this.dgvFertilizer.CurrentRow.Cells[1].Value.ToString();
            txtFerUPrice.Text = this.dgvFertilizer.CurrentRow.Cells[2].Value.ToString();
            txtFerQuan.Text = this.dgvFertilizer.CurrentRow.Cells[3].Value.ToString();

            
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SuppState = true;
            SuppId = this.dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            txtSuppName.Text = this.dgvSupplier.CurrentRow.Cells[1].Value.ToString();

            txtSuppAddress.Text = this.dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            txtSuppTp.Text = this.dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            txtSuppName.Enabled = true;

            txtSuppAddress.Enabled = true;
            txtSuppTp.Enabled = true;
            btnSuppUpdate.Enabled = true;
            btnSuppDelete.Enabled = true;

            txtFerName.Enabled = true;
            txtFerQuan.Enabled = true;
            txtFerUPrice.Enabled = true;
            txtFerTotalAmount.Enabled = true;
            btnFertSave.Enabled = true;
            btnFertUpdate.Enabled = true;
            btnFertDelete.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFerName.Text) && string.IsNullOrEmpty(txtFerQuan.Text) && string.IsNullOrEmpty(txtFerUPrice.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(txtFerName.Text))
            {
                MessageBox.Show("Please Enter Fertilizer Name");
            }
            else if (string.IsNullOrEmpty(txtFerQuan.Text))
            {
                MessageBox.Show("Enter the Quantity");
            }
            else if (txtFerQuan.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please Enter numbers only");
            }

            
            else if (string.IsNullOrEmpty(txtFerUPrice.Text))
            {
                MessageBox.Show("Please Enter Unit Price");
            }

            else
            {
                aid = dObj.getValue("SELECT * FROM Supplier", tpNumber, 4, 1);
                int i = dObj.insertUpdateDelete("INSERT INTO Fertilizer VALUES('" + txtFerName.Text + "', '" + txtFerUPrice.Text + "', '" + txtFerQuan.Text + "','" + aid + "')");

                if (i == 1)
                {
                    MessageBox.Show("Inserted Success");
                    show();
                    txtFerName.Text = "";
                    txtFerQuan.Text = "";
                    txtFerUPrice.Text = "";
                    txtFerTotalAmount.Text = "";


                }
                else
                {
                    MessageBox.Show("Not inserted");
                }
            }
        }
    }
}
