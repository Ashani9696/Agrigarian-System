using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Agrigarian
{
    public partial class Student : Form
    {
        DatabaseManager dObj = new DatabaseManager();
        string id;
        bool state = false;
        public Student()
        {
            InitializeComponent();
            show();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(st_fname.Text) && string.IsNullOrEmpty(st_dob.Text) && string.IsNullOrEmpty(st_add.Text) && string.IsNullOrEmpty(st_lname.Text) && string.IsNullOrEmpty(st_phone.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(st_fname.Text))
            {
                MessageBox.Show("Please Enter your First Name");
            }
            else if (string.IsNullOrEmpty(st_lname.Text))
            {
                MessageBox.Show("Please Enter your Last Name");
            }
            else if (st_fname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First Name Cannot be Numbers");
            }
            else if (st_lname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Last Name Cannot be Numbers");
            }
            
            else if (string.IsNullOrEmpty(st_add.Text))
            {
                MessageBox.Show("Please Enter  Address");
            }
            else if (string.IsNullOrEmpty(st_phone.Text))
            {
                MessageBox.Show("Please Enter Telephone Number");
            }
            else if (!Regex.IsMatch(st_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {
                int i = dObj.insertUpdateDelete("INSERT INTO Student VALUES('" + st_fname.Text + "','"+st_lname.Text+"','"+ st_add.Text+ "','"+ st_dob.Value.Date+ "','"+ st_phone.Text+ "')");

                if (i == 1)
                {
                    MessageBox.Show("Inserted Success");
                    show();
                    st_fname.Text = "";
                    st_lname.Text = "";
                    st_add.Text = "";
                    st_phone.Text = "";
                    

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
            dt1 = dObj.getData("SELECT * FROM Student");
            dgvstudent.AutoGenerateColumns = false;
            dgvstudent.DataSource = dt1;

        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(st_fname.Text) && string.IsNullOrEmpty(st_dob.Text) && string.IsNullOrEmpty(st_add.Text) && string.IsNullOrEmpty(st_lname.Text) && string.IsNullOrEmpty(st_phone.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if (string.IsNullOrEmpty(st_fname.Text))
            {
                MessageBox.Show("Please Enter your First Name");
            }
            else if (string.IsNullOrEmpty(st_lname.Text))
            {
                MessageBox.Show("Please Enter your Last Name");
            }
            else if (st_fname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First Name Cannot be Numbers");
            }
            else if (st_lname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Last Name Cannot be Numbers");
            }
           
            else if (string.IsNullOrEmpty(st_add.Text))
            {
                MessageBox.Show("Please Enter  Address");
            }
            else if (string.IsNullOrEmpty(st_phone.Text))
            {
                MessageBox.Show("Please Enter Telephone Number");
            }
            else if (!Regex.IsMatch(st_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {
                if (dObj.check("SELECT * FROM Student WHERE student_id='" + id + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("UPDATE Student SET f_name = '" + st_fname.Text + "',l_name = '" + st_lname.Text + "',st_address='"+ st_add.Text + "',dob='"+ st_dob.Value.Date + "',st_tp='"+ st_phone.Text + "' WHERE student_id = '" + id + "'");
                    if (i == 1)
                    {
                        MessageBox.Show("Updated Success");
                        show();
                        st_fname.Text = "";
                        st_lname.Text = "";
                        st_add.Text = "";
                        st_phone.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }


                }


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("Please Fill the fields");
            }
            else
            {
                if (dObj.check("SELECT * FROM Student WHERE student_id='" + id + "'") == 1)
                {
                    int i = dObj.insertUpdateDelete("DELETE  FROM Student WHERE student_id = '" + id + "'");

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

        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            state = true;
            id = this.dgvstudent.CurrentRow.Cells[0].Value.ToString();
            st_fname.Text = this.dgvstudent.CurrentRow.Cells[1].Value.ToString();
            st_lname.Text = this.dgvstudent.CurrentRow.Cells[2].Value.ToString();
            st_add.Text = this.dgvstudent.CurrentRow.Cells[3].Value.ToString();
            st_dob.Text = this.dgvstudent.CurrentRow.Cells[4].Value.ToString();
            st_phone.Text = this.dgvstudent.CurrentRow.Cells[5].Value.ToString();

            // txt_tele.Text = this.dgvManagerDetails.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtSearchst_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dObj.getData("SELECT * FROM Student WHERE student_id LIKE '" + txtSearchst.text + "%' OR f_name LIKE '" + txtSearchst.text + "%' OR l_name LIKE '" + txtSearchst.text + "%' ");
            dgvstudent.AutoGenerateColumns = false;
            dgvstudent.DataSource = dt;
        }
    }
}
